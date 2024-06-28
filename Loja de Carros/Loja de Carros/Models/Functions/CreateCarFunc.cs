using System.Globalization;
using Loja_de_Carros.Database;

namespace Loja_de_Carros.Models.Functions;

public class CreateCarFunc : Veiculo
{
    public CreateCarFunc() : base("", "", 0, 0)
    {
    }

    public void CreateCar()
    {
        try
        {
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                              ╔══════════════════════════════════╗");
            Console.WriteLine("                                                                              ║                                  ║");
            Console.WriteLine("                                                                              ║     Cadastro de novo Veículo     ║");
            Console.WriteLine("                                                                              ║                                  ║");
            Console.WriteLine("                                                                              ╠══════════════════════════════════╣");
            
            Console.Write("                                                                              ║ Digite a marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("                                                                              ╠══════════════════════════════════╣");
            
            Console.Write("                                                                              ║ Digite o modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("                                                                              ╠══════════════════════════════════╣");
            
            Console.Write("                                                                              ║ Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine($"                                                                              ╠══════════════════════════════════╣");
            
            Console.Write("                                                                              ║ Digite o preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            // Exibição dos dados cadastrados
            Console.WriteLine("                                                                              ╠══════════════════════════════════╣");
            Console.WriteLine($"                                                                              ║ Veículo cadastrado com sucesso!  ║");
            Console.WriteLine($"                                                                              ║ Marca: {marca,-26}║");
            Console.WriteLine($"                                                                              ║ Modelo: {modelo,-25}║");
            Console.WriteLine($"                                                                              ║ Ano: {ano,-28}║");
            Console.WriteLine($"                                                                              ║ Preço: R${preco.ToString("N"), -24}║");
            Console.WriteLine("                                                                              ╚══════════════════════════════════╝");

            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Price = preco;

            var context = new LojaContext();
            var x = new Veiculo(marca, modelo, ano, preco);

            context.Veiculos.Add(x);
            context.SaveChanges();
            
            Thread.Sleep(8000);
            
            new HomePage().Home();
        }
        catch (Exception e)
        {
            Console.WriteLine($" Erro: {e.Message}");
        }
    }
}