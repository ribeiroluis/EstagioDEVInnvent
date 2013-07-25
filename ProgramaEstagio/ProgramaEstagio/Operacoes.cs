using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Operacoes
    {
        List<Operacoes> ListaOperacoes = new List<Operacoes>();

        public Operacoes()
        {
        }

        public int InsereOperacao(Operacoes _operacao)
        {
            try
            {
                _operacao.Numero = ListaOperacoes.Count + 1;
                _operacao.DataHora = DateTime.Now;
                ListaOperacoes.Add(_operacao);
                Console.WriteLine("Deposito realizado com sucesso");
                return 1;

            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        private int Numero { get; set; }
        private double _Valor;
        public double Valor
        {
            get { return _Valor; }
            set
            {
                _Valor = value;
                if (_Valor < 0)
                {
                    _tipo = "Debito";
                }
                else
                    _tipo = "Credito";
            }
        }
        public Categoria Categoria { get; set; }
        public Conta _Conta { get; set; }
        private DateTime DataHora { get; set; }
        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
        }
    }
}
