using Loja_de_Carros.Database;
using Loja_de_Carros.Models;
using Loja_de_Carros.Models.Functions;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        new LoadingScreenFunc().LoadingScreen();
        new HomePage().Home();
    }
}