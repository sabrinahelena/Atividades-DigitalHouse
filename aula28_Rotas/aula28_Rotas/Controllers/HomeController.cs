using aula28_Rotas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aula28_Rotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<PersonModel>persons = new List<PersonModel>();

            persons.Add(new PersonModel() { id = 1, Nome = "William", Sobrenome = "Sant Anna", Status = "Reprovado" });
            persons.Add(new PersonModel() { id = 2, Nome = "Thiago", Sobrenome = "Machado", Status = "Aprovado" });
            persons.Add(new PersonModel() { id = 3, Nome = "Rodrigo", Sobrenome = "Braga", Status = "Aprovado" });
            persons.Add(new PersonModel() { id = 4, Nome = "Caroline", Sobrenome = "da Silva", Status = "Recuperação" });

            return View(persons);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Perfil()
        {

            List<MateriasModel> materias = new List<MateriasModel>();

            materias.Add(new MateriasModel() { Materia = "Português", NotaUm = 5, NotaDois = 6.5, NotaTres = 6.5, NotaQuatro = 0, Status = "Reprovado" });
            materias.Add(new MateriasModel() { Materia = "Matemática", NotaUm = 10, NotaDois = 8, NotaTres = 8, NotaQuatro = 8, Status = "Aprovado" });
            materias.Add(new MateriasModel() { Materia = "Ciências", NotaUm = 6, NotaDois = 7.5, NotaTres = 8, NotaQuatro = 8, Status = "Aprovado" });
            materias.Add(new MateriasModel() { Materia = "História", NotaUm = 8, NotaDois = 9, NotaTres = 10, NotaQuatro = 7.5, Status = "Aprovado" });

            return View(materias);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}