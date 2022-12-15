using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuzonQuejas3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using BuzonQuejas3.Helper;

namespace BuzonQuejas3.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Dev_BuzonQuejasContext _context;

        public UsuarioController(Dev_BuzonQuejasContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> Usuarios(string buscar, string filtro)
        {
            //var usuarios = from Usuario in _context.Usuarios select Usuario;

            var usuarios = from usuario in _context.Usuarios
                           join rol in _context.Roles on usuario.RolID equals rol.RolID
                           join departamento in _context.UnidadRemitentes on usuario.UnidadRemitenteID equals departamento.UnidadRemitenteID
                           join unidad in _context.UnidadAdministrativas on usuario.UnidadAdministrativaID equals unidad.UnidadAdministrativaID
                           select new UsuarioMostrar
                           {
                               UsuarioID = usuario.UsuarioID,
                               Nombre = usuario.Nombre,
                               Correo = usuario.Correo,
                               Activo = usuario.Activo,
                               UnidadRemitente = departamento.Nombre,
                               Rol = rol.Nombre,
                               UnidadAdministrativa = unidad.Nombre
                           };
            if (!String.IsNullOrEmpty(buscar))
            {
                usuarios = usuarios.Where(s => s.Nombre!.Contains(buscar) || s.Correo!.Contains(buscar));
                ViewData["filtroBuscar"] = buscar;
            }
            else
            {
                ViewData["filtroBuscar"] = "";
            }

            ViewData["FiltroNombre"] = String.IsNullOrEmpty(filtro) ? "NombreDescendiente" : "";

            switch (filtro)
            {


                case "NombreDescendiente":
                    usuarios = usuarios.OrderByDescending(usuario => usuario.Nombre);
                    break;

                default:
                    usuarios = usuarios.OrderBy(usuario => usuario.Nombre);
                    break;

            }

            return View(await usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.UnidadRemitente)
                .Include(u => u.Rol)
                .Include(u => u.UnidadAdministrativa)
                .FirstOrDefaultAsync(m => m.UsuarioID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        [Authorize(Roles = "Administrador,Root")]
        public IActionResult AgregarUsuario()
        {
            ViewData["UnidadRemitenteID"] = new SelectList(_context.UnidadRemitentes.OrderBy(d => d.Nombre), "UnidadRemitenteID", "Nombre");
            ViewData["RolID"] = new SelectList(_context.Roles.OrderBy(r => r.Nombre), "RolID", "Nombre");
            ViewData["UnidadAdministrativaID"] = new SelectList(_context.UnidadAdministrativas.OrderBy(u => u.Nombre), "UnidadAdministrativaID", "Nombre");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> AgregarUsuario([Bind("UsuarioID,Nombre,Correo,Clave,Activo,UnidadRemitenteID,RolID,UnidadAdministrativaID")] Usuario usuario)
        {
            var result = await _context.Usuarios.Where(u => u.Correo == usuario.Correo).FirstOrDefaultAsync();

            if (result != null)
            {
                ViewBag.SuccessMessage = "El correo ingresado ya ha sido registrado, intente con otro";
                ViewData["UnidadRemitenteID"] = new SelectList(_context.UnidadRemitentes.OrderBy(d => d.Nombre), "UnidadRemitenteID", "Nombre");
                ViewData["RolID"] = new SelectList(_context.Roles.OrderBy(r => r.Nombre), "RolID", "Nombre");
                ViewData["UnidadAdministrativaID"] = new SelectList(_context.UnidadAdministrativas.OrderBy(u => u.Nombre), "UnidadAdministrativaID", "Nombre");
                return View(usuario);
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var hash = HashHelper.Hash(usuario.Clave);
                    usuario.Clave = hash.Password;
                    usuario.UsuarioID = Guid.NewGuid();
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    ViewBag.SuccessMessage = "Usuario agregado correctamente";
                    return View();
                }
                else
                {
                    ViewBag.SuccessMessage = "Hubo un error al levantar la queja,intente de nuevo";
                    ViewData["UnidadRemitenteID"] = new SelectList(_context.UnidadRemitentes.OrderBy(d => d.Nombre), "UnidadRemitenteID", "Nombre");
                    ViewData["RolID"] = new SelectList(_context.Roles.OrderBy(r => r.Nombre), "RolID", "Nombre");
                    ViewData["UnidadAdministrativaID"] = new SelectList(_context.UnidadAdministrativas.OrderBy(u => u.Nombre), "UnidadAdministrativaID", "Nombre");
                    return View(usuario);
                }
            }


            //if (ModelState.IsValid)
            //{
            //    usuario.UsuarioID = Guid.NewGuid();
            //    _context.Add(usuario);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Usuarios));
            //}
            //ViewData["UnidadRemitenteID"] = new SelectList(_context.UnidadRemitentes, "UnidadRemitenteID", "Nombre", usuario.UnidadRemitenteID);
            //ViewData["RolID"] = new SelectList(_context.Roles, "RolID", "Nombre", usuario.RolID);
            //ViewData["UnidadAdministrativaID"] = new SelectList(_context.UnidadAdministrativas, "UnidadAdministrativaID", "Nombre", usuario.UnidadAdministrativaID);
            //return View(usuario);
        }

        // GET: Usuarios/Edit/5
        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> EditarUsuario(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["UnidadRemitenteID"] = new SelectList(_context.UnidadRemitentes.OrderBy(d => d.Nombre), "UnidadRemitenteID", "Nombre", usuario.UnidadRemitenteID);
            ViewData["RolID"] = new SelectList(_context.Roles.OrderBy(r => r.Nombre), "RolID", "Nombre", usuario.RolID);
            ViewData["UnidadAdministrativaID"] = new SelectList(_context.UnidadAdministrativas.OrderBy(u => u.Nombre), "UnidadAdministrativaID", "Nombre", usuario.UnidadAdministrativaID);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> EditarUsuario(Guid id,string claveUsuario, [Bind("UsuarioID,Nombre,Correo,Clave,Activo,UnidadRemitenteID,RolID,UnidadAdministrativaID")] Usuario usuario)
        {
            if (id != usuario.UsuarioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if(claveUsuario != usuario.Clave)
                {
                    var hash = HashHelper.Hash(usuario.Clave);
                    usuario.Clave = hash.Password;
                }

                try
                {
                    
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                    ViewBag.SuccessMessage = "Usuario actualizado correctamente";
                    return View(usuario);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuarioID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                //return RedirectToAction(nameof(Usuarios));
                }
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> EliminarUsuario(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.UnidadRemitente)
                .Include(u => u.Rol)
                .Include(u => u.UnidadAdministrativa)
                .FirstOrDefaultAsync(m => m.UsuarioID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("EliminarUsuario")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root")]
        public async Task<IActionResult> EliminarUsuarioConfirmado(Guid id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Usuarios));
        }

        private bool UsuarioExists(Guid id)
        {
            return _context.Usuarios.Any(e => e.UsuarioID == id);
        }

        // GET: Usuarios/Edit/5
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,UnidadAdministrativa,Fiscal")]
        public async Task<IActionResult> ReestablecerClave(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Root,UnidadRemitente,UnidadAdministrativa,Fiscal")]
        public async Task<IActionResult> ReestablecerClave(string userID, string clave, string confirmarClave)
        {
            var usuario = await _context.Usuarios.FindAsync(Guid.Parse(userID));
            if (usuario == null)
            {
                return NotFound();
            }

            if (clave.Equals(confirmarClave))
            {

                try
                {
                    var hash = HashHelper.Hash(clave);
                    usuario.Clave = hash.Password;
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                    ViewBag.SuccessMessage = "Contraseña reestablecida correctamente";
                    return View();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuarioID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Usuarios));


            }
            else
            {
                ViewBag.SuccessMessage = "Las contraseñas no coinciden, intentelo de nuevo";
                return View(usuario);
            }
        }
    }
}
