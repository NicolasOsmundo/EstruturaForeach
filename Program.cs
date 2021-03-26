using System;

public class EstruturaForeach
{
    static void Main(string[] args)
    {
        string[] lista = { "Projeto", "Projetando", "Gp Projeto" };
        foreach (string nome in lista)
        {
            Console.WriteLine(nome);
        }
        Console.Read();
    }
}
