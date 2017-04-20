using System.Web.Mvc;

namespace MeuPrimeiroSite.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObterMaioridade(string nome, string idade)
        {
            if (int.Parse(idade) < 18)
            {
                ViewBag.Mensagem = "Usuario: " + nome + " É menor de idade";
            }
            else
            {
                ViewBag.Mensagem = "Usuario: " + nome + " É maior de idade";
            }

            return View("Index");
        }
    }
}