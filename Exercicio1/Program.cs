using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com as medidas do triângulo X:");
                double ladoA = float.Parse(Console.ReadLine());
                double ladoB = float.Parse(Console.ReadLine());
                double ladoC = float.Parse(Console.ReadLine());

                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

                Console.WriteLine($"Área do Triângulo: {triangulo.calcularArea().ToString("F4")}");
                Console.WriteLine("Pressione qualquer tecla para sair");

                Console.ReadKey();
            }
            catch (Exception falha)
            {
                Console.WriteLine($">{falha.Message}");

                Console.ReadKey();
            }
        }
    }
}
