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
        [Authorize(Roles = "Administrador,Root,Administrativo")]
        public async Task<IActionResult> Index(string buscar, String filtro)
        {
            var unidadUsuario = HttpContext.User.FindFirst("UnidadAdministrativaID").Value;

            IQueryable<QuejaMostrar> quejasMostrar;
            //IQueryable<Queja> quejas;

            if (User.IsInRole("Administrador") || User.IsInRole("Root"))
            {
                //quejas = from Queja in _context.Quejas select Queja;
                quejasMostrar = from queja in _context.Quejas
                                join unidad in _context.UnidadAdministrativas on queja.UnidadAdministrativaID equals unidad.UnidadAdministrativaID
                                //Where vehi.PatenteVehiculo == patente
                                select new QuejaMostrar
                                {
                                    QuejaID = queja.QuejaID,
                                    NombreQuejante = queja.NombreQuejante,
                                    //Direccion = queja.Direccion,
                                    //Telefono= queja.Telefono,
                                    //Correo= queja.Correo,
                                    MotivoQueja = queja.MotivoQueja,
                                    RelatoHechos = queja.RelatoHechos,
                                    ServidorInvolucrado = queja.ServidorInvolucrado,
                                    FechaCreacion = queja.FechaCreacion,
                                    Estatus = queja.Estatus,
                                    //FechaAtencion =  queja.FechaAtencion,
                                    //AtendidoPor = queja.AtendidoPor,
                                    //Resolucion = queja.Resolucion,
                                    DepartamentoID = queja.DepartamentoID,
                                    //MunicipioID = queja.MunicipioID,
                                    UnidadAdministrativaID = unidad.UnidadAdministrativaID,
                                    UnidadAdministrativa = unidad.Nombre,
                                    //llamar a todas las propiedades necesarias
                                };


            }
            else
            {
                //quejas = from Queja in _context.Quejas where Queja.UnidadAdministrativaID == Guid.Parse(unidadUsuario) select Queja;
                quejasMostrar = from queja in _context.Quejas
                                join unidad in _context.UnidadAdministrativas on queja.UnidadAdministrativaID equals unidad.UnidadAdministrativaID
                                where queja.UnidadAdministrativaID == Guid.Parse(unidadUsuario)
                                select new QuejaMostrar
                                {
                                    QuejaID = queja.QuejaID,
                                    NombreQuejante = queja.NombreQuejante,
                                    //Direccion = queja.Direccion,
                                    //Telefono= queja.Telefono,
                                    //Correo= queja.Correo,
                                    MotivoQueja = queja.MotivoQueja,
                                    RelatoHechos = queja.RelatoHechos,
                                    ServidorInvolucrado = queja.ServidorInvolucrado,
                                    FechaCreacion = queja.FechaCreacion,
                                    Estatus = queja.Estatus,
                                    //FechaAtencion =  queja.FechaAtencion,
                                    //AtendidoPor = queja.AtendidoPor,
                                    //Resolucion = queja.Resolucion,
                                    DepartamentoID = queja.DepartamentoID,
                                    //MunicipioID = queja.MunicipioID,
                                    UnidadAdministrativaID = unidad.UnidadAdministrativaID,
                                    UnidadAdministrativa = unidad.Nombre,
                                    //llamar a todas las propiedades necesarias
                                };
            }

            var unidades = await _context.UnidadAdministrativas.Where(q => q.Nombre != "General").ToListAsync();
            ViewData["unidades"] = unidades;
            //var quejas = from Queja in _context.Quejas where Queja.Correo ==username select Queja;

            if (!String.IsNullOrEmpty(buscar))
            {
                quejasMostrar = quejasMostrar.Where(s => s.NombreQuejante!.Contains(buscar));
                ViewBag.nombreBuscar = buscar;
            }
            else
            {
                ViewBag.nombreBuscar = "";
            }

            ViewData["FiltroEstatus"] = String.IsNullOrEmpty(filtro) ? "EstatusDescendiente" : "";
            ViewData["FiltroUnidad"] = filtro == "UnidadAscendente" ? "UnidadDescendiente" : "UnidadAscendente";
            ViewData["FiltroFecha"] = filtro == "FechaAscendente" ? "FechaDescendiente" : "FechaAscendente";


            switch (filtro)
            {
                case "EstatusDescendiente":
                    quejasMostrar = quejasMostrar.OrderByDescending(queja => queja.Estatus);
                    break;

                case "UnidadDescendiente":
                    quejasMostrar = quejasMostrar.OrderByDescending(queja => queja.UnidadAdministrativa);
                    break;

                case "FechaDescendiente":
                    quejasMostrar = quejasMostrar.OrderByDescending(queja => queja.FechaCreacion);
                    break;

                case "UnidadAscendente":
                    quejasMostrar = quejasMostrar.OrderBy(queja => queja.UnidadAdministrativa);
                    break;

                case "FechaAscendente":
                    quejasMostrar = quejasMostrar.OrderBy(queja => queja.FechaCreacion);
                    break;

                default:
                    quejasMostrar = quejasMostrar.OrderBy(queja => queja.Estatus);
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

            var lDepartamentos = _context.Departamentos.Where(a => a.DepartamentoID != Guid.Parse("8A8E1E09-F9CE-41CB-B0B2-4EF91F7B4D61") && a.Nombre != "General").ToList();
            var listaDepartamentos = new SelectList(lDepartamentos.OrderBy(o => o.Nombre), "DepartamentoID", "Nombre");
            ViewBag.departamentos = listaDepartamentos;

            var lUnidadAdministrativa = _context.UnidadAdministrativas.Where(q => q.Nombre != "General").ToList();
            var listaUnidadAdministrativas = new SelectList(lUnidadAdministrativa.OrderBy(o => o.Nombre), "UnidadAdministrativaID", "Nombre");
            ViewBag.unidadAdministrativas = listaUnidadAdministrativas;

            return View();
        }

        // POST: Queja/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,Departamental")]
        public async Task<IActionResult> Create([Bind("QuejaID,NombreQuejante,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,FechaCreacion,Estatus,FechaAtencion,AtendidoPor,Resolucion,DepartamentoID,MunicipioID,UnidadAdministrativaID")] Queja queja)
        {
            queja.AtendidoPor = "";
            queja.Resolucion = "";
            queja.FechaAtencion = queja.FechaCreacion;

            if (ModelState.IsValid)
            {
                queja.QuejaID = Guid.NewGuid();
                _context.Add(queja);
                await _context.SaveChangesAsync();
                ViewBag.SuccessMessage = " La queja ha sido levantada correctamente";
                return View();
            }
            if (User.IsInRole("Administrador") || User.IsInRole("Root"))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Create));
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
        [Authorize(Roles = "Administrador,Root,Administrativo")]
        public async Task<IActionResult> Seguimiento(Guid? id)
        {
            var unidades = await _context.UnidadAdministrativas.ToListAsync();
            ViewData["unidades"] = unidades;
            var municipios = await _context.Municipios.ToListAsync();
            ViewData["municipios"] = municipios;
            var departamentos = await _context.Departamentos.ToListAsync();
            ViewData["departamentos"] = departamentos;

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
        [Authorize(Roles = "Administrador,Root,Administrativo")]
        public async Task<IActionResult> Seguimiento(Guid id, [Bind("QuejaID,NombreQuejante,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,DepartamentoID,MunicipioID,UnidadAdministrativaID,FechaCreacion,Estatus,FechaAtencion,AtendidoPor,Resolucion")] Queja queja)
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
                    if (!QuejaExists(queja.QuejaID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
            }
            return View();
            //return View(queja);
        }


        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> Tablero(string buscar, String filtro)
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
        [Authorize(Roles = "Administrador,Root")]
        public List<Object> GetQuejasPorUnidades()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var unidades = _context.UnidadAdministrativas.ToList();

            List<Object> data = new List<Object>();
            List<string> unidadesNombre = new List<string>();
            List<int> unidadesTotal = new List<int>();

            foreach (var unidad in unidades)
            {
                int total = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID);

                if (total > 0)
                {
                    unidadesNombre.Add(unidad.Nombre);
                    unidadesTotal.Add(total);
                }
            }

            data.Add(unidadesNombre);
            data.Add(unidadesTotal);

            return data;

        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Root")]
        public List<Object> GetQuejasPorMunicipio()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            var municipios = _context.Municipios.OrderBy(m=> m.Nombre).ToList();

            List<Object> data = new List<Object>();
            List<string> municipiosNombre = new List<string>();
            List<int> municipiosTotal = new List<int>();

            foreach (var municipio in municipios)
            {
                int total = quejas.Count(q => q.MunicipioID == municipio.MunicipioID);
                Console.WriteLine("total"+municipio.Nombre+ " : " +total);

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
        [Authorize(Roles = "Administrador,Root")]
        public List<Object> GetQuejasEstatusTotal()
        {
            var quejas = from Queja in _context.Quejas select Queja;
            //var unidades = _context.UnidadAdministrativas.ToList();

            List<Object> data = new List<Object>();
            List<string> estatus = new List<string> { "Atendido", "Pendiente" };
            List<int> estatusTotal = new List<int>();


            int totalAtendidas = quejas.Count(q => q.Estatus == "Atendido");
            int totalPendientes = quejas.Count(q => q.Estatus == "Pendiente");


            estatusTotal.Add(totalAtendidas);
            estatusTotal.Add(totalPendientes);

            data.Add(estatus);
            data.Add(estatusTotal);

            return data;

        }

        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,Administrativo")]
        public async Task<ActionResult<IEnumerable<UnidadAdministrativa>>> GetUnidades()
        {
            var unidades = await _context.UnidadAdministrativas.Where(q => q.Nombre != "General").OrderBy(x => x.Nombre).ToListAsync();
            return unidades;
        }
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,Administrativo")]
        public async Task<UnidadAdministrativa> GetUnidad(string quejaId)
        {
            //var queja = await _context.Quejas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID == Guid.Parse(quejaId));
            var queja = await _context.Quejas.FindAsync(Guid.Parse(quejaId));
            var unidad = await _context.UnidadAdministrativas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID.Equals(queja.UnidadAdministrativaID));
            return unidad;
        }

        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,Administrativo")]
        public async Task<UnidadAdministrativa> GetUnidadName(string idUnidad)
        {
            var unidad = await _context.UnidadAdministrativas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID.Equals(Guid.Parse(idUnidad)));
            return unidad;
        }

        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,Administrativo")]
        public async Task<Municipio> GetMunicipioName(string idMunicipio)
        {
            var municipio = await _context.Municipios.FirstOrDefaultAsync(m => m.MunicipioID.Equals(Guid.Parse(idMunicipio)));
            return municipio;
        }

        [ActionName("Reasignar")]
        [HttpPost]
        [Authorize(Roles = "Administrador,Root,Administrativo")]
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
