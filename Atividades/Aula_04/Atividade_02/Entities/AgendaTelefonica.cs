using System.Collections.Generic;

namespace Atividade_02.Entities
{
    public class AgendaTelefonica
    {
        public AgendaTelefonica(List<Cliente> clientes)
        {
            Clientes = clientes;
        }

        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}