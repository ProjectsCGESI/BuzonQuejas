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
using BuzonQuejas3.Helper;

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
            if (_usuario.Correo != null && _usuario.Clave != null)
            {
                var hash = HashHelper.Hash(_usuario.Clave);

                var usuario = await _context.Usuarios.FirstOrDefaultAsync(m => m.Correo == _usuario.Correo && m.Clave == hash.Password);

                if (usuario != null)
                {
                    if (true.Equals(usuario.Activo))
                    {
                        var rol = await _context.Roles.FirstOrDefaultAsync(m => m.RolID == usuario.RolID);

                        //2.- CONFIGURACION DE LA AUTENTICACION
                        #region AUTENTICACTION
                        var claims = new List<Claim>{
                            new Claim(ClaimTypes.Name, usuario.Nombre),
                            new Claim("Correo", usuario.Correo),
                            new Claim("UnidadRemitenteID", usuario.UnidadRemitenteID.ToString()),
                            new Claim("UnidadAdministrativaID", usuario.UnidadAdministrativaID.ToString()),
                            new Claim(ClaimTypes.Role, rol.Nombre),
                        };
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                        #endregion

                        if (usuario.Clave == "gdnrIvSE0unNNIore1PcbsfdwEP9S7cftX+9UCBTo5s=")
                        {
                            return RedirectToAction("ReestablecerClave", "Usuario", new { id = usuario.UsuarioID });
                        }
                        else
                        {
                            return RedirectToAction("Quejas", "Queja");
                        }
                    }
                    else
                    {
                        ViewBag.SuccessMessage = "Este usuario no está activo";
                        return View();
                    }
                }
                else
                {

                    ViewBag.SuccessMessage = "El usuario y/o la contraseña son incorrectos";
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
