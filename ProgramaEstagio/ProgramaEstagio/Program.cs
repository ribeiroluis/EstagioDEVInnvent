using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Program
    {        
        static void Main(string[] args)
        {
            Operacoes_Bancarias x = new Operacoes_Bancarias();
            
            

            //////////////////////////////////////////////////////////////////////////////////
            Cliente obj_cliente = new Cliente();
            Conta obj_Conta = new Conta();
            Operacoes obj_Opera = new Operacoes();

            obj_cliente.Nome = "Luis";
            x.IncluirCliente(obj_cliente);

            obj_Conta.Nome = "Conta Corrente";
            obj_Conta._Cliente = obj_cliente;
            x.InsereConta(obj_Conta);
            
            obj_Opera.Valor = 100.00;
            obj_Opera._Conta = obj_Conta;
            x.RealizaDeposito(obj_Opera);

            Operacoes obj_Opera1 = new Operacoes();
            obj_Opera1.Valor = -83.42;
            obj_Opera1._Conta = obj_Conta;
            x.RealizaSaque(obj_Opera1);


            Operacoes obj_Opera2 = new Operacoes();
            obj_Opera2.Valor = 500.00;
            obj_Opera2._Conta = obj_Conta;
            x.RealizaDeposito(obj_Opera2);

            ///////////////////////////////////////////////////////////////////////////////////

            Cliente obj_cliente1 = new Cliente();
            obj_cliente1.Nome = "Alice";
            x.IncluirCliente(obj_cliente1);

            Conta obj_Conta1 = new Conta();
            obj_Conta1.Nome = "Poupanca";
            obj_Conta1._Cliente = obj_cliente1;
            x.InsereConta(obj_Conta1);

            Operacoes obj_opera3 = new Operacoes();
            obj_opera3.Valor = 300;
            obj_opera3._Conta = obj_Conta1;
            x.RealizaDeposito(obj_opera3);

            /////////////////////////////////////////////////////////////////////////////////////
            obj_Conta = new Conta();
            obj_Conta1 = new Conta();
            obj_Conta = x.Retornaconta("Luis");
            obj_Conta1 = x.Retornaconta("Alice");
            Operacoes emissor = new Operacoes();
            Operacoes destinatario = new Operacoes();
            emissor._Conta = obj_Conta;
            destinatario._Conta = obj_Conta1;
            emissor.Valor = -100;
            destinatario.Valor = emissor.Valor * -1;
            x.RealizaTransferencia(emissor, destinatario);

            x.ExibirTodosLancamentosBancarios();
            


            Console.ReadKey();

        }


        class Operacoes_Bancarias
        {
            List<Cliente> clienteLista = new List<Cliente>();
            public int IncluirCliente(Cliente _novoCliente)
            {
                try
                {
                    clienteLista.Add(_novoCliente);
                    Console.WriteLine("Cliente Inserido com Sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }
            public int ExcluirCliente(string _cpfCliente)
            {
                try
                {
                    int i = 0;
                    foreach (var item in clienteLista)
                    {
                        if (item.CPF.Equals(_cpfCliente))
                        {
                            clienteLista.RemoveAt(i);
                            break;
                        }
                        else
                            i++;

                    }
                    Console.WriteLine("Cliente Exluido com Sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }
            public int AlteraCliente(string _cpfCliente, Cliente _clienteAlterado)
            {
                try
                {
                    int i = 0;
                    foreach (var item in clienteLista)
                    {
                        if (item.CPF.Equals(_cpfCliente))
                        {
                            clienteLista[i] = _clienteAlterado;
                            break;
                        }
                        else
                            i++;

                    }
                    Console.WriteLine("Cliente Alterado com Sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }

            List<Categoria> ListaCategoria = new List<Categoria>();
            public int InsereCategoria(Categoria _novaCategoria)
            {
                try
                {
                    _novaCategoria.IdCategoria = ListaCategoria.Count + 1;
                    ListaCategoria.Add(_novaCategoria);
                    Console.WriteLine("Categoria criada com Sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }
            public int RemoveCategoria(int idCategoria)
            {
                try
                {
                    int i = 0;
                    foreach (var item in ListaCategoria)
                    {
                        if (item.IdCategoria == idCategoria)
                        {
                            ListaCategoria.RemoveAt(i);
                            break;
                        }
                        else
                            i++;

                    }
                    Console.WriteLine("Categoria Excluida com Sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }
            public int AlteraCategoria(int idCategoria, Categoria _categoriaAlterada)
            {
                try
                {
                    int i = 0;
                    foreach (var item in ListaCategoria)
                    {
                        if (item.IdCategoria == idCategoria)
                        {
                            ListaCategoria[i] = _categoriaAlterada;
                            break;
                        }
                        else
                            i++;

                    }
                    Console.WriteLine("Categoria alterada com sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }

            List<SubCategoria> ListaSubCategoria = new List<SubCategoria>();
            public int InsereSubCategoria(SubCategoria _novaSubCategoria)
            {
                try
                {
                    _novaSubCategoria.IdSubCategoria = ListaSubCategoria.Count + 1;
                    ListaSubCategoria.Add(_novaSubCategoria);
                    Console.WriteLine("SubCategoria criada com Sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }
            public int RemoveSubCategoria(int idSubCategoria)
            {
                try
                {
                    int i = 0;
                    foreach (var item in ListaSubCategoria)
                    {
                        if (item.IdSubCategoria == idSubCategoria)
                        {
                            ListaSubCategoria.RemoveAt(i);
                            break;
                        }
                        else
                            i++;

                    }
                    Console.WriteLine("SubCategoria Excluida com Sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }
            public int AlteraSubCategoria(int idSubCategoria, SubCategoria _SubCategoriaAlterada)
            {
                try
                {
                    int i = 0;
                    foreach (var item in ListaSubCategoria)
                    {
                        if (item.IdSubCategoria == idSubCategoria)
                        {
                            ListaSubCategoria[i] = _SubCategoriaAlterada;
                            break;
                        }
                        else
                            i++;

                    }
                    Console.WriteLine("SubCategoria alterada com sucesso..");
                    return 1;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }


            List<Conta> ListaContas = new List<Conta>();
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
                InsereOperacao(_opera);
                AtualizaSaldo(_opera);
            }
            public void RealizaSaque(Operacoes _opera)
            {
                if (_opera._Conta.Saldo > _opera.Valor)
                {
                    InsereOperacao(_opera);
                    AtualizaSaldo(_opera);
                }
                else
                    Console.WriteLine("Saldo insuficiente para transação." + _opera._Conta.Saldo.ToString("c"));


            }
            public void RealizaTransferencia(Operacoes _Emissor, Operacoes _Destinatario)
            {
                try
                {
                    int indiceEmissor = 0;
                    int indiceDestinatario = 0;
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
                                        InsereOperacao(_Emissor);
                                        InsereOperacao(_Destinatario);
                                        AtualizaSaldo(_Emissor);
                                        AtualizaSaldo(_Destinatario);
                                        break;
                                    }
                                    else
                                        indiceDestinatario++;
                                }
                                break;
                            }
                            else
                                indiceEmissor++;
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
            public Conta Retornaconta(string nome)
            {
                foreach (var item in ListaContas)
                {
                    if (nome.Equals(item._Cliente.Nome))
                        return item;
                }
                return null;
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


            List<Operacoes> ListaOperacoes = new List<Operacoes>();
            public int InsereOperacao(Operacoes _operacao)
            {
                try
                {
                    _operacao.Numero = ListaOperacoes.Count + 1;
                    _operacao.DataHora = DateTime.Now;
                    ListaOperacoes.Add(_operacao);
                    Console.WriteLine("Transação efetivada com sucesso!");
                    return 1;

                }
                catch (Exception err)
                {

                    Console.WriteLine(err.ToString());
                    return 0;
                }
            }

            public void ExibirTodosLancamentosBancarios()
            {
                IEnumerable<Operacoes> Lista = from op in ListaOperacoes orderby op.DataHora select op;

                Console.WriteLine("Data       |Cliente\t|Tipo    \t|Valor");
                Console.WriteLine("----------------------------------------------------");
                
                foreach (var item in Lista)
                {
                    string data = item.DataHora.ToShortDateString() + " |";
                    string cliente = item._Conta._Cliente.Nome + "\t|";
                    string tipo = item.Tipo + " \t|";
                    string valor = item.Valor.ToString("C");

                    Console.WriteLine(data + cliente + tipo + valor);
                }
            }


            
        }


        
    }
}
