using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0, num1 = 0, num2 = 1, aux =0;
            Console.WriteLine("Quantidade de número da sequência de fibbonacci: ");

            quantidade = Convert.ToInt32(Console.ReadLine());

            if(quantidade == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (quantidade >= 2)
                {
                    Console.WriteLine("\n0\n1");
                }
            }            

           for (int i = 0; i < (quantidade - 2); i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;

                Console.WriteLine("{0}",num2);
            }

            Console.ReadKey();
        }
    }
}
