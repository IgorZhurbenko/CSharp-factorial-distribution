using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //string str;
            //str = Console.ReadLine();
            while (5==5)
            {
                Console.WriteLine("Print the number to process: ");
                Int64 n = Convert.ToInt64(Console.ReadLine());
                Int16[] Solution = new Int16[100];
                FactorialDistribution(n,Solution);
                string answer = ComposeAnswer(Solution);
                //Console.WriteLine(answer.Length);
                Console.Write(ComposeAnswer(Solution)); 
                
                Console.WriteLine();

                //Console.WriteLine(FactorialDistribution(n));
                //Console.ReadKey();
            }
        }
        
        static Int64 Factorial(int a)
        {
            if (a > 1) { return a * Factorial(a - 1); } else { return 1; }
        }

        static Int16 LargestFactorial(Int64 a)
        { Int16 i; i = 1; while (Factorial(i) <= a) { i++; } return (Int16)(i - 1); }

        static void FactorialDistribution(Int64 a, Int16[] container, int pointer = 0)
        {
            if (a < 2) { container[pointer] = 1; }
            else { 
                Int16 LF = LargestFactorial(a);
                container[pointer] = LF;
                FactorialDistribution(a - Factorial(LF), container, pointer+1);
            }
        }

        static string ComposeAnswer(Int16[] container) 
        { 
            string str = "";
            for (int i = 0; i < 100; i++)
            {
                if (container[i] == 0)
                { break; }
                else
                { str = str + "!" + Convert.ToString(container[i]) + " + "; }
            }
            
            return str.Substring(0, str.Length - 3);
            
        }
    }
}
