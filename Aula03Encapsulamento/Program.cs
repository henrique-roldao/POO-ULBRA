using System;
using Aula03Encapsulamento.Domain;

namespace Aula03Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Message("Criar objeto mochila");

            Mochila mp = new Mochila(1, "Mochila de Notebook", 200, 20, eCor.Preto);
            Message(mp.Descricao);

            Item celular = new Item(1, "Iphone 8 Plus");
            Item caneta = new Item(103, "Caneta Bic");

            mp.Itens.Add(celular);
            mp.Itens.Add(caneta);

            Message("Nome: " + mp.Descricao);
            Message("Itens: ");
            foreach (var Item in mp.Itens)
            {
                Message(Item.Nome);
            }
            
        }

        private static void Message(string message) {
            Console.WriteLine(message);
        }
    }
}