using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("1ci ededi daxil et");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2ci eded daxil et");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("operator daxil et");
            string simvol = (Console.ReadLine());
            Console.WriteLine(eded(num1, num2, simvol));
             

        }
        static int eded(int num1, int num2, string simvol)
        {
            int result = 0;
            if (simvol == "+")
            {
                result = num1 + num2;
            }
            else if (simvol == "-")
            {
                result= num1 - num2;
            }
            else if (simvol == "/")
            {
                if ( num2 == 0)
                {
                    Console.WriteLine("0-a bolme yoxdur");
                }
                else
                {
                    result = num1 / num2;
                }
                
            }

            else if (simvol == "*")
            {
                result= num1 * num2;
            }
            else
            {
                Console.WriteLine("duzgun eded daxil et");
            }
            return result;
        }


    }
}