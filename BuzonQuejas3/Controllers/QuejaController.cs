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
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,UnidadRemitente,Fiscal")]
        public async Task<IActionResult> Quejas(string buscar, String filtro)
        {
            IQueryable<QuejaMostrar> quejasMostrar;

            if (User.IsInRole("Administrador") || User.IsInRole("Root") || User.IsInRole("Fiscal"))
            {
                //quejas = from Queja in _context.Quejas select Queja;
                quejasMostrar = from queja in _context.Quejas
                                join medio in _context.Medios on queja.MedioID equals medio.MedioID
                                join motivo in _context.Motivos on queja.MotivoID equals motivo.MotivoID
                                select new QuejaMostrar
                                {
                                    QuejaID = queja.QuejaID,
                                    Folio = queja.Folio,
                                    NombreQuejante = queja.NombreQuejante,
                                    ApellidoPQuejante = queja.ApellidoPQuejante,
                                    ApellidoMQuejante = queja.ApellidoMQuejante,
                                    MotivoQueja = motivo.Descripcion,
                                    NombreServidor = queja.NombreServidor,
                                    ApellidoPServidor = queja.ApellidoPServidor,
                                    ApellidoMServidor = queja.ApellidoMServidor,
                                    FechaCreacion = queja.FechaCreacion,
                                    Estatus = queja.Estatus,
                                    UnidadRemitenteID = queja.UnidadRemitenteID,
                                    MedioID = medio.MedioID,
                                    Medio = medio.Nombre,
                                };
            }
            else if (User.IsInRole("UnidadRemitente"))
            {
                //var unidadRemitenteUsuario = HttpContext.User.FindFirst("UnidadRemitenteID").Value;
                var unidadRemitenteUsuario = User.Claims.ElementAt(2).Value;
                quejasMostrar = from queja in _context.Quejas
                                join medio in _context.Medios on queja.MedioID equals medio.MedioID
                                join motivo in _context.Motivos on queja.MotivoID equals motivo.MotivoID
                                where queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario)
                                select new QuejaMostrar
                                {
                                    QuejaID = queja.QuejaID,
                                    Folio = queja.Folio,
                                    NombreQuejante = queja.NombreQuejante,
                                    ApellidoPQuejante = queja.ApellidoPQuejante,
                                    ApellidoMQuejante = queja.ApellidoMQuejante,
                                    MotivoQueja = motivo.Descripcion,
                                    NombreServidor = queja.NombreServidor,
                                    ApellidoPServidor = queja.ApellidoPServidor,
                                    ApellidoMServidor = queja.ApellidoMServidor,
                                    FechaCreacion = queja.FechaCreacion,
                                    Estatus = queja.Estatus,
                                    UnidadRemitenteID = queja.UnidadRemitenteID,
                                    MedioID = medio.MedioID,
                                    Medio = medio.Nombre,
                                };
            }
            else if (User.IsInRole("UnidadAdministrativa"))
            {
                var unidadUsuario = User.Claims.ElementAt(3).Value;
                quejasMostrar = from queja in _context.Quejas
                                join medio in _context.Medios on queja.MedioID equals medio.MedioID
                                join motivo in _context.Motivos on queja.MotivoID equals motivo.MotivoID
                                where queja.UnidadAdministrativaID == Guid.Parse(unidadUsuario)
                                select new QuejaMostrar
                                {
                                    QuejaID = queja.QuejaID,
                                    Folio = queja.Folio,
                                    NombreQuejante = queja.NombreQuejante,
                                    ApellidoPQuejante = queja.ApellidoPQuejante,
                                    ApellidoMQuejante = queja.ApellidoMQuejante,
                                    MotivoQueja = motivo.Descripcion,
                                    NombreServidor = queja.NombreServidor,
                                    ApellidoPServidor = queja.ApellidoPServidor,
                                    ApellidoMServidor = queja.ApellidoMServidor,
                                    FechaCreacion = queja.FechaCreacion,
                                    Estatus = queja.Estatus,
                                    UnidadRemitenteID = queja.UnidadRemitenteID,
                                    MedioID = medio.MedioID,
                                    Medio = medio.Nombre,
                                };
            }
            else
            {
                return RedirectToAction("Index", "Acceso");
            }

            if (!String.IsNullOrEmpty(buscar))
            {
                quejasMostrar = quejasMostrar.Where(s => s.NombreQuejante!.Contains(buscar) || s.ApellidoPQuejante!.Contains(buscar) || s.ApellidoMQuejante!.Contains(buscar) || s.NombreServidor!.Contains(buscar) || s.ApellidoPServidor!.Contains(buscar) || s.ApellidoMServidor!.Contains(buscar) || s.Folio!.Contains(buscar));
                ViewData["filtroBuscar"] = buscar;
            }
            else
            {
                ViewData["filtroBuscar"] = "";
            }

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
        [Authorize(Roles = "Administrador,Root,Fiscal")]
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

        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        // GET: Queja/Create
        public IActionResult AgregarQueja()
        {
            var lMunicipios = _context.Municipios.ToList();
            var listaMunicipios = new SelectList(lMunicipios.OrderBy(o => o.Nombre), "MunicipioID", "Nombre");
            ViewBag.municipios = listaMunicipios;

            var lCargos = _context.Cargos.ToList();
            var listaCargos = new SelectList(lCargos.OrderBy(o => o.Nombre), "CargoID", "Nombre");
            ViewBag.cargos = listaCargos;

            var lMedios = _context.Medios.ToList();
            var listaMedios = new SelectList(lMedios.OrderBy(o => o.Nombre).Where(m=>m.Nombre != "Buzón web"), "MedioID", "Nombre");
            ViewBag.medios = listaMedios;

            var lMotivos = _context.Motivos.ToList();
            var listaMotivos = new SelectList(lMotivos.OrderBy(o => o.Descripcion), "MotivoID", "Descripcion", "UnidadAdministrativa");
            ViewBag.motivos = listaMotivos;

            return View();
        }

        // POST: Queja/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public async Task<IActionResult> AgregarQueja([Bind("QuejaID,Folio,NombreQuejante,ApellidoPQuejante,ApellidoMQuejante,Direccion,Telefono,Correo,RelatoHechos,NombreServidor,ApellidoPServidor,ApellidoMServidor,FechaCreacion,Estatus,FechaAtencion,NombreAtendio,ApellidoPAtendio,ApellidoMAtendio,Resolucion,NumeroPrevio,UnidadRemitenteID,MunicipioID,UnidadAdministrativaID,MedioID,CargoID,MotivoID")] Queja queja)
        {
            queja.NombreAtendio = "";
            queja.ApellidoPAtendio = "";
            queja.ApellidoMAtendio = "";
            queja.Resolucion = "";
            queja.FechaAtencion = null;
            var motivo = await _context.Motivos.FirstOrDefaultAsync(m => m.MotivoID.Equals(queja.MotivoID));
            queja.UnidadAdministrativaID = (Guid)motivo.UnidadAdministrativaID;


            string identificador = "BQ";
            string year = DateTime.Now.ToString("yy");
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            var ultimaQueja = _context.Quejas.OrderBy(q => q.Folio).ThenBy(x => x.FechaCreacion).LastOrDefault();

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


            if (ModelState.IsValid)
            {
                queja.QuejaID = Guid.NewGuid();
                _context.Add(queja);
                await _context.SaveChangesAsync();
                ViewBag.SuccessMessage = $"La queja ha sido levantada correctamente <br/> Folio: {queja.Folio} ";
                return View();
            }
            else
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
                return View(queja);
            }

        }

        // GET: Queja/Edit/5 No se ocupa
        [Authorize(Roles = "Administrador,Root,Fiscal")]
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

        // POST: Queja/Edit/5 No se ocupa
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,Fiscal")]
        public async Task<IActionResult> Edit(Guid id, [Bind("QuejaID,NombreQuejante,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,UnidadRemitenteAsignado,FechaCreacion,Estatus,FechaAtencion,AtendidoPor,Resolucion")] Queja queja)
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
                return RedirectToAction(nameof(Quejas));
            }
            return View(queja);
        }

        // GET: Queja/Delete/5 No se ocupa
        [Authorize(Roles = "Administrador,Root,Fiscal")]
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

        // POST: Queja/Delete/5 No se ocupa
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,Fiscal")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var queja = await _context.Quejas.FindAsync(id);
            _context.Quejas.Remove(queja);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Quejas));
        }

        private bool QuejaExists(Guid id)
        {
            return _context.Quejas.Any(e => e.QuejaID == id);
        }

        // GET: Queja/Seguimiento/5
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Fiscal")]
        public async Task<IActionResult> Seguimiento(Guid? id)
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

        // POST: Queja/Seguimiento/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Fiscal")]
        public async Task<IActionResult> Seguimiento(Guid id, [Bind("QuejaID,Folio,NombreQuejante,ApellidoPQuejante,ApellidoMQuejante,Direccion,Telefono,Correo,RelatoHechos,NombreServidor,ApellidoPServidor,ApellidoMServidor,FechaCreacion,Estatus,FechaAtencion,NombreAtendio,ApellidoPAtendio,ApellidoMAtendio,Resolucion,NumeroPrevio,UnidadRemitenteID,MunicipioID,UnidadAdministrativaID,MedioID,CargoID,MotivoID")] Queja queja)
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
        }

        // GET: Queja/Tablero/5
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public IActionResult Tablero()
        {
            return View();
        }

        // GET: 
        [Authorize]
        public IQueryable<Queja> GetQuejas(string[] filter)
        {
            IQueryable<Queja> quejas;

            if (User.IsInRole("UnidadRemitente"))
            {
                var unidadRemitenteUsuario = User.Claims.ElementAt(2).Value;

                if (filter != null && filter.Length != 0)
                {

                    int YearDate = filter[0] == "-" ? 0 : Int32.Parse(filter[0]);
                    int MonthDate = filter[1] == "-" ? 0 : Int32.Parse(filter[1]);
                    int DayDate = filter[2] == "-" ? 0 : Int32.Parse(filter[2]);

                    if (YearDate != 0 && MonthDate != 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) && Queja.FechaCreacion.Year == YearDate && Queja.FechaCreacion.Month == MonthDate && Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate != 0 && MonthDate == 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) && Queja.FechaCreacion.Year == YearDate && Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate != 0 && MonthDate != 0 && DayDate == 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) && Queja.FechaCreacion.Year == YearDate && Queja.FechaCreacion.Month == MonthDate select Queja;
                    }
                    else if (YearDate != 0 && MonthDate == 0 && DayDate == 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) && Queja.FechaCreacion.Year == YearDate select Queja;
                    }
                    else if (YearDate == 0 && MonthDate != 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) && Queja.FechaCreacion.Month == MonthDate && Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate == 0 && MonthDate == 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) && Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate == 0 && MonthDate != 0 && DayDate == 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) && Queja.FechaCreacion.Month == MonthDate select Queja;
                    }
                    else
                    {
                        quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) select Queja;
                    }
                }
                else
                {
                    quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) select Queja;
                }


            }
            else
            {
                if (filter != null && filter.Length != 0)
                {
                    int YearDate = filter[0] == "-" ? 0 : Int32.Parse(filter[0]);
                    int MonthDate = filter[1] == "-" ? 0 : Int32.Parse(filter[1]);
                    int DayDate = filter[2] == "-" ? 0 : Int32.Parse(filter[2]);

                    if (YearDate != 0 && MonthDate != 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.FechaCreacion.Year == YearDate && Queja.FechaCreacion.Month == MonthDate && Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate != 0 && MonthDate == 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.FechaCreacion.Year == YearDate && Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate != 0 && MonthDate != 0 && DayDate == 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.FechaCreacion.Year == YearDate && Queja.FechaCreacion.Month == MonthDate select Queja;
                    }
                    else if (YearDate != 0 && MonthDate == 0 && DayDate == 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.FechaCreacion.Year == YearDate select Queja;
                    }
                    else if (YearDate == 0 && MonthDate != 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.FechaCreacion.Month == MonthDate && Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate == 0 && MonthDate == 0 && DayDate != 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.FechaCreacion.Day == DayDate select Queja;
                    }
                    else if (YearDate == 0 && MonthDate != 0 && DayDate == 0)
                    {
                        quejas = from Queja in _context.Quejas where Queja.FechaCreacion.Month == MonthDate select Queja;
                    }
                    else
                    {
                        quejas = from Queja in _context.Quejas select Queja;
                    }
                }
                else
                {
                    quejas = from Queja in _context.Quejas select Queja;

                }
            }

            return quejas;
        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasPorUnidades(string[] filter)
        {
            IQueryable<Queja> quejas = GetQuejas(filter);

            var unidades = _context.UnidadAdministrativas.OrderBy(u => u.Nombre).ToList();

            List<Object> data = new List<Object>();
            List<string> unidadesNombre = new List<string>();
            List<int> unidadesTotal = new List<int>();

            foreach (var unidad in unidades)
            {
                int total = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID);
                //var randomNumber = new Random().Next(0, 1000);

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

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasPorUnidadRemitente(string[] filter)
        {
            IQueryable<Queja> quejas = GetQuejas(filter);

            var unidadRemitentes = _context.UnidadRemitentes.ToList();

            List<Object> data = new List<Object>();
            List<string> unidadRemitentesNombre = new List<string>();
            List<int> unidadRemitentesTotal = new List<int>();

            foreach (var unidadRemitente in unidadRemitentes)
            {
                int total = quejas.Count(q => q.UnidadRemitenteID == unidadRemitente.UnidadRemitenteID);
                //var randomNumber = new Random().Next(0, 100000);

                if (total > 0)
                {
                    unidadRemitentesNombre.Add(unidadRemitente.Nombre);
                    unidadRemitentesTotal.Add(total);
                }
            }

            data.Add(unidadRemitentesNombre);
            data.Add(unidadRemitentesTotal);

            return data;

        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasEstatusPorUnidades(string[] filter)
        {
            IQueryable<Queja> quejas = GetQuejas(filter);

            var unidades = _context.UnidadAdministrativas.OrderBy(u => u.Nombre).ToList();

            List<Object> data = new List<Object>();
            List<string> unidadesNombre = new List<string>();
            List<int> atendidasTotal = new List<int>();
            List<int> pendientesTotal = new List<int>();

            foreach (var unidad in unidades)
            {
                int totalAtendidos = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID && q.Estatus == "Atendido");
                int totalPendientes = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID && q.Estatus == "Pendiente");
                //var randomNumber = new Random().Next(0, 10000);
                //var randomNumber2 = new Random().Next(0, 10000);

                if (totalAtendidos > 0 || totalPendientes > 0)
                {
                    unidadesNombre.Add(unidad.Nombre);
                    atendidasTotal.Add(totalAtendidos);
                    pendientesTotal.Add(totalPendientes);
                }
            }

            data.Add(unidadesNombre);
            data.Add(atendidasTotal);
            data.Add(pendientesTotal);

            return data;

        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasPorMunicipio(string[] filter)
        {
            IQueryable<Queja> quejas = GetQuejas(filter);

            //var quejas = from Queja in _context.Quejas select Queja;
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

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasEstatusTotal(string[] filter)
        {
            IQueryable<Queja> quejas = GetQuejas(filter);

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

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasEstatusDiario(string[] filter)
        {
            IQueryable<Queja> quejas = GetQuejas(filter);

            //var quejas = from Queja in _context.Quejas select Queja;
            var dateTimeActual = DateTime.Now.Date;

            List<Object> data = new List<Object>();
            List<string> estatus = new List<string> { "Total", "Atendido", "Pendiente" };
            List<int> estatusTotal = new List<int>();


            int totalAtendidas = quejas.Where(q => q.FechaCreacion.Date == dateTimeActual).Count(q => q.Estatus == "Atendido");
            int totalPendientes = quejas.Where(q => q.FechaCreacion.Date == dateTimeActual).Count(q => q.Estatus == "Pendiente");
            int totalQuejas = quejas.Where(q => q.FechaCreacion.Date == dateTimeActual).Count();


            estatusTotal.Add(totalAtendidas);
            estatusTotal.Add(totalPendientes);
            estatusTotal.Add(totalQuejas);

            data.Add(estatus);
            data.Add(estatusTotal);

            return data;

        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasEstatusAnual(string[] filter)
        {
            IQueryable<Queja> quejas;

            if (User.IsInRole("UnidadRemitente"))
            {
                var unidadRemitenteUsuario = User.Claims.ElementAt(2).Value;
                quejas = from Queja in _context.Quejas where Queja.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario) select Queja;
            }
            else
            {
                quejas = from Queja in _context.Quejas select Queja;
            }

            int yearActual;

            if (filter != null && filter.Length != 0)
            {
                yearActual = filter[0] == "-" ? DateTime.Now.Year : Int32.Parse(filter[0]);
            }
            else
            {
                yearActual = DateTime.Now.Year;
            }

            List<Object> data = new List<Object>();
            List<string> estatus = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            List<int> estatusTotalPendientes = new List<int>();
            List<int> estatusTotalAtendidas = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                int totalAtendidas = quejas.Where(q => q.FechaCreacion.Month == i + 1 && q.FechaCreacion.Year == yearActual).Count(q => q.Estatus == "Atendido");
                int totalPendientes = quejas.Where(q => q.FechaCreacion.Month == i + 1 && q.FechaCreacion.Year == yearActual).Count(q => q.Estatus == "Pendiente");
                estatusTotalAtendidas.Add(totalAtendidas);
                estatusTotalPendientes.Add(totalPendientes);
            }

            data.Add(estatus);
            data.Add(estatusTotalAtendidas);
            data.Add(estatusTotalPendientes);

            return data;

        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<Object> GetQuejasMedio(string[] filter)
        {
            IQueryable<Queja> quejas = GetQuejas(filter);

            //var quejas = from Queja in _context.Quejas select Queja;
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

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        public List<string> GetFirstLastYear()
        {
            Queja primeraQueja;
            Queja ultimaQueja;

            if (User.IsInRole("UnidadRemitente"))
            {
                var unidadRemitenteUsuario = User.Claims.ElementAt(2).Value;
                primeraQueja = _context.Quejas.Where(q => q.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario)).OrderBy(q => q.FechaCreacion).FirstOrDefault();
                ultimaQueja = _context.Quejas.Where(q => q.UnidadRemitenteID == Guid.Parse(unidadRemitenteUsuario)).OrderBy(q => q.FechaCreacion).LastOrDefault();
            }
            else
            {
                primeraQueja = _context.Quejas.OrderBy(q => q.FechaCreacion).FirstOrDefault();
                ultimaQueja = _context.Quejas.OrderBy(q => q.FechaCreacion).LastOrDefault();
            }

            List<string> firstLastQueja = new();

            if (primeraQueja != null && ultimaQueja != null)
            {
                firstLastQueja.Add(primeraQueja.FechaCreacion.Year.ToString());
                firstLastQueja.Add(ultimaQueja.FechaCreacion.Year.ToString());
            }
            


            return firstLastQueja;

        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        //get para mostrar unidades administrativas en modal al reasignar
        public async Task<ActionResult<IEnumerable<UnidadAdministrativa>>> GetUnidades()
        {
            var unidades = await _context.UnidadAdministrativas.Where(q => q.Nombre != "Sin Asignar").OrderBy(x => x.Nombre).ToListAsync();
            return unidades;
        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,Fiscal")]
        public async Task<UnidadAdministrativa> GetUnidad(string quejaId)
        {
            var queja = await _context.Quejas.FindAsync(Guid.Parse(quejaId));
            var unidad = await _context.UnidadAdministrativas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID.Equals(queja.UnidadAdministrativaID));
            return unidad;
        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,UnidadRemitente,Fiscal")]
        //get para mostrar el nombre de la unidad en vez del id en seguimiento
        public async Task<UnidadAdministrativa> GetUnidadName(string idUnidad)
        {
            var unidad = await _context.UnidadAdministrativas.FirstOrDefaultAsync(m => m.UnidadAdministrativaID.Equals(Guid.Parse(idUnidad)));
            return unidad;
        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,UnidadRemitente,Fiscal")]
        //get para mostrar el nombre del municipio en vez del id en seguimiento
        public async Task<Municipio> GetMunicipioName(string idMunicipio)
        {
            var municipio = await _context.Municipios.FirstOrDefaultAsync(m => m.MunicipioID.Equals(Guid.Parse(idMunicipio)));
            return municipio;
        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,UnidadRemitente,Fiscal")]
        //get para mostrar el nombre de el medio de reecpción en vez del id en seguimiento
        public async Task<Medio> GetMedioName(string idMedio)
        {
            var medio = await _context.Medios.FirstOrDefaultAsync(m => m.MedioID.Equals(Guid.Parse(idMedio)));
            return medio;
        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,UnidadRemitente,Fiscal")]

        //get para mostrar el nombre del cargo en vez del id en seguimiento
        public async Task<Cargo> GetCargoName(string idCargo)
        {
            var cargo = await _context.Cargos.FirstOrDefaultAsync(m => m.CargoID.Equals(Guid.Parse(idCargo)));
            return cargo;
        }

        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,UnidadRemitente,Fiscal")]

        //get para mostrar el nombre del motivo en vez del id en seguimiento
        public async Task<Motivo> GetMotivoName(string idMotivo)
        {
            var motivo = await _context.Motivos.FirstOrDefaultAsync(m => m.MotivoID.Equals(Guid.Parse(idMotivo)));
            return motivo;
        }
        
        // GET:
        [HttpGet]
        [Produces("application/json")]
        [Authorize(Roles = "Administrador,Root,UnidadAdministrativa,UnidadRemitente,Fiscal")]

        //get para mostrar el nombre de la unidad remitente en vez del id en seguimiento
        public async Task<UnidadRemitente> GetunidadRemitenteName(string idUnidadRemitente)
        {
            var unidad = await _context.UnidadRemitentes.FirstOrDefaultAsync(m => m.UnidadRemitenteID.Equals(Guid.Parse(idUnidadRemitente)));
            return unidad;
        }

        // POST:
        [ActionName("Reasignar")]
        [HttpPost]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,Fiscal")]
        //para poder reasignar quejas
        public async Task<IActionResult> Reasignar(string QuejaId, string unidadId)
        {
            var queja = await _context.Quejas.FindAsync(Guid.Parse(QuejaId));

            queja.UnidadAdministrativaID = Guid.Parse(unidadId);

            try
            {
                _context.Update(queja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Quejas));

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
