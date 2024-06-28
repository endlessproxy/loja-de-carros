using Microsoft.EntityFrameworkCore;

namespace Loja_de_Carros.Models
{
    abstract class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int idade, string cargo, double salario)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
        }
    }
}
