using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BuzonQuejas3.Models;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace BuzonQuejas3.Controllers
{
    public class AccesoController : Controller
    {
        private readonly Dev_BuzonQuejasContext _context;

        public AccesoController(Dev_BuzonQuejasContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Usuario _usuario)
        {
            //DA_Logica _da_usuario = new DA_Logica();

            //var usuario = _da_usuario.ValidarUsuario(_usuario.Correo, _usuario.Clave);
            //ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
            if (_usuario.Correo != null && _usuario.Clave != null)
            {

                var usuario = await _context.Usuarios.FirstOrDefaultAsync(m => m.Correo == _usuario.Correo && m.Clave == _usuario.Clave);

                if (usuario != null)
                {
                var rol = await _context.Roles.FirstOrDefaultAsync(m => m.RolID == usuario.RolID);
                var departamento = await _context.Departamentos.FirstOrDefaultAsync(m => m.DepartamentoID == usuario.DepartamentoID);

                    //2.- CONFIGURACION DE LA AUTENTICACION
                    #region AUTENTICACTION
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nombre),
                    new Claim("Correo", usuario.Correo),
                    //new Claim("Departamento", departamento.Nombre),
                    new Claim("DepartamentoID", departamento.DepartamentoID.ToString()),
                    new Claim(ClaimTypes.Role, rol.Nombre),
                };
                    //foreach (string rol in usuario.R)
                    //{
                    //claims.Add(new Claim(ClaimTypes.Role, rol.Nombre));
                    //}
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    #endregion


                    return RedirectToAction("Index", "Queja");
                }
                else
                {

            ViewData["error"] = true;
            return View();
                }
            }
            else
            {
            return View();
            }


        }

        public async Task<IActionResult> Salir()
        {
            //3.- CONFIGURACION DE LA AUTENTICACION
            #region AUTENTICACTION
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            #endregion

            return RedirectToAction("Index");

        }
    }
}
