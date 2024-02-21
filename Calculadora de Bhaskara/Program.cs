using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool ie = true;

            while (ie)
            {
                int a, b, c, result, option;
                int[] results;

                Console.WriteLine("Bem vindo a calculadora de bhaskara\nDigite o valor de A: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de B: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de C: ");
                c = int.Parse(Console.ReadLine());

                int delta = FazDelta(a, b, c);

                if(delta < 0)
                {
                    Console.WriteLine("Delta é igual a " + delta + ", logo não possui raízes reais! ");
                } else if(delta == 0)
                {
                    result = -b / (2 * a);
                    Console.WriteLine("Delta é igual a " + delta + ", logo sua unica raíz real é : " + result);
                } else
                {
                   results = BaskharaFormula(delta, a, b, c);
                    Console.WriteLine("Valor de Delta é: " + delta);
                    for (int i = 0; i < results.Length; i++) 
                    {
                        Console.WriteLine("Valor da " + (i+1) + " raíz real é: " + results[i]);
                    }
                }
                Console.WriteLine("Deseja realizar outra conta? \n1-Sim\n2-Não");
                option = int.Parse(Console.ReadLine());
                if(option == 2)
                {
                    ie = false;
                }
            }
            
        
        }

        public static int FazDelta(int a, int b, int c)
        {
            int delta = (b * b) - 4 * a * c;
            return delta;
        }

        public static int[] BaskharaFormula( int delta, int a, int b, int c)
        {
            int[] raizes = new int[2];
            raizes[0] = (int)((-b + Math.Sqrt(delta)) / (2 * a));
            raizes[1] = (int)((-b - Math.Sqrt(delta)) / (2 * a));
            return raizes;
        }
    }
}
