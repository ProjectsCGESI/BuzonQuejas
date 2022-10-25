using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuzonQuejas3.Models;
using Microsoft.AspNetCore.Http;

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
        [Authorize(Roles = "Administrador,Basico")]
        public async Task<IActionResult> Index(string buscar,String filtro)
        {
            var username = HttpContext.User.FindFirst("Correo").Value;
            var quejas = from Queja in _context.Quejas select Queja;
            //var quejas = from Queja in _context.Quejas where Queja.Correo ==username select Queja;

            if(!String.IsNullOrEmpty(buscar))
            {
                quejas = quejas.Where(s => s.NombreCreador!.Contains(buscar));
            }

            ViewData["FiltroEstatus"] = String.IsNullOrEmpty(filtro) ? "EstatusDescendiente" : "";
            

            switch(filtro)
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
                .FirstOrDefaultAsync(m => m.IdQueja == id);
            if (queja == null)
            {
                return NotFound();
            }

            return View(queja);
        }

        [Authorize(Roles = "Administrador,Basico")]
        // GET: Queja/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Queja/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Basico")]
        public async Task<IActionResult> Create([Bind("IdQueja,NombreCreador,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,DepartamentoAsignado,FechaCreacion,FechaActualizacion,Estatus,FechaAtencion,AtendidoPor,Resolucion")] Queja queja)
        {
            queja.FechaActualizacion = queja.FechaCreacion;
            queja.AtendidoPor = "";
            queja.Resolucion = "";
            //queja.Estatus = "Pendiente";
            queja.FechaAtencion = queja.FechaCreacion;
            //queja.AtendidoPor = "";
            //queja.Resolucion = "";
            Console.WriteLine("aquiii");

            if (ModelState.IsValid)
            {
                queja.IdQueja = Guid.NewGuid();
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
        public async Task<IActionResult> Edit(Guid id, [Bind("IdQueja,NombreCreador,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,DepartamentoAsignado,FechaCreacion,FechaActualizacion,Estatus,FechaAtencion,AtendidoPor,Resolucion")] Queja queja)
        {
            if (id != queja.IdQueja)
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
                    if (!QuejaExists(queja.IdQueja))
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
                .FirstOrDefaultAsync(m => m.IdQueja == id);
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
            return _context.Quejas.Any(e => e.IdQueja == id);
        }

        // GET: Queja/Edit/5
        [Authorize(Roles = "Administrador,Basico")]
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

        // POST: Queja/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Basico")]
        public async Task<IActionResult> Seguimiento(Guid id, [Bind("IdQueja,NombreCreador,Direccion,Telefono,Correo,MotivoQueja,RelatoHechos,ServidorInvolucrado,DepartamentoAsignado,FechaCreacion,Estatus,FechaAtencion,AtendidoPor,Resolucion")] Queja queja)
        {
            queja.FechaActualizacion = queja.FechaAtencion;
            if (id != queja.IdQueja)
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
                    if (!QuejaExists(queja.IdQueja))
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

        public IActionResult Tablero()
        {
            //int
            //var quejas = from Queja in _context.Quejas select Queja;
            ////var quejas = from Queja in _context.Quejas where Queja.Correo ==username select Queja;


            //return View(await quejas.ToListAsync());
            return View();
        }
    }
}
