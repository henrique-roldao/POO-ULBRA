using System;
using AtividadeData.Entities;

/*
Escreva uma classe chamada Data, com os seguintes atributos inteiros: dia, 
mês e ano. Permita a entrada destes atributos verificando a consistência dessas 
datas, por exemplo não aceitar 31, caso o mês seja 02. Crie uma classe para testar.
*/

namespace AtividadeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(0, 12, 2);

            Console.WriteLine(data.getDay() + "/" + data.getMonth() + "/" + data.getYear());

            //DateTime data1 = new DateTime(2022,2,30);
            //Console.WriteLine(data1.Day + "/" + data1.Month + "/" + data1.Year);
        }
    }
}
