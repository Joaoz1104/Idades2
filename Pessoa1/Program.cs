using System;

namespace Pessoa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");

            Console.WriteLine("Nome:");
            p.Nome1 = Console.ReadLine();

            Console.WriteLine("Idade:");
            p.Idade1 = byte.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.WriteLine("Nome:");
            p.Nome2 = Console.ReadLine();

            Console.WriteLine("Idade:");
            p.Idade2 = byte.Parse(Console.ReadLine());

            Console.WriteLine(p);
        }
    }
}
