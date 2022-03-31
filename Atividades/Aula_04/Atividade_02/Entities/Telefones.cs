using System.Collections.Generic;
using System;

namespace Atividade_02.Entities
{
    public class Telefone
    {
        public Telefone(string tipoTelefone, long numeroTelefone)
        {
            TipoTelefone = tipoTelefone;
            NumeroTelefone = numeroTelefone;
        }

        public string TipoTelefone { get; set; }
        public long NumeroTelefone { get; set; }
        public Cliente Cliente { get; set; }
    }
}