using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Loja_de_Carros.Models.Functions;

public class HomePage
{
    public void Home()
    {
        Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                                    Bem-vindo(a), ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{Environment.UserName}\n\n");
        Console.ResetColor();
        Console.WriteLine("                                                               ╔═══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("                                                               ║                                                               ║");
        Console.WriteLine(
            $"                                                               ║ {"                 1  - Criar um novo anuncio",-3}                   ║\n                                                               ║ {"              2  - Ver Lista de Carros na Loja",-10}                ║\n                                                               ║ {"             3  - Atualizar Dados de um Anuncio",-10}               ║\n                                                               ║ {"              4  - Remover um Anuncio da Loja",-20}                 ║\n                                                               ║                                                               ║\n                                                               ║ {"                         0  - Sair",-10}                            ║");
        Console.WriteLine("                                                               ║                                                               ║");
        Console.WriteLine("                                                               ╚═══════════════════════════════════════════════════════════════╝");

        Console.WriteLine("");

        var keyInfo = Console.ReadKey().Key;

        switch (keyInfo)
        {
            case ConsoleKey.D1 or ConsoleKey.NumPad1:
                Console.Clear();
                new CreateCarFunc().CreateCar();
                break;
            case ConsoleKey.D2 or ConsoleKey.NumPad2:
                Console.Clear();
                new CarListFunc().CarList();
                break;
            case  ConsoleKey.D3 or ConsoleKey.NumPad3:
                Console.Clear();
                new UpdateCarFunc().UpdateCar();
                break;
            case ConsoleKey.D4 or ConsoleKey.NumPad4:
                Console.Clear();
                new DeleteCarFunc().DeleteCar();
                break;
            case ConsoleKey.D0 or ConsoleKey.NumPad0:
                Console.Clear();
                break;
            default:
                Console.WriteLine(" Escolha uma das 4 opções disponiveis!");
                Home();
                break;
        }
    }
}