using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Operacoes
    {
       

        public Operacoes()
        {
        }

        

        public int Numero { get; set; }
        private double _Valor;
        public double Valor
        {
            get { return _Valor; }
            set
            {
                _Valor = value;
                if (_Valor < 0)
                {
                    _tipo = "Despesa";
                }
                else
                    _tipo = "Receita";
            }
        }
        public Categoria _Categoria { get; set; }
        public Conta _Conta { get; set; }
        public DateTime DataHora { get; set; }
        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
        }
    }
}
