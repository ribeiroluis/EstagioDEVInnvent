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

        public int Deposito(Operacoes _operacao)
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

        public int Saque(Operacoes _operacao)
        {
            try
            {
                ///
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
            }
        }

        private int Numero { get; set; }
        public double Valor { get; set; }
        public Categoria Categoria { get; set; }
        public Conta _Conta { get; set; }
        private DateTime DataHora { get; set; }
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set
            {
                if (Valor < 0)
                {
                    tipo = "DEBITO";
                }
                else
                    tipo = "CREDITO";
            }


        }
    }
}
