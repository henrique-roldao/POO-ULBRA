using System;
using Aula02TesteAmbiente.Entities;

namespace Aula02TesteAmbiente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Autor oAutor = new Autor(128, "Hisuy");

            Livro objLivro = new Livro(100, "Banco de dados", oAutor);  
            Console.WriteLine(
                objLivro.GetId() + " - " + 
                objLivro.GetTitulo() + " - " + 
                objLivro.GetValor() + " - " +
                objLivro.Autor.Nome);

            objLivro.SetValor(199);
            Console.WriteLine("valor do livro: R$" + objLivro.GetValor());
        }
    }
}
