using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuzonQuejas3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;


//autenticación
using Microsoft.AspNetCore.Authorization;

namespace BuzonQuejas3.Controllers
{
    public class QuejaController : Controller
    {
        private readonly Dev_BuzonQuejasContext _context;

        public QuejaController(Dev_BuzonQuejasContext context)
        {
            _context = context;
        }

        // GET: Queja
        //[Authorize(Roles = "Administrador,Root,UnidadAdministrativa")]
        public async Task<IActionResult> Index(string buscar, String filtro)
        {
            var unidadUsuario = HttpContext.User.FindFirst("UnidadAdministrativaID").Value;

            IQueryable<QuejaMostrar> quejasMostrar;
            //IQueryable<Queja> quejas;

            if (User.IsInRole("Administrador") || User.IsInRole("Root") || User.IsInRole("Departamental"))
            {
                //quejas = from Queja in _context.Quejas select Queja;
                quejasMostrar = from queja in _context.Quejas
                                join medio in _context.Medios on queja.MedioID equals medio.MedioID
                                //Where vehi.PatenteVehiculo == patente
                                select new QuejaMostrar
                                {
                                    QuejaID = queja.QuejaID,
                                    Folio = queja.Folio,
                                    NombreQuejante = queja.NombreQuejante,
                                    MotivoQueja = queja.MotivoQueja,
                                    ServidorInvolucrado = queja.ServidorInvolucrado,
                                    FechaCreacion = queja.FechaCreacion,
                                    Estatus = queja.Estatus,
                                    DepartamentoID = queja.DepartamentoID,
                                    MedioID = medio.MedioID,
                                    Medio = medio.Nombre,
                                    //llamar a todas las propiedades necesarias
                                };


            }
            else
            {
                //quejas = from Queja in _context.Quejas where Queja.UnidadAdministrativaID == Guid.Parse(unidadUsuario) select Queja;
                quejasMostrar = from queja in _context.Quejas
                                join medio in _context.Medios on queja.MedioID equals medio.MedioID
                                where queja.UnidadAdministrativaID == Guid.Parse(unidadUsuario)
                                select new QuejaMostrar
                                {
                                    QuejaID = queja.QuejaID,
                                    Folio = queja.Folio,
                                    NombreQuejante = queja.NombreQuejante,
                                    MotivoQueja = queja.MotivoQueja,
                                    ServidorInvolucrado = queja.ServidorInvolucrado,
                                    FechaCreacion = queja.FechaCreacion,
                                    Estatus = queja.Estatus,
                                    DepartamentoID = queja.DepartamentoID,
                                    MedioID = medio.MedioID,
                                    Medio = medio.Nombre,
                                    //llamar a todas las propiedades necesarias
                                };
            }

            //var unidades = await _context.UnidadAdministrativas.Where(q => q.Nombre != "General").ToListAsync();
            //ViewData["unidades"] = unidades;
            //var quejas = from Queja in _context.Quejas where Queja.Correo ==username select Queja;

            ViewData["FiltroFolio"] = String.IsNullOrEmpty(filtro) ? "FolioDescendiente" : "";
            ViewData["FiltroMedio"] = filtro == "MedioAscendente" ? "MedioDescendiente" : "MedioAscendente";
            ViewData["FiltroFecha"] = filtro == "FechaAscendente" ? "FechaDescendiente" : "FechaAscendente";
            ViewData["FiltroEstatus"] = filtro == "EstatusAscendente" ? "EstatusDescendiente" : "EstatusAscendente";


            switch (filtro)
            {
                case "FolioDescendiente":
                    quejasMostrar = quejasMostrar.OrderByDescending(queja => queja.Folio);
                    break;

                case "EstatusDescendiente":
                    quejasMostrar = quejasMostrar.OrderByDescending(queja => queja.Estatus);
                    break;

                case "MedioDescendiente":
                    quejasMostrar = quejasMostrar.OrderByDescending(queja => queja.MedioID);
                    break;

                case "FechaDescendiente":
                    quejasMostrar = quejasMostrar.OrderByDescending(queja => queja.FechaCreacion);
                    break;

                case "EstatusAscendente":
                    quejasMostrar = quejasMostrar.OrderBy(queja => queja.Estatus);
                    break;

                case "MedioAscendente":
                    quejasMostrar = quejasMostrar.OrderBy(queja => queja.MedioID);
                    break;

                case "FechaAscendente":
                    quejasMostrar = quejasMostrar.OrderBy(queja => queja.FechaCreacion);
                    break;

                default:
                    quejasMostrar = quejasMostrar.OrderBy(queja => queja.Folio);
                    break;

            }

            return View(await quejasMostrar.ToListAsync());
        }


