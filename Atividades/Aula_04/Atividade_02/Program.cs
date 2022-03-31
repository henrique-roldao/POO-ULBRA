using System;
using System.Collections.Generic;
using Atividade_02.Entities;

/*
Identifique os atributos de  uma agenda	telefônica, modele as classes,
atributos e métodos necessários para a futura implementação.
*/

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco1 = new Endereco(95560000, "Ulbra Torres", 190, "Velho");
            Telefone telefone1 = new Telefone("Residencial", 51995202698);
            Telefone telefone2 = new Telefone("Comercial", 5136642443);

            Endereco endereco2 = new Endereco(903123, "Aleaatorio", 323, "Novo");
            Telefone telefone3 = new Telefone("Residencial", 53231231212);
            Telefone telefone4 = new Telefone("Comercial", 5188888232);

            Cliente Rolds = new Cliente(
                1, 
                "Henrique",
                new List<Telefone>(){
                    telefone1,
                    telefone2
                },
                new List<Endereco>(){
                    endereco1
                } 
            );

             Cliente Luan = new Cliente(
                1, 
                "Luan",
                new List<Telefone>(){
                    telefone3,
                    telefone4
                },
                new List<Endereco>(){
                    endereco2
                } 
            );

            AgendaTelefonica agenda = new AgendaTelefonica(
                new List<Cliente>(){
                    Rolds,
                    Luan
                }
            );

            foreach(var item in agenda.Clientes) {
                Console.WriteLine(item.Nome);
            }

        }
    }
}
