using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Livro l)
        {

                LivroService livroService = new LivroService();

                if (l.Id == 0)
                {
                    livroService.Inserir(l);
                }
                else
                {
                    livroService.Atualizar(l);
                }

                return RedirectToAction("Listagem");
            
        } 
        
        public IActionResult Listagem(string tipoFiltro, string filtro, string  itensPorPaginas, int numDapagina, int PaginaAtual)
        {
            Autenticacao.CheckLogin(this);
            FiltrosLivros objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosLivros();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }

            ViewData["LivrosPorPaginas"] = (string.IsNullOrEmpty(itensPorPaginas) ? 10 : int.Parse(itensPorPaginas));
            ViewData["PaginaAtual"] = (PaginaAtual != 0 ? PaginaAtual : 1);



            LivroService livroService = new LivroService();
            return View(livroService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            LivroService ls = new LivroService();
            Livro l = ls.ObterPorId(id);
            return View(l);
        }
    }
}