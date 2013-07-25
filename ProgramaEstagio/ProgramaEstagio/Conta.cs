using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Conta
    {
        
        
        public Conta()
        {
        }

        
        public int Numero { get; set; }
        public string Nome { get; set; }
        public Cliente _Cliente { get; set; }
        public double Saldo { get; set; }
        
    }
}
