using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Podaj a (lub q aby wyjść): ");
            string wejscieA = Console.ReadLine();

            if (wejscieA == "q")
                break;

            int a;
            if (!int.TryParse(wejscieA, out a))
            {
                Console.WriteLine("To nie jest liczba!");
                continue;
            }

            Console.Write("Podaj operator (+ - * /): ");
            string oper = Console.ReadLine();

            Console.Write("Podaj b: ");
            int b;
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("To nie jest liczba!");
                continue;
            }

            if (oper == "/" && b == 0)
            {
                Console.WriteLine("Nie dziel przez 0!");
                continue;
            }

            int wynik = 0;

            switch (oper)
            {
                case "+":
                    wynik = a + b;
                    break;
                case "-":
                    wynik = a - b;
                    break;
                case "*":
                    wynik = a * b;
                    break;
                case "/":
                    wynik = a / b;
                    break;
                default:
                    Console.WriteLine("Nieznany operator!");
                    continue;
            }

            Console.WriteLine("Wynik: " + wynik);
        }
    }
}
