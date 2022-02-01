using System;

namespace examen1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string x = Console.ReadLine();
                while (string.IsNullOrEmpty(x))
                                x = Console.ReadLine();

            Console.WriteLine("varsta primului copil este: ");
            int a;
            
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("varsta celui de-al doilea copil este: ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine($" primul copil este mai mare cu {a - b}");
            else
                if (a==b)
                Console.WriteLine($"au aceeasi varsta  {0}");
            else
                Console.WriteLine($" Al doilea copil e mai mare cu {b - a}");*/

            Console.WriteLine("scrie numarul");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("scrie numarul");
             int b;
             b = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            while (a!=b)
            {
                Console.WriteLine("scrie numarul");
                int c;
                c = Convert.ToInt32(Console.ReadLine());

                sum = sum + c;

                a = b;
                b = c;

                
            }
            Console.WriteLine($"suma este {sum}");

        }
    }
}
