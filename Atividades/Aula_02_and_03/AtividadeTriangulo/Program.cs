using System;
using AtividadeTriangulo.Entities;

namespace AtividadeTriangulo
{
    class Program
    {

        /*
        Gere uma classe que lerá as informações de base e altura de triângulos,
        a classe deve possuir métodos de leitura de dados, de exibição de das 
        informações e um método para calcular sua Área. Crie uma classe para testar.
        */
        
        static void Main(string[] args)
        {
            Console.Write("Qual é a altura do triângulo? ");
            decimal altura = System.Convert.ToDecimal(Console.ReadLine());
            Console.Write("Qual é a base do triângulo? ");
            decimal baseTriangulo = System.Convert.ToDecimal(Console.ReadLine());

            Triangulo objTriangulo = new Triangulo(altura, baseTriangulo);
            Console.WriteLine("A área do triangulo é: " + objTriangulo.AreaTriangulo(altura, baseTriangulo));
        }
    }
}
