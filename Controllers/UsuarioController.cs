
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
namespace Biblioteca.Controllers
{
    public class UsuarioController: Controller
    {
        public IActionResult ListaDeUsuario(){
            Autenticacao.CheckLogin(this);
            List<Usuario> usuarioN = new UsuarioService().ListarTodos();
            return View(usuarioN);
        }

        public IActionResult EditarUsuario(int id){

            Usuario user = new UsuarioService().Listar(id);
            return View(user);

        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario user){
            UsuarioService us = new UsuarioService();
            us.Editar(user);
            return RedirectToAction("ListaDeUsuario");

        }

        public IActionResult RegistrarUsuarioS(int id){


            
            return View();

        }


        [HttpPost]
        public IActionResult RegistrarUsuarioS(Usuario novoUsuario){

            UsuarioService us = new UsuarioService();
            us.Registrar(novoUsuario);

            return RedirectToAction("ListaDeUsuario");

        }



        public IActionResult Excluir(int id){
            UsuarioService us = new UsuarioService();
            us.Excluir(id);
            return RedirectToAction("ListaDeUsuario");

        }

        public IActionResult Sair(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }



        public IActionResult NeddAdm(){
            //atenticacao
            return View();
        }










    }

}