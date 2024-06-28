using Loja_de_Carros.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Loja_de_Carros.Models.Functions;

public class CarListFunc : LojaContext
{
    public void CarList()
    {
        Console.Clear();
        var context = new LojaContext();

        Console.WriteLine("\n\n\n\n\n");
        Console.WriteLine("                                                                           ╔═════════════════════════════════════════╗");
        Console.WriteLine("                                                                           ║                                         ║");
        Console.WriteLine("                                                                           ║             Lista de Carros             ║");
        Console.WriteLine("                                                                           ║                                         ║");
        Console.WriteLine("                                                          ╔═════╦══════════╩═╦══════════════════════╦══════╦═════════╩══════════════╗");
        Console.WriteLine("                                                          ║ ID  ║ Marca      ║ Modelo               ║ Ano  ║ Preço                  ║");
        Console.WriteLine("                                                          ╠═════╬════════════╬══════════════════════╬══════╬════════════════════════╣");

        foreach (var car in context.Veiculos)
        {
            Console.WriteLine(
                $"                                                          ║ {car.Id,-3} ║ {car.Marca,-10} ║ {car.Modelo,-20} ║ {car.Ano,-2} ║ R${car.Price.ToString("N"),-20} ║");
            Console.WriteLine("                                                          ╠═════╬════════════╬══════════════════════╬══════╬════════════════════════╣");
        }

        Console.WriteLine("                                                          ╚═════╩════════════╩══════════════════════╩══════╩════════════════════════╝");
        
        Console.WriteLine("\n\n                                                          0 - Voltar\n");

        var keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.D0 || keyInfo.Key == ConsoleKey.NumPad0)
        {
            Console.Clear();
            new HomePage().Home();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(" Erro, escolha alguma opção existente");
            Thread.Sleep(2500);
            CarList();
        }
    }
}