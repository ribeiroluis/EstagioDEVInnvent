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
            Console.Title = "Estágio Innvent!";
            
            Interface tela = new Interface();
            tela.MenuPrincipal();          
            
            //Operacoes_Bancarias x = new Operacoes_Bancarias();
            /*/////////////////////////////////////////////////////////////////////////////////
            Cliente obj_cliente = new Cliente();
            Conta obj_Conta = new Conta();
            Operacoes obj_Opera = new Operacoes();


            Categoria obj_categoria = new Categoria();
            SubCategoria subcategoria = new SubCategoria();
            obj_categoria.CategoriaNome = "Deposito";
            subcategoria.SubCategoriaNome = "Dinheiro";
            obj_categoria._SubCategoria = subcategoria;
            x.InsereCategoria(obj_categoria);

            obj_categoria = new Categoria();
            subcategoria = new SubCategoria();
            obj_categoria.CategoriaNome = "Aluguel";
            subcategoria.SubCategoriaNome = "Dinheiro";
            obj_categoria._SubCategoria = subcategoria;
            x.InsereCategoria(obj_categoria);

            obj_categoria = new Categoria();
            subcategoria = new SubCategoria();
            obj_categoria.CategoriaNome = "Transferencia";
            subcategoria.SubCategoriaNome = "Dinheiro";
            obj_categoria._SubCategoria = subcategoria;
            x.InsereCategoria(obj_categoria);

            obj_cliente.Nome = "Luis";
            x.IncluirCliente(obj_cliente);

            obj_Conta.Nome = "Conta Corrente";
            obj_Conta._Cliente = obj_cliente;
            x.InsereConta(obj_Conta);
            
            obj_Opera.Valor = 100.00;
            obj_Opera._Conta = obj_Conta;
            obj_Opera._Categoria = x.RetornaCategoria(1);
            x.RealizaDeposito(obj_Opera);

            Operacoes obj_Opera1 = new Operacoes();
            obj_Opera1.Valor = -83.42;
            obj_Opera1._Conta = obj_Conta;
            obj_Opera1._Categoria = x.RetornaCategoria(2);
            x.RealizaSaque(obj_Opera1);


            Operacoes obj_Opera2 = new Operacoes();
            obj_Opera2.Valor = 500.00;
            obj_Opera2._Conta = obj_Conta;
            obj_Opera2._Categoria = x.RetornaCategoria(1);
            x.RealizaDeposito(obj_Opera2);

            ///////////////////////////////////////////////////////////////////////////////////

            Cliente obj_cliente1 = new Cliente();
            obj_cliente1.Nome = "Alice";
            obj_cliente1.CPF = "06336799689";
            x.IncluirCliente(obj_cliente1);

            Conta obj_Conta1 = new Conta();
            obj_Conta1.Nome = "Poupanca";
            obj_Conta1._Cliente = obj_cliente1;
            x.InsereConta(obj_Conta1);

            Operacoes obj_opera3 = new Operacoes();
            obj_opera3.Valor = 300;
            obj_opera3._Conta = obj_Conta1;
            obj_opera3._Categoria = x.RetornaCategoria(1);
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
            emissor._Categoria = x.RetornaCategoria(3);
            destinatario._Categoria = emissor._Categoria;
            destinatario.Valor = emissor.Valor * -1;
            x.RealizaTransferencia(emissor, destinatario);


            obj_cliente1 = new Cliente();
            obj_cliente1 = x.RetornaCliente("06336799689");
            x.ExibirTodosLancamentosBancarios();
            x.ExibirTodosLancamentosBancarios(obj_cliente1);
            x.ExibirTodosLancamentosBancarios(1);
            x.ExibirTodosLancamentosBancarios(true);
            x.ExibirTodosLancamentosBancarios(false);
             */
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
            public Cliente RetornaCliente(string cpf)
            {
                try
                {
                    foreach (var item in clienteLista)
                    {
                        if (cpf.Equals(item.CPF))
                            return item;
                    }
                    return null;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                    return null;
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
            public Categoria RetornaCategoria(int idCategoria)
            {
                foreach (var item in ListaCategoria)
                {
                    if (item.IdCategoria == idCategoria)
                        return item;
                }
                return null;
            }

            /*List<SubCategoria> ListaSubCategoria = new List<SubCategoria>();
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
            public SubCategoria RetornaSubCategoria(int idCategoria)
            {
                foreach (var item in ListaSubCategoria)
                {
                    if (item.IdCategoria == idCategoria)
                        return item;
                }
                return null;
            }*/
            
            
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
                    if (_Emissor._Conta.Saldo > _Emissor.Valor)
                    {
                        foreach (var emissor in ListaContas)
                        {
                            if (emissor.Nome == _Emissor._Conta.Nome)
                            {
                                foreach (var destinatario in ListaContas)
                                {
                                    if (destinatario.Nome == _Destinatario._Conta.Nome)
                                    {
                                        InsereOperacao(_Emissor);
                                        InsereOperacao(_Destinatario);
                                        AtualizaSaldo(_Emissor);
                                        AtualizaSaldo(_Destinatario);
                                        break;
                                    }
                                    
                                }
                                break;
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
            public Conta Retornaconta(string nome, string conta)
            {
                foreach (var item in ListaContas)
                {
                    if (nome.Equals(item._Cliente.Nome) && conta.Equals(item.Nome))
                        return item;
                }
                return null;
            }
            private void AtualizaSaldo(Operacoes _opera)
            {
                int i = 0;

                if (_opera.Tipo.Equals("Receita"))
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

                Console.WriteLine("Data       |Cliente\t|Tipo    \t|Valor\t        |Categoria");
                Console.WriteLine("-------------------------------------------------------------------");
                
                foreach (var item in Lista)
                {
                    string data = item.DataHora.ToShortDateString() + " |";
                    string cliente = item._Conta._Cliente.Nome + "\t|";
                    string tipo = item.Tipo + " \t|";
                    string valor = item.Valor.ToString("C") + "\t|";
                    string _categoria = item._Categoria.CategoriaNome;

                    Console.WriteLine(data + cliente + tipo + valor + _categoria);
                }
            }
            public void ExibirTodosLancamentosBancarios(Cliente _cliente)
            {
                IEnumerable<Operacoes> Lista = from op in ListaOperacoes where op._Conta._Cliente == _cliente select op;

                Console.WriteLine("Data       |Cliente\t|Tipo    \t|Valor\t        |Categoria");
                Console.WriteLine("-------------------------------------------------------------------");

                foreach (var item in Lista)
                {
                    string data = item.DataHora.ToShortDateString() + " |";
                    string cliente = item._Conta._Cliente.Nome + "\t|";
                    string tipo = item.Tipo + " \t|";
                    string valor = item.Valor.ToString("C") + "\t|";
                    string _categoria = item._Categoria.CategoriaNome;

                    Console.WriteLine(data + cliente + tipo + valor + _categoria);
                }
            }
            public void ExibirTodosLancamentosBancarios(string Categoria)
            {
                IEnumerable<Operacoes> Lista = from op in ListaOperacoes where op._Categoria.CategoriaNome == Categoria select op;

                Console.WriteLine("Data       |Cliente\t|Tipo    \t|Valor\t        |Categoria");
                Console.WriteLine("-------------------------------------------------------------------");

                foreach (var item in Lista)
                {
                    string data = item.DataHora.ToShortDateString() + " |";
                    string cliente = item._Conta._Cliente.Nome + "\t|";
                    string tipo = item.Tipo + " \t|";
                    string valor = item.Valor.ToString("C") + "\t|";
                    string _categoria = item._Categoria.CategoriaNome;

                    Console.WriteLine(data + cliente + tipo + valor + _categoria);
                }
            }
            public void ExibirTodosLancamentosBancarios(DateTime inicio, DateTime fim)
            {
                IEnumerable<Operacoes> Lista = from op in ListaOperacoes where op.DataHora >= inicio && op.DataHora <= fim select op;

                Console.WriteLine("Data       |Cliente\t|Tipo    \t|Valor\t        |Categoria");
                Console.WriteLine("-------------------------------------------------------------------");

                foreach (var item in Lista)
                {
                    string data = item.DataHora.ToShortDateString() + " |";
                    string cliente = item._Conta._Cliente.Nome + "\t|";
                    string tipo = item.Tipo + " \t|";
                    string valor = item.Valor.ToString("C") + "\t|";
                    string _categoria = item._Categoria.CategoriaNome;

                    Console.WriteLine(data + cliente + tipo + valor + _categoria);
                }
            }
            /// <summary>
            /// Exibirá na tela os lancamentos de despesa ou receita.
            /// </summary>
            /// <param name="Tipo">True: Receita; False: Despesa</param>
            public void ExibirTodosLancamentosBancarios(bool Tipo)
            {
                IEnumerable<Operacoes> Lista;

                if (Tipo)
                {
                    Lista = from op in ListaOperacoes where op.Tipo  == "Receita" select op;
                }
                else
                    Lista = from op in ListaOperacoes where op.Tipo  == "Despesa" select op;


                Console.WriteLine("Data       |Cliente\t|Tipo    \t|Valor\t        |Categoria");
                Console.WriteLine("-------------------------------------------------------------------");

                foreach (var item in Lista)
                {
                    string data = item.DataHora.ToShortDateString() + " |";
                    string cliente = item._Conta._Cliente.Nome + "\t|";
                    string tipo = item.Tipo + " \t|";
                    string valor = item.Valor.ToString("C") + "\t|";
                    string _categoria = item._Categoria.CategoriaNome;

                    Console.WriteLine(data + cliente + tipo + valor + _categoria);
                }
            }
        }

        class Interface
        {
            Operacoes_Bancarias x = new Operacoes_Bancarias();
            ConsoleKeyInfo opcao;

            public Interface()
            {
                Cliente obj_cliente = new Cliente();
                Conta obj_Conta = new Conta();
                Operacoes obj_Opera = new Operacoes();


                Categoria obj_categoria = new Categoria();
                SubCategoria subcategoria = new SubCategoria();
                obj_categoria.CategoriaNome = "DEPOSITO";
                subcategoria.SubCategoriaNome = "DINHEIRO";
                obj_categoria._SubCategoria = subcategoria;
                x.InsereCategoria(obj_categoria);

                obj_categoria = new Categoria();
                subcategoria = new SubCategoria();
                obj_categoria.CategoriaNome = "ALUGUEL";
                subcategoria.SubCategoriaNome = "DINHEIRO";
                obj_categoria._SubCategoria = subcategoria;
                x.InsereCategoria(obj_categoria);

                obj_categoria = new Categoria();
                subcategoria = new SubCategoria();
                obj_categoria.CategoriaNome = "TRANSFERENCIA";
                subcategoria.SubCategoriaNome = "DINHEIRO";
                obj_categoria._SubCategoria = subcategoria;
                x.InsereCategoria(obj_categoria);

                obj_cliente.Nome = "LUIS";
                obj_cliente.CPF = "06336799689";
                x.IncluirCliente(obj_cliente);

                obj_Conta.Nome = "CONTA CORRENTE";
                obj_Conta._Cliente = obj_cliente;
                x.InsereConta(obj_Conta);

                obj_Opera.Valor = 100.00;
                obj_Opera._Conta = obj_Conta;
                obj_Opera._Categoria = x.RetornaCategoria(1);
                x.RealizaDeposito(obj_Opera);

                Operacoes obj_Opera1 = new Operacoes();
                obj_Opera1.Valor = -83.42;
                obj_Opera1._Conta = obj_Conta;
                obj_Opera1._Categoria = x.RetornaCategoria(2);
                x.RealizaSaque(obj_Opera1);


                Operacoes obj_Opera2 = new Operacoes();
                obj_Opera2.Valor = 500.00;
                obj_Opera2._Conta = obj_Conta;
                obj_Opera2._Categoria = x.RetornaCategoria(1);
                x.RealizaDeposito(obj_Opera2);

                ///////////////////////////////////////////////////////////////////////////////////

                Cliente obj_cliente1 = new Cliente();
                obj_cliente1.Nome = "ALICE";
                obj_cliente1.CPF = "07038656686";
                x.IncluirCliente(obj_cliente1);

                Conta obj_Conta1 = new Conta();
                obj_Conta1.Nome = "POUPANCA";
                obj_Conta1._Cliente = obj_cliente1;
                x.InsereConta(obj_Conta1);

                Operacoes obj_opera3 = new Operacoes();
                obj_opera3.Valor = 300;
                obj_opera3._Conta = obj_Conta1;
                obj_opera3._Categoria = x.RetornaCategoria(1);
                x.RealizaDeposito(obj_opera3);

                /////////////////////////////////////////////////////////////////////////////////////
                obj_Conta = new Conta();
                obj_Conta1 = new Conta();
                obj_Conta = x.Retornaconta("LUIS", "CONTA CORRENTE");
                obj_Conta1 = x.Retornaconta("ALICE", "POUPANCA");
                Operacoes emissor = new Operacoes();
                Operacoes destinatario = new Operacoes();
                emissor._Conta = obj_Conta;
                destinatario._Conta = obj_Conta1;
                emissor.Valor = -100;
                emissor._Categoria = x.RetornaCategoria(3);
                destinatario._Categoria = emissor._Categoria;
                destinatario.Valor = emissor.Valor * -1;
                x.RealizaTransferencia(emissor, destinatario);
            }
            
            
            public void MenuPrincipal()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                    Console.WriteLine("\t\t-----------------------------------");
                    Console.WriteLine("\t\t1 - Menu Administrador - Cliente");
                    Console.WriteLine("\t\t2 - Menu Administrador - Conta");
                    Console.WriteLine("\t\t3 - Menu Administrador - Transações");
                    Console.WriteLine("\t\t4 - Menu Administrador - Relatorios");
                    Console.WriteLine("\t\tESC - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': MenuCliente(); break;
                        case '2': MenuConta(); break;
                        case '3': MenuTransacoes(); break;
                        case '4': MenuRelatorios(); break;
                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.Escape);                
            }


            #region Relatorios
            public void MenuRelatorios()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                    Console.WriteLine("\t\t-----------------------------------");
                    Console.WriteLine("\t\t1 - Exibe Relatorio Geral");
                    Console.WriteLine("\t\t2 - Exibe Relatorio por Cliente");
                    Console.WriteLine("\t\t3 - Exibe Relatorio por Categoria ");
                    Console.WriteLine("\t\t4 - Exibe Relatorio por período");
                    Console.WriteLine("\t\t5 - Exibe Relatorio por Receita");
                    Console.WriteLine("\t\t6 - Exibe Relatorio por Despesa");
                    Console.WriteLine("\t\t7 - Exibe Saldo Cliente");
                    Console.WriteLine("\t\tF4 - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': ExibeRelatorioGeral(); break;
                        case '2': ExibeRelatorioPorCliente(); break;
                        case '3': ExibeRelatorioPorCategoria(); break;
                        case '4': ExibeRelatorioPorPeriodo(); break;
                        case '5': ExibeRelatorioPorReceita(); break;
                        case '6': ExibeRelatorioPorDespesa(); break;
                        case '7': ExibeSaldoCliente(); break;

                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.F4);
            }

            public void ExibeRelatorioGeral()
            {
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                x.ExibirTodosLancamentosBancarios();
                Console.ReadLine();
            }

            public void ExibeRelatorioPorCliente()
            {
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Cliente cli = new Cliente();
                Console.Write("\t\tCPF Titular: ");
                cli = x.RetornaCliente(Console.ReadLine().ToUpper());
                x.ExibirTodosLancamentosBancarios(cli);
                Console.ReadLine();
            }

            public void ExibeRelatorioPorCategoria()
            {
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tCategoria: ");
                string cat = Console.ReadLine();
                x.ExibirTodosLancamentosBancarios(cat);
                Console.ReadLine();
            }
            public void ExibeRelatorioPorPeriodo()
            {
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tInicio (dd/mm/aa): ");
                string inicio = Console.ReadLine();
                Console.Write("\t\\tFim (dd/mm/aa): ");
                string fim = Console.ReadLine();
                x.ExibirTodosLancamentosBancarios(DateTime.Parse(inicio), DateTime.Parse(fim));
                Console.ReadLine();
            }
            public void ExibeRelatorioPorReceita()
            {
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                x.ExibirTodosLancamentosBancarios(true);
                Console.ReadLine();
            }
            public void ExibeRelatorioPorDespesa()
            {
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                x.ExibirTodosLancamentosBancarios(false);
                Console.ReadLine();
            }

            public void ExibeSaldoCliente()
            {
                Conta cont = new Conta();
                Cliente cli = new Cliente();

                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tNome Titular: ");
                cli.Nome = Console.ReadLine().ToUpper();
                Console.Write("\t\tNome da conta: ");
                cont.Nome = Console.ReadLine().ToUpper();
                cont._Cliente = cli;
                cont = x.Retornaconta(cli.Nome, cont.Nome);
                if (cont != null)
                {
                    string data = DateTime.Now.ToShortDateString() + " |";
                    string nome = cont._Cliente.Nome + "\t|";
                    string saldo = cont.Saldo.ToString("c");
                    Console.Clear();
                    Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                    Console.WriteLine("\t\t----------------------------------\n\n");
                    Console.WriteLine("Data       |Cliente\t|Saldo");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(data + nome + saldo);                   
                }
                else
                    Console.WriteLine("Não há cliente ou conta cadastrada!");
                
                Console.ReadLine();
            }


            #endregion


            #region Transacoes
            public void MenuTransacoes()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                    Console.WriteLine("\t\t-----------------------------------");
                    Console.WriteLine("\t\t1 - Realiza Deposito");
                    Console.WriteLine("\t\t2 - Realiza Saque");
                    Console.WriteLine("\t\t3 - Realiza Transferencia");
                    Console.WriteLine("\t\tF4 - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': RealizaDeposito(); break;
                        case '2': RealizaSaque(); break;
                        case '3': RealizaTransferencia(); break;
                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.F4);
            }

            public void RealizaDeposito()
            {
                Operacoes op = new Operacoes();
                Conta cont = new Conta();
                Categoria cat = new Categoria();
                SubCategoria subcat = new SubCategoria();
                Cliente cli = new Cliente();

                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tNome Titular: ");
                cli.Nome = Console.ReadLine().ToUpper();
                Console.Write("\t\tNome da conta: ");
                cont.Nome = Console.ReadLine().ToUpper();
                cont._Cliente = cli;
                cont = x.Retornaconta(cont.Nome, cont._Cliente.Nome);
                if (cont != null)
                {
                    op._Conta = cont;
                    Console.Write("\t\tNome da Categoria: ");
                    cat.CategoriaNome = Console.ReadLine().ToUpper();
                    Console.Write("\t\tNome da SubCategoria: ");
                    subcat.SubCategoriaNome = Console.ReadLine().ToUpper();
                    Console.Write("\t\tValor da Operaçao: ");
                    op.Valor = double.Parse(Console.ReadLine());
                    op._Categoria = cat;
                    op._Categoria._SubCategoria = subcat;
                    x.RealizaDeposito(op);
                }
                else
                    Console.WriteLine("Não há cliente cadastrado");

                Console.ReadKey();
            }

            public void RealizaSaque()
            {
                Operacoes op = new Operacoes();
                Conta cont = new Conta();
                Categoria cat = new Categoria();
                SubCategoria subcat = new SubCategoria();
                Cliente cli = new Cliente();

                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tNome Titular: ");
                cli.Nome = Console.ReadLine().ToUpper();
                Console.Write("\t\tNome da conta: ");
                cont.Nome = Console.ReadLine().ToUpper();
                cont._Cliente = cli;
                cont = x.Retornaconta(cont.Nome, cont._Cliente.Nome);
                if (cont != null)
                {
                    op._Conta = cont;
                    Console.Write("\t\tNome da Categoria: ");
                    cat.CategoriaNome = Console.ReadLine().ToUpper();
                    Console.Write("\t\tNome da SubCategoria: ");
                    subcat.SubCategoriaNome = Console.ReadLine().ToUpper();
                    Console.Write("\t\tValor da Operaçao: ");
                    op.Valor = double.Parse(Console.ReadLine()) * -1;
                    op._Categoria = cat;
                    op._Categoria._SubCategoria = subcat;
                    x.RealizaSaque(op);
                }
                else
                    Console.WriteLine("Não há cliente cadastrado");

                Console.ReadKey();
            }

            public void RealizaTransferencia()
            {
                Operacoes op = new Operacoes();
                Conta cont = new Conta();

                Operacoes op1 = new Operacoes();
                Conta cont1 = new Conta();

                Categoria cat = new Categoria();
                SubCategoria subcat = new SubCategoria();

                Cliente cli = new Cliente();
                Cliente cli1 = new Cliente();

                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                
                Console.Write("\t\tNome Titular Emissor: ");
                cli.Nome = Console.ReadLine().ToUpper();
                Console.Write("\t\tNome da conta emitente: ");
                cont.Nome = Console.ReadLine().ToUpper();
                cont = x.Retornaconta(cli.Nome, cont.Nome);

                Console.Write("\t\tNome Titular Destinatario: ");
                cli1.Nome = Console.ReadLine().ToUpper();
                Console.Write("\t\tNome da conta destino: ");
                cont1.Nome = Console.ReadLine().ToUpper();
                cont1 = x.Retornaconta(cli1.Nome, cont1.Nome);
                
                if (cont != null && cont1!=null)
                {
                    op._Conta = cont;
                    op1._Conta = cont1;

                    Console.Write("\t\tNome da Categoria: ");
                    cat.CategoriaNome = Console.ReadLine().ToUpper();                    
                    Console.Write("\t\tNome da SubCategoria: ");
                    subcat.SubCategoriaNome = Console.ReadLine().ToUpper();
                    Console.Write("\t\tValor da Operaçao: ");

                    op._Categoria = cat;
                    op._Categoria._SubCategoria = subcat;

                    op1._Categoria = cat;
                    op1._Categoria._SubCategoria = subcat;

                    op.Valor = double.Parse(Console.ReadLine()) * -1;
                    op1.Valor = op.Valor * -1;

                    x.RealizaTransferencia(op, op1);
                }
                else
                    Console.WriteLine("Não há cliente cadastrado");

                Console.ReadKey();
            }
            #endregion

            
            
            #region Conta

            public void MenuConta()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                    Console.WriteLine("\t\t-----------------------------------");
                    Console.WriteLine("\t\t1 - Incluir conta");
                    Console.WriteLine("\t\tF4 - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': IncluirConta(); break;
                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.F4);
            }

            public void IncluirConta()
            {
                Cliente cli = new Cliente();
                
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tCPF: ");
                cli.CPF = Console.ReadLine();
                cli = x.RetornaCliente(cli.CPF);
                if (cli != null)
                {
                    Conta cont = new Conta();
                    Console.Write("\t\tNome da Conta: ");
                    cont.Nome = Console.ReadLine().ToUpper();
                    cont._Cliente = cli;
                    x.InsereConta(cont);
                }
                else
                    Console.WriteLine("Não há cliente cadastrado");
                Console.ReadKey();
            }
            
            #endregion

            
            
            #region Cliente

            public void MenuCliente()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                    Console.WriteLine("\t\t-----------------------------------");
                    Console.WriteLine("\t\t1 - Adicionar Cliente");
                    Console.WriteLine("\t\t2 - Alterar Cliente");
                    Console.WriteLine("\t\t3 - Excluir Cliente");                    
                    Console.WriteLine("\t\tF4 - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': InserirCliente(); break;
                        case '2': Alterarcliente(); break;
                        case '3': ExcluirCliente(); break;
                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.F4);                
            }

            public void InserirCliente()
            {
                Cliente cli = new Cliente();
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tNome: ");
                cli.Nome = Console.ReadLine().ToUpper();
                Console.Write("\t\tCPF: ");
                cli.CPF = Console.ReadLine();
                Console.Write("\t\tData de Nascimento (dd/mm/aaaa): ");
                cli.DataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("\t\tEndereco: ");
                cli.Logradouro = Console.ReadLine().ToUpper();
                Console.Write("\t\tNumero: ");
                cli.Numero = int.Parse(Console.ReadLine());
                Console.Write("\t\tBairro: ");
                cli.Bairro = Console.ReadLine().ToUpper();
                Console.Write("\t\tCidade: ");
                cli.Cidade = Console.ReadLine().ToUpper();
                Console.Write("\t\tUF: ");
                cli.UF = Console.ReadLine().ToUpper();
                x.IncluirCliente(cli);
            }

            public void Alterarcliente()
            {
                Cliente cli = new Cliente();
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tCPF: ");
                cli.CPF = Console.ReadLine();                
                cli = x.RetornaCliente(cli.CPF);
                Console.Write("\t\tNome: ");
                cli.Nome = Console.ReadLine().ToUpper();                
                Console.Write("\t\tData de Nascimento (dd/mm/aaaa): ");
                cli.DataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("\t\tEndereco: ");
                cli.Logradouro = Console.ReadLine().ToUpper();
                Console.Write("\t\tNumero: ");
                cli.Numero = int.Parse(Console.ReadLine());
                Console.Write("\t\tBairro: ");
                cli.Bairro = Console.ReadLine().ToUpper();
                Console.Write("\t\tCidade: ");
                cli.Cidade = Console.ReadLine().ToUpper();
                Console.Write("\t\tUF: ");
                cli.UF = Console.ReadLine().ToUpper();
                x.AlteraCliente(cli.CPF, cli);
            }

            public void ExcluirCliente()
            {
                Cliente cli = new Cliente();
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n");
                Console.Write("\t\tCPF: ");
                cli.CPF = Console.ReadLine();
                cli = x.RetornaCliente(cli.CPF);
                x.ExcluirCliente(cli.CPF);
            }
            
            #endregion 
        }
    }
}

