using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double rok;
            double vypocet;

            Console.CursorVisible = false;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine();
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("Zadejte svůj rok narození");
            double.TryParse(Console.ReadLine(), out rok);
            Console.SetCursorPosition(10, 12);
            Console.WriteLine();
            Console.ReadLine();

            vypocet = (DateTime.Now.Year - rok);
            if (vypocet >= 100 & vypocet == 100)
                Console.WriteLine("Neplatny rok narození");
            if (rok == 2021)
                Console.WriteLine("Neplatny rok narození");
            if (vypocet >= 1 & vypocet <= 6)
                Console.WriteLine($"Je vam { vypocet } let, jste stále jen dítě");
            if (vypocet >= 15 & vypocet <= 18)
                Console.WriteLine($"Je vam { vypocet } let, jste už teenager");
            if (vypocet >= 19 & vypocet <= 22)
                Console.WriteLine($"Je vam { vypocet } let, jste pravděpodobně student");
            if (vypocet >= 23 & vypocet <= 30)
                Console.WriteLine($"Je vam { vypocet } let, jste už dospělý");
            if (vypocet >= 31 & vypocet <= 40)
                Console.WriteLine($"Je vam { vypocet } let, Nejelpší léta už jsou z vámi");
            if (vypocet >= 41 & vypocet <= 50)
                Console.WriteLine($"Je vam { vypocet } let, stále nejste moc starý");
            if (vypocet >= 51 & vypocet <= 65)
                Console.WriteLine($"Je vam { vypocet } let, pomaličku už se chystejte do důchodu");
            if (vypocet > 66 & vypocet <= 99)
                Console.WriteLine($"Je vam { vypocet } let, už jste v důchodu");


        }
    }
}