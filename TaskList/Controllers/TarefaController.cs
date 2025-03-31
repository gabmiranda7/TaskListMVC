using Microsoft.AspNetCore.Mvc;
using TaskList.Models;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskList.Services;

namespace TaskList.Controllers
{
    public class TarefaController : Controller
    {
        private AppDbContext _context;
        private ServiceTarefa _serviceTarefa;
        public TarefaController(AppDbContext context)
        {
            _context = context;
            _serviceTarefa = new ServiceTarefa(_context);
        }

        public async Task CarregarCombos()
        {
            ViewData["Categorias"] = new SelectList(await _serviceTarefa.RptCategoria.ListarTodosAsync(), "Id", "Nome");
            ViewData["Prioridades"] = new SelectList(await _serviceTarefa.RptPrioridade.ListarTodosAsync(), "Id", "Nome");
            ViewData["Responsaveis"] = new SelectList(await _serviceTarefa.RptResponsavel.ListarTodosAsync(), "Id", "Nome");
            ViewData["Status"] = new SelectList(await _serviceTarefa.RptStatus.ListarTodosAsync(), "Id", "Nome");
        }

        public async Task<IActionResult> Index()
        {
            var listaTarefas = await _serviceTarefa.RptTarefa.ListarTodosAsync();
            return View(listaTarefas);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await CarregarCombos();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tarefa tarefa)
        {
            await CarregarCombos();
            if (tarefa.DataInicio > tarefa.DataFim)
            {
                ModelState.AddModelError("DataInicio", "A Data de Fim não pode ser maior que a Data de Início");
            }
            if (ModelState.IsValid)
            {
                //ViewData["Mensagem"] = "Dados salvos com sucesso!";
                ViewBag.Mensagem = "Dados salvos com sucesso!";
                await _serviceTarefa.RptTarefa.IncluirAsync(tarefa);
                return View(tarefa);
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
