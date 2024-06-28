using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja_de_Carros.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Price { get; set; }
        
        public Veiculo() { }

        public Veiculo(string marca, string modelo, int ano, decimal price)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Price = price;
        }
    }    
}
