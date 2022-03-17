using System;
using AtividadeHora.Entities;

namespace AtividadeHora
{

    /*
    Escreva uma classe chamada Hora, com os seguintes atributos inteiros: hora,
     minutos e segundo. Permita a entrada destes atributos somente se ele for 
     uma hora válida.Crie uma classe para testar.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Hora hora = new Hora(21, 78, 300);

            Console.WriteLine(hora.getHora() + ":" + hora.getMinutos() + ":" + hora.getSegundos());
        }
    }
}
