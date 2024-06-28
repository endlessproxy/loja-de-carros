namespace Loja_de_Carros.Models.Functions;

public class LoadingScreenFunc
{
    public void LoadingScreen()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                                           Carregando");
            Console.WriteLine("                                                                                               ");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                                           Carregando");
            Console.WriteLine("                                                                                               .");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                                           Carregando");
            Console.WriteLine("                                                                                               ..");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                                           Carregando");
            Console.WriteLine("                                                                                               ...");
            Thread.Sleep(200);
        }
    }
}