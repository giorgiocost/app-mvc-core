using System;

namespace app_mvc_core.Models
{
    public class Aluno
    {
        public Aluno(Parameters)
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}