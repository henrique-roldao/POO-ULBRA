using System;
using System.Collections.Generic;

namespace Aula03Encapsulamento.Domain
{
    public class Mochila
    {
        public Mochila(int id, string descricao, decimal preco, int quantidadeMaxima, eCor cor)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            QuantidadeMaxima = quantidadeMaxima;
            Cor = cor;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; set; }
        public int QuantidadeMaxima { get; private set; }
        public eCor Cor { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();
        
        
    }
}