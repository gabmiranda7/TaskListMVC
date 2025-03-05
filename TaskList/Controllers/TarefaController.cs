using Microsoft.AspNetCore.Mvc;
using TaskList.Models;
using System.Data;

namespace TaskList.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            var lista = new List<Tarefa>();
            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 1,
                Descricao = "Tarefa 1"
            });

            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 2,
                Descricao = "Tarefa 2"
            });

            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 3,
                Descricao = "Tarefa 3"
            });

            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 4,
                Descricao = "Tarefa 4"
            });

            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {

            if (tarefa.DataInicio > tarefa.DataFim)
            {
                ModelState.AddModelError("DataInicio", "A Data de Fim não pode ser maior que a Data de Início");
            }
            if (ModelState.IsValid)
            {
                //ViewData["Mensagem"] = "Dados salvos com sucesso!";
                ViewBag.Mensagem = "Dados salvos com sucesso!";
                return View(tarefa);
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var lista = new List<Tarefa>();
            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 1,
                Descricao = "Tarefa 1"
            });

            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 2,
                Descricao = "Tarefa 2"
            });

            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 3,
                Descricao = "Tarefa 3"
            });

            lista.Add(new Tarefa()
            {
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddDays(5),
                Id = 4,
                Descricao = "Tarefa 4"
            });

            var tarefa = lista.FirstOrDefault(lista => lista.Id == id);
            //var tarefa = (from p in lista where p.Id == id select p).FirstOrDefault();

            return View(tarefa);
        }
    }
}
