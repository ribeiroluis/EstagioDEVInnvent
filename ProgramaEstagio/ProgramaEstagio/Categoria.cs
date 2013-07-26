using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Categoria
    {
        
       
        public Categoria()
        {
        }
        public int IdCategoria { get; set; }
        public string  CategoriaNome { get; set; }
        public SubCategoria _SubCategoria { get; set; }
    }
}
