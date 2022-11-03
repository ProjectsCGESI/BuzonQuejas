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
        [Authorize(Roles = "Administrador,Root,Departamental")]
        public async Task<IActionResult> Index(string buscar, String filtro)
        {
            var departamentoUsuario = HttpContext.User.FindFirst("DepartamentoID").Value;
            IQueryable<Queja> quejas;

            if (User.IsInRole("Administrador") || User.IsInRole("Root"))
            {
                quejas = from Queja in _context.Quejas select Queja;
            }
            else
            {
                quejas = from Queja in _context.Quejas where Queja.DepartamentoID == Guid.Parse(departamentoUsuario) select Queja;
            }




            var unidades = await _context.UnidadAdministrativas.ToListAsync();
            ViewData["unidades"] = unidades;
            //var quejas = from Queja in _context.Quejas where Queja.Correo ==username select Queja;

            if (!String.IsNullOrEmpty(buscar))
            {
                quejas = quejas.Where(s => s.NombreQuejante!.Contains(buscar));
                ViewBag.nombreBuscar = buscar;
            }
            else
            {
                ViewBag.nombreBuscar = "";
            }

            ViewData["FiltroEstatus"] = String.IsNullOrEmpty(filtro) ? "EstatusDescendiente" : "";


            switch (filtro)
            {
                case "EstatusDescendiente":
                    quejas = quejas.OrderByDescending(queja => queja.Estatus);
                    break;

                default:
                    quejas = quejas.OrderBy(queja => queja.Estatus);
                    break;

            }

            return View(await quejas.ToListAsync());
        }

        // GET: Queja/Details/5
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

        [Authorize(Roles = "Administrador,Root")]
        // GET: Queja/Create
        public IActionResult Create(String esMidepartamento)
        {
            if (!String.IsNullOrEmpty(esMidepartamento))
            {
                ViewData["EsMiDepartamento"] = esMidepartamento;
            }


            var lMunicipios = _context.Municipios.ToList();
            var listaMunicipios = new SelectList(lMunicipios.OrderBy(o => o.Nombre), "MunicipioID", "Nombre");
            ViewBag.municipios = listaMunicipios;

            var lDepartamentos = _context.Departamentos.Where(a => a.DepartamentoID != Guid.Parse("8A8E1E09-F9CE-41CB-B0B2-4EF91F7B4D61")).ToList();
            var listaDepartamentos = new SelectList(lDepartamentos.OrderBy(o => o.Nombre), "DepartamentoID", "Nombre");
            ViewBag.departamentos = listaDepartamentos;

            var lUnidadAdministrativa = _context.UnidadAdministrativas.ToList();
            var listaUnidadAdministrativas = new SelectList(lUnidadAdministrativa.OrderBy(o => o.Nombre), "UnidadAdministrativaID", "Nombre");
            ViewBag.unidadAdministrativas = listaUnidadAdministrativas;

            //ViewData["EsMiDepartamento"] = "true";

            //var lCentroTrabajo = _context.CentroTrabajos.ToList();
            //var listaCentroTrabajo = new SelectList(lCentroTrabajo.OrderBy(o => o.Nombre), "CentroTrabajoID", "Nombre");
            //ViewBag.centrosTrabajo = listaCentroTrabajo;

            return View();
        }

        // POST: Queja/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root")]
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
                return RedirectToAction(nameof(Index));
            }
            return View(queja);
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
        [Authorize(Roles = "Administrador,Root,Departamental")]
        public async Task<IActionResult> Seguimiento(Guid? id)
        {
            var unidades = await _context.UnidadAdministrativas.ToListAsync();
            ViewData["unidades"] = unidades;
            var municipios = await _context.Municipios.ToListAsync();
            ViewData["municipios"] = municipios;
            var departamentos = await _context.Departamentos.ToListAsync();
            ViewData["departamentos"] = departamentos;
            //var centrosTrabajo = await _context.CentroTrabajos.ToListAsync();
            //ViewData["centrosTrabajo"] = centrosTrabajo;

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
        [Authorize(Roles = "Administrador,Root,Departamental")]
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


        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> Tablero(string buscar, String filtro)
        {
            //Traer todas las quejas tipo IQuerable<Queja>
            var quejas = from Queja in _context.Quejas select Queja;

            //Traer la lista de unidades adim. 
            var unidades = await _context.UnidadAdministrativas.ToListAsync();
            //ViewData["unidades"] = unidades;

            //Traer la lista de municipios. 
            var municipios = await _context.Municipios.ToListAsync();
            //ViewData["unidades"] = unidades;

            //creación de un diccionario para llenar con cada unidad y su total de quejas
            Dictionary<string, string> totalPorUnidad = new Dictionary<string, string>();
            foreach (var unidad in unidades)
            {
                int total = quejas.Count(q => q.UnidadAdministrativaID == unidad.UnidadAdministrativaID);
                totalPorUnidad.Add(unidad.Nombre, total.ToString());
            }
            ViewData["TotalPorUnidad"] = totalPorUnidad;


            //creación de un diccionario para llenar sólo los municipios que tengan quejas
            Dictionary<string, string> totalPorMunicipio = new Dictionary<string, string>();
            foreach (var municipio in municipios)
            {
                int total = quejas.Count(q => q.MunicipioID == municipio.MunicipioID);
                if (total > 0)
                {
                    totalPorMunicipio.Add(municipio.Nombre, total.ToString());
                }
            }
            ViewData["TotalPorMunicipio"] = totalPorMunicipio;

            //contar el total de quejas atendidas y pedientes
            var totalAtendidas = quejas.Count(q => q.Estatus == "Atendido");
            var totalPendientes = quejas.Count(q => q.Estatus == "Pendiente");

            ViewBag.TotalAtendidas = totalAtendidas;
            ViewBag.TotalPendientes = totalPendientes;




            return View();





            //var quejas = from Queja in _context.Quejas where Queja.Correo ==username select Queja;

            //if (!String.IsNullOrEmpty(buscar))
            //{
            //    quejas = quejas.Where(s => s.NombreQuejante!.Contains(buscar));
            //}

            //ViewData["FiltroEstatus"] = String.IsNullOrEmpty(filtro) ? "EstatusDescendiente" : "";

            //contar quejas por unidad administrativa


            //contar total de quejas atendidas y pendientes

            //int totalAtentida = quejas.Count(q => q.Estatus == "Atendido");
            //ViewData["TotalPorUnidad"] = totalAtentida.ToString();


        }

        //public async Task<String> getNombreUnidadAdministrativa(Guid unidadAdministrativaID)
        //{
        //    //var unidad = from UnidadAdministrativa in _context.UnidadAdministrativas where UnidadAdministrativa.UnidadAdministrativaID == unidadAdministrativaID select UnidadAdministrativa;
        //    var unidad = await _context.UnidadAdministrativas.Where(x => x.UnidadAdministrativaID.Equals(unidadAdministrativaID)).FirstAsync();

        //    return unidad.Nombre;
        //}
    }
}
