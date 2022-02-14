using System;

namespace Prova1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3, soma1, soma2, soma3;
            char continuar;
            bool repetir;

            do
            {
                Console.Write("Digite o comprimento do primeiro lado do triangulo: ");
                l1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o comprimento do segundo lado do triangulo: ");
                l2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o comprimento do terceiro lado do triangulo: ");
                l3 = Convert.ToDouble(Console.ReadLine());

                soma1 = l1 + l2;
                soma2 = l2 + l3;
                soma3 = l1 + l3;

                if (l1 > soma2 || l2 > soma3 || l3 > soma1)
                {
                    Console.WriteLine("Triângulo Inválido!");
                }
                else
                {
                    if (l1 == l2 && l1 == l3)
                    {
                        Console.WriteLine("É um triângulo equilátero!");
                    }
                    else
                    {
                        if (l1 == l2 || l1 == l3 || l2 == l3)
                        {
                            Console.WriteLine("É um triângulo isóceles!");
                        }
                        else
                        {
                            Console.WriteLine("É um triângulo escaleno!");
                        }
                    }
                }                
    
                Console.Write("Deseja continuar? Digite S para continuar, ou N para sair: ");
                continuar = Convert.ToChar(Console.ReadLine());

                repetir = continuar == 'S' || continuar == 's';

             }while(repetir == true);
        }
    }
}
