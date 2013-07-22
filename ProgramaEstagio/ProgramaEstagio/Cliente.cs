using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Cliente
    {
        List<Cliente> clienteLista = new List<Cliente>();

        public Cliente(List<Cliente> _ClienteLista)
        {
            clienteLista = _ClienteLista;
        }

        public string CPF { get; set; }
        public string Nome { get; set; }    




    }
}
