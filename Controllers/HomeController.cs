using Fiap01.Data;
using Fiap01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Controllers
{

  
    public class HomeController : Controller
    {

        PerguntasContext _context { get; set; }

        public HomeController(PerguntasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Nome = "Lucas";
            ViewData["NomeDoAluno"] = $"Outro Nome {DateTime.Now}";

            //var pergunta = new Pergunta() { Id = 1, Descricao = "Descricao da pergunta", Autor="Lucas" };
           

            return View(_context.Perguntas.ToList());


            // return View("OutraView");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Create(Pergunta pergunta)
        {
            if(ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);
                _context.SaveChangesAsync();


            }

            return View();

        }

        public IActionResult Ajuda()
        {
            return View();
           
        }

        public IActionResult Sobre()
        {
            return View();
           
        }
    }
}
