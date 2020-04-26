using System;
using System.Linq;
using app_mvc_core.Data;
using app_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;
        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Giorgio",
                DataNascimento = DateTime.Now,
                Email = "giorgio@email.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == aluno.Email);
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == aluno.Email);

            aluno.Nome = "Giorgio Costa";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
            return View();
        }
    }
}