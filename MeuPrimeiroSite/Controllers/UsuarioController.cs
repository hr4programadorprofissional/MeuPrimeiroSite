using MeuPrimeiroSite.ViewModels;
using System.Web.Mvc;

namespace MeuPrimeiroSite.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObterMaioridade(UsuarioViewModel usuarioViewModel)
        {
            if (usuarioViewModel.Idade < 18)
            {
                ViewBag.Mensagem = "Usuario: " + usuarioViewModel.Nome + " É menor de idade";
            }
            else
            {
                ViewBag.Mensagem = "Usuario: " + usuarioViewModel.Nome + " É maior de idade";
            }

            return View("Index");
        }
    }
}