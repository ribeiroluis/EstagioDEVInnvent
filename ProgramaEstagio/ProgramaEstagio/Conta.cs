using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Conta
    {
        List<Conta> ListaContas = new List<Conta>();
        
        public Conta()
        {
        }

        public int InsereConta(Conta _novaconta)
        {
            try
            {
                _novaconta.Numero = ListaContas.Count + 1;
                ListaContas.Add(_novaconta);
                Console.WriteLine("Conta criada com Sucesso..");
                return 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        public void RealizaDeposito(Operacoes _opera)
        {
            _opera.Deposito(_opera);
            AtualizaSaldo(_opera);
        }

        public void RealizaSaque(Operacoes _opera)
        {
 
        }

        private void AtualizaSaldo(Operacoes _opera)
        {
            int i = 0;

            if (_opera.Tipo.Equals("Credito"))
            {
                foreach (var item in ListaContas)
                {
                    if (item.Numero == _opera._Conta.Numero)
                    {
                        Conta aux = item;
                        aux.Saldo += _opera.Valor;
                        ListaContas[i] = aux;
                        break;
                    }
                    else
                        i++;

                }

            }
            else
            {
                foreach (var item in ListaContas)
                {
                    if (item.Numero == _opera._Conta.Numero)
                    {
                        Conta aux = item;
                        aux.Saldo -= _opera.Valor;
                        ListaContas[i] = aux;
                        break;
                    }
                }
            }
        }

       
        private int Numero { get; set; }
        public string Nome { get; set; }
        public Cliente _Cliente { get; set; }
        public double Saldo { get; set; }
    }
}
