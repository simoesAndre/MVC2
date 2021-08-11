using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_03.Models;

namespace Atividade_03.Controllers
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
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agendamento(Paciente PacienteAtual)
        {
            Dados.Incluir(PacienteAtual);
            return View("Concluido");
        }

        public IActionResult Confirmacao()
        {
            List<Paciente> informacoes = Dados.Listar();
            return View(informacoes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
