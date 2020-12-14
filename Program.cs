using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double [10];

            double min = 100000000000000;
            double max = 0;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine();

                Console.WriteLine($"Digite o {i+1}° número: ");

                Console.WriteLine();

                numeros[i] = double.Parse(Console.ReadLine());

                if (numeros[i] > max) { 
                    
                    max = numeros[i];
                    
                }
                
                if (numeros[i] < min) { 
                    
                    min = numeros[i];
                    
                }
              
            }

                Console.WriteLine();
                
                Console.WriteLine("O menor valor dentre os dez valores inseridos é:");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(min);

                Console.ResetColor();
                
                Console.WriteLine();
                Console.WriteLine();
                
                Console.WriteLine("O maior valor dentre os dez valores inseridos é:");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(max);

                Console.ResetColor();

                Console.WriteLine();
        
        }
    }
}