        // GET: Queja/Details/5 No se ocupa
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var queja = await _context.Quejas
                .FirstOrDefaultAsync(m => m.QuejaID == id);
            if (queja == null)
            {
                return NotFound();
            }

            return View(queja);
        }

        [Authorize(Roles = "Administrador,Root,Departamental")]
        // GET: Queja/Create
        public IActionResult Create()
        {
            var lMunicipios = _context.Municipios.ToList();
            var listaMunicipios = new SelectList(lMunicipios.OrderBy(o => o.Nombre), "MunicipioID", "Nombre");
            ViewBag.municipios = listaMunicipios;

            var lCargos = _context.Cargos.ToList();
            var listaCargos = new SelectList(lCargos.OrderBy(o => o.Nombre), "CargoID", "Nombre");
            ViewBag.cargos = listaCargos;

            var lMedios = _context.Medios.ToList();
            var listaMedios = new SelectList(lMedios.OrderBy(o => o.Nombre), "MedioID", "Nombre");
            ViewBag.medios = listaMedios;

            //ViewBag.cadena = identificador + year + month + day;

            //var lUnidadAdministrativa = _context.UnidadAdministrativas.Where(q => q.Nombre != "General").ToList();
            //var listaUnidadAdministrativas = new SelectList(lUnidadAdministrativa.OrderBy(o => o.Nombre), "UnidadAdministrativaID", "Nombre");
            //ViewBag.unidadAdministrativas = listaUnidadAdministrativas;

            return View();
        }

        // POST: Queja/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,Departamental")]
        public async Task<IActionResult> Create([Bind("QuejaID,NombreQuejante,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,FechaCreacion,Estatus,FechaAtencion,AtendidoPor,Resolucion,DepartamentoID,MunicipioID,UnidadAdministrativaID,MedioID,CargoID,Folio")] Queja queja)
        {
            queja.AtendidoPor = "";
            queja.Resolucion = "";
            queja.FechaAtencion = queja.FechaCreacion;

            string identificador = "BQ";
            string year = DateTime.Now.ToString("yy");
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            var ultimaQueja = _context.Quejas.OrderBy(q => q.FechaCreacion).LastOrDefault();

            if (ultimaQueja != null)
            {
                string ultimoFolio = ultimaQueja.Folio;
                int tam_var = ultimoFolio.Length;

                string fechaUltimaQueja = ultimoFolio.Substring((tam_var - 10), 6);
                string actualFecha = year + month + day;

                if (Int32.Parse(actualFecha) == Int32.Parse(fechaUltimaQueja))
                {

                    int ultimosDigitosInt = Int32.Parse(ultimoFolio.Substring((tam_var - 4), 4));
                    ultimosDigitosInt++;
                    string nuevosDigitos = ultimosDigitosInt.ToString("0000");
                    string nuevoFolio = identificador + year + month + day + nuevosDigitos;

                    queja.Folio = nuevoFolio;
                }
                else
                {
                    queja.Folio = identificador + year + month + day + "0000";
                }
            }
            else
            {
                queja.Folio = identificador + year + month + day + "0000";
            }

            Console.WriteLine(queja);


            if (ModelState.IsValid)
            {
                queja.QuejaID = Guid.NewGuid();
                _context.Add(queja);
                await _context.SaveChangesAsync();
                ViewBag.SuccessMessage = " La queja ha sido levantada correctamente";
                return View();
            }
            else
            {
                ViewBag.SuccessMessage = " Hubo un error al levantar la queja";
                return View();
            }

        }

