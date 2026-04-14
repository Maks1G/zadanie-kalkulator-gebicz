using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Write("Podaj a (lub q aby zakonczyc): ");
            string rawA = Console.ReadLine();

            if (rawA.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                running = false;
                continue;
            }

            try
            {
                int a = Convert.ToInt32(rawA);

                Console.Write("Podaj operator (+ - * /): ");
                string oper = Console.ReadLine();

                Console.Write("Podaj b: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int wynik;

                if (oper == "+")
                    wynik = a + b;
                else if (oper == "-")
                    wynik = a - b;
                else if (oper == "*")
                    wynik = a * b;
                else if (oper == "/")
                    wynik = a / b;
                else
                {
                    Console.WriteLine("Nieznany operator!");
                    continue;
                }

                Console.WriteLine($"Wynik: {wynik}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Nie rzucaj wyjątku");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie dziel przez 0");
            }
        }
    }
}
