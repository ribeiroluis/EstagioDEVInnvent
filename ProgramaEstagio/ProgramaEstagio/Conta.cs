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
            _opera.InsereOperacao(_opera);
            AtualizaSaldo(_opera);
        }

        public void RealizaSaque(Operacoes _opera)
        {
            if (_opera._Conta.Saldo > _opera.Valor)
            {
                _opera.InsereOperacao(_opera);
                AtualizaSaldo(_opera);
            }
            else
                Console.WriteLine("Saldo insuficiente para transação." + _opera._Conta.Saldo.ToString("c"));

            
        }

        public void RealizaTransferencia(Operacoes _Emissor, Operacoes _Destinatario)
        {
            try
            {

                if (_Emissor._Conta.Saldo > _Emissor.Valor)
                {
                    foreach (var emissor in ListaContas)
                    {
                        if (emissor == _Emissor._Conta)
                        {
                            foreach (var destinatario in ListaContas)
                            {
                                if (destinatario == _Destinatario._Conta)
                                {

                                }
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("Saldo insuficiente para transação." + _Emissor._Conta.Saldo.ToString("c"));

                
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
            }
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
                        Console.WriteLine("Saldo Disponivel: " + _opera._Conta.Saldo.ToString("c"));
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
                        aux.Saldo += _opera.Valor;
                        ListaContas[i] = aux;
                        Console.WriteLine("Saldo Disponivel: " + _opera._Conta.Saldo.ToString("c"));
                        break;
                    }
                }
            }
        }

       
        private int Numero { get; set; }
        public string Nome { get; set; }
        public Cliente _Cliente { get; set; }
        private double Saldo;
        public double saldo
        {
            get { return Saldo; }
        }
        
    }
}