        // GET: Queja/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var queja = await _context.Quejas.FindAsync(id);
            if (queja == null)
            {
                return NotFound();
            }
            return View(queja);
        }

        // POST: Queja/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("QuejaID,NombreQuejante,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,DepartamentoAsignado,FechaCreacion,Estatus,FechaAtencion,AtendidoPor,Resolucion")] Queja queja)
        {
            if (id != queja.QuejaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(queja);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuejaExists(queja.QuejaID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(queja);
        }

        // GET: Queja/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var queja = await _context.Quejas
                .FirstOrDefaultAsync(m => m.QuejaID == id);
            if (queja == null)
            {
                return NotFound();
            }

            return View(queja);
        }

        // POST: Queja/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var queja = await _context.Quejas.FindAsync(id);
            _context.Quejas.Remove(queja);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuejaExists(Guid id)
        {
            return _context.Quejas.Any(e => e.QuejaID == id);
        }

        // GET: Queja/Edit/5
        //[Authorize(Roles = "Administrador,Root,UnidadAdministrativa")]
        public async Task<IActionResult> Seguimiento(Guid? id)
        {
            //var unidades = await _context.UnidadAdministrativas.ToListAsync();
            //ViewData["unidades"] = unidades;
            //var municipios = await _context.Municipios.ToListAsync();
            //ViewData["municipios"] = municipios;
            //var departamentos = await _context.Departamentos.ToListAsync();
            //ViewData["departamentos"] = departamentos;

            if (id == null)
            {
                return NotFound();
            }

            var queja = await _context.Quejas.FindAsync(id);
            if (queja == null)
            {
                return NotFound();
            }
            return View(queja);
        }

        // POST: Queja/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Departamental")]
        public async Task<IActionResult> Seguimiento(Guid id, [Bind("QuejaID,NombreQuejante,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,DepartamentoID,MunicipioID,UnidadAdministrativaID,FechaCreacion,Estatus,FechaAtencion,AtendidoPor,Resolucion,CargoID,MedioID,Folio")] Queja queja)
        {
            if (id != queja.QuejaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
            {
                    _context.Update(queja);
                    await _context.SaveChangesAsync();
                    ViewBag.SuccessMessageSeguimiento = "Se han guardado correctamente los cambios";
                    return View();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.SuccessMessageSeguimiento = "Error";

                    if (!QuejaExists(queja.QuejaID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View();
            //return RedirectToAction(nameof(Index));
            //return View(queja);
        }


        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public IActionResult Tablero(string buscar, String filtro)
        {
            ////Traer todas las quejas tipo IQuerable<Queja>
            //var quejas = from Queja in _context.Quejas select Queja;

            ////Traer la lista de unidades adim. 
            //var unidades = await _context.UnidadAdministrativas.ToListAsync();
            ////ViewData["unidades"] = unidades;

            ////Traer la lista de municipios. 
            //var municipios = await _context.Municipios.ToListAsync();
            ////ViewData["unidades"] = unidades;

            ////creación de un diccionario para llenar con cada unidad y su total de quejas
            //Dictionary<string, string> totalPorUnidad = new Dictionary<string, string>();
            //foreach (var unidad in unidades)
            //{
            //    int total = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID);
            //    totalPorUnidad.Add(unidad.Nombre, total.ToString());
            //}
            //ViewData["TotalPorUnidad"] = totalPorUnidad;


            ////creación de un diccionario para llenar sólo los municipios que tengan quejas
            //Dictionary<string, string> totalPorMunicipio = new Dictionary<string, string>();
            //foreach (var municipio in municipios)
            //{
            //    int total = quejas.Count(q => q.MunicipioID == municipio.MunicipioID);
            //    if (total > 0)
            //    {
            //        totalPorMunicipio.Add(municipio.Nombre, total.ToString());
            //    }
            //}
            //ViewData["TotalPorMunicipio"] = totalPorMunicipio;

            ////contar el total de quejas atendidas y pedientes
            //var totalAtendidas = quejas.Count(q => q.Estatus == "Atendido");
            //var totalPendientes = quejas.Count(q => q.Estatus == "Pendiente");

            //ViewBag.TotalAtendidas = totalAtendidas;
            //ViewBag.TotalPendientes = totalPendientes;

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasPorUnidades()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var unidades = _context.UnidadAdministrativas.OrderBy(u=> u.Nombre).ToList();

            List<Object> data = new List<Object>();
            List<string> unidadesNombre = new List<string>();
            List<int> unidadesTotal = new List<int>();

            foreach (var unidad in unidades)
            {
                int total = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID);
                //var randomNumber = new Random().Next(0, 1000);

                if (total > 0)
                {
                    unidadesNombre.Add(unidad.Nombre == "No Aplica" ? "Sin Asignar" : unidad.Nombre);
                    unidadesTotal.Add(total);
                }
            }

            data.Add(unidadesNombre);
            data.Add(unidadesTotal);

            return data;

        }
        
        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasPorDepartamento()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var departamentos = _context.Departamentos.ToList();

            List<Object> data = new List<Object>();
            List<string> departamentosNombre = new List<string>();
            List<int> departamentosTotal = new List<int>();

            foreach (var departamento in departamentos)
            {
                int total = quejas.Count(q => q.DepartamentoID == departamento.DepartamentoID);
                //var randomNumber = new Random().Next(0, 100000);

                if (total > 0)
                {
                    departamentosNombre.Add(departamento.Nombre == "No Aplica" ? "Sin Asignar" : departamento.Nombre);
                    departamentosTotal.Add(total);
                }
            }

            data.Add(departamentosNombre);
            data.Add(departamentosTotal);

            return data;

        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasEstatusPorUnidades()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var unidades = _context.UnidadAdministrativas.OrderBy(u => u.Nombre).ToList();

            List<Object> data = new List<Object>();
            List<string> unidadesNombre = new List<string>();
            List<int> atendidasTotal = new List<int>();
            List<int> pendientesTotal = new List<int>();

            foreach (var unidad in unidades)
            {
                int totalAtendidos = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID && q.Estatus == "Atendido");
                int totalPendientes = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID && q.Estatus == "Pendiente");
                //var randomNumber = new Random().Next(0, 1000);

                if(totalAtendidos > 0 || totalPendientes > 0)
                {
                unidadesNombre.Add(unidad.Nombre == "No Aplica" ? "Sin Asignar" : unidad.Nombre);
                atendidasTotal.Add(totalAtendidos);
                pendientesTotal.Add(totalPendientes);
                }
            }

            data.Add(unidadesNombre);
            data.Add(atendidasTotal);
            data.Add(pendientesTotal);

            return data;

        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasPorMunicipio()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var municipios = _context.Municipios.OrderBy(m => m.Nombre).ToList();

            List<Object> data = new List<Object>();
            List<string> municipiosNombre = new List<string>();
            List<int> municipiosTotal = new List<int>();


            foreach (var municipio in municipios)
            {
                int total = quejas.Count(q => q.MunicipioID == municipio.MunicipioID);
                //var randomNumber = new Random().Next(0, 100000);

                if (total > 0)
                {
                    municipiosNombre.Add(municipio.Nombre);
                    municipiosTotal.Add(total);
                }
            }

            data.Add(municipiosNombre);
            data.Add(municipiosTotal);

            return data;

        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasEstatusTotal()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            //var unidades = _context.UnidadAdministrativas.ToList();

            List<Object> data = new List<Object>();
            List<string> estatus = new List<string> { "Atendido", "Pendiente" };
            List<int> estatusTotal = new List<int>();


            int totalAtendidas = quejas.Count(q => q.Estatus == "Atendido");
            int totalPendientes = quejas.Count(q => q.Estatus == "Pendiente");
            int totalQuejas = quejas.Count();


            estatusTotal.Add(totalAtendidas);
            estatusTotal.Add(totalPendientes);
            estatusTotal.Add(totalQuejas);

            data.Add(estatus);
            data.Add(estatusTotal);

            return data;

        }       
        
        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasEstatusDiario()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var dateTimeActual = DateTime.Now.Date;
            //Console.WriteLine("date"+ dateTimeActual);
            //var unidades = _context.UnidadAdministrativas.ToList();

            var queja = _context.Quejas.FirstOrDefault(m => m.Resolucion == "nada");
            Console.WriteLine(queja.FechaCreacion.Date == dateTimeActual);

            List<Object> data = new List<Object>();
            List<string> estatus = new List<string> { "Total","Atendido", "Pendiente" };
            List<int> estatusTotal = new List<int>();


            int totalAtendidas = quejas.Where(q=> q.FechaCreacion.Date == dateTimeActual ).Count(q => q.Estatus == "Atendido");
            int totalPendientes = quejas.Where(q => q.FechaCreacion.Date== dateTimeActual).Count(q => q.Estatus == "Pendiente");
            int totalQuejas = quejas.Where(q => q.FechaCreacion.Date == dateTimeActual).Count();


            estatusTotal.Add(totalAtendidas);
            estatusTotal.Add(totalPendientes);
            estatusTotal.Add(totalQuejas);

            data.Add(estatus);
            data.Add(estatusTotal);

            return data;

        }
        
        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasEstatusAnual()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var dateTimeActual = DateTime.Now;
            //Console.WriteLine("date"+ dateTimeActual);
            //var unidades = _context.UnidadAdministrativas.ToList();

            var queja = _context.Quejas.FirstOrDefault(m => m.Resolucion == "nada");
            Console.WriteLine(queja.FechaCreacion.Date == dateTimeActual);

            List<Object> data = new List<Object>();
            List<string> estatus = new List<string> { "Enero","Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            List<int> estatusTotalPendientes = new List<int>();
            List<int> estatusTotalAtendidas = new List<int>();

            for (int i = 0; i < 12; i++)
            {
            int totalAtendidas = quejas.Where(q=> q.FechaCreacion.Month == i+1 && q.FechaCreacion.Year == dateTimeActual.Year).Count(q => q.Estatus == "Atendido");
            int totalPendientes = quejas.Where(q => q.FechaCreacion.Month == i+1 && q.FechaCreacion.Year == dateTimeActual.Year).Count(q => q.Estatus == "Pendiente");
             estatusTotalAtendidas.Add(totalAtendidas);
             estatusTotalPendientes.Add(totalPendientes);
            }

            data.Add(estatus);
            data.Add(estatusTotalAtendidas);
            data.Add(estatusTotalPendientes);

            return data;

        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental,Fiscal")]
        public List<Object> GetQuejasMedio()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var medios = _context.Medios.ToList();

            List<Object> data = new List<Object>();
            List<string> mediosNombre = new List<string>();
            List<int> mediosTotal = new List<int>();

            foreach (var medio in medios)
            {
                int total = quejas.Count(q => q.MedioID == medio.MedioID);

                mediosNombre.Add(medio.Nombre);
                mediosTotal.Add(total);
            }

            data.Add(mediosNombre);
            data.Add(mediosTotal);

            return data;

        }



        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,Departamental")]
        //get para mostrar unidades administrativas en modal al reasignar
        public async Task<ActionResult<IEnumerable<UnidadAdministrativa>>> GetUnidades()
        {
            //var unidades = await _context.UnidadAdministrativas.OrderBy(x => x.Nombre).ToListAsync();
            var unidades = await _context.UnidadAdministrativas.Where(q => q.Nombre != "No Aplica").OrderBy(x => x.Nombre).ToListAsync();
            return unidades;
        }
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa")]
        public async Task<UnidadAdministrativa> GetUnidad(string quejaId)
        {
            //var queja = await _context.Quejas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID == Guid.Parse(quejaId));
            var queja = await _context.Quejas.FindAsync(Guid.Parse(quejaId));
            var unidad = await _context.UnidadAdministrativas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID.Equals(queja.UnidadAdministrativaID));
            return unidad;
        }

        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Departamental")]

        //get para mostrar el nombre de la unidad en vez del id en seguimiento
        public async Task<UnidadAdministrativa> GetUnidadName(string idUnidad)
        {
            var unidad = await _context.UnidadAdministrativas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID.Equals(Guid.Parse(idUnidad)));
            return unidad;
        }

        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Departamental")]
        //get para mostrar el nombre del municipio en vez del id en seguimiento
        public async Task<Municipio> GetMunicipioName(string idMunicipio)
        {
            var municipio = await _context.Municipios.FirstOrDefaultAsync(m => m.MunicipioID.Equals(Guid.Parse(idMunicipio)));
            return municipio;
        }

        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Departamental")]
        //get para mostrar el nombre de el medio de reecpción en vez del id en seguimiento
        public async Task<Medio> GetMedioName(string idMedio)
        {
            var medio = await _context.Medios.FirstOrDefaultAsync(m => m.MedioID.Equals(Guid.Parse(idMedio)));
            return medio;
        }

        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Departamental")]

        //get para mostrar el nombre del cargo en vez del id en seguimiento
        public async Task<Cargo> GetCargoName(string idCargo)
        {
            var cargo = await _context.Cargos.FirstOrDefaultAsync(m => m.CargoID.Equals(Guid.Parse(idCargo)));
            return cargo;
        }

        [ActionName("Reasignar")]
        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Departamental")]

        //para poder reasignar quejas
        public async Task<IActionResult> Reasignar(string QuejaId, string unidadId)
        {
            var queja = await _context.Quejas.FindAsync(Guid.Parse(QuejaId));

            queja.UnidadAdministrativaID = Guid.Parse(unidadId);

            try
            {
                _context.Update(queja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuejaExists(queja.QuejaID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


            //return View();


        }
    }
}
