using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP03.Models;

namespace TP03.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Leandro Bento Bergamo";
            aluno.Ra = "160548";
            aluno.DataDeNascimento = new DateTime(1995,03,02);

            return View(aluno);
        }
    }
}
