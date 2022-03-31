using System.Collections.Generic;
using System;

namespace Atividade_02.Entities
{
    public class Cliente
    {
        public Cliente(int id, string nome, List<Telefone> telefones, List<Endereco> enderecos)
        {
            this.id = id;
            Nome = nome;
            Telefones = new List<Telefone>(telefones);
            Enderecos = new List<Endereco>(enderecos);
        }

        public int id { get; private set; }
        public string Nome { get; private set; }
        public AgendaTelefonica AgendaTelefonica { get; set; }
        public List<Telefone> Telefones { get; set; } = new List<Telefone>();
        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();
    }
  
}