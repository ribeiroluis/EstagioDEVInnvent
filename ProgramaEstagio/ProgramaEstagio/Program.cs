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
            //Operacoes_Bancarias x = new Operacoes_Bancarias();
            Interface tela = new Interface();
            tela.MenuPrincipal();
            
            
            
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
            public void ExibirTodosLancamentosBancarios(int idCategoria)
            {
                IEnumerable<Operacoes> Lista = from op in ListaOperacoes where op._Categoria.IdCategoria == idCategoria select op;

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
                    Console.WriteLine("\t\tESC - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': MenuCliente(); break;
                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.Escape);                
            }



            #region Transacoes


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
                    Console.WriteLine("\t\tESC - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': InserirCliente(); break;
                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.Escape);
            }

            public void IncluirConta()
            {
                Cliente cli = new Cliente();
                
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n-");
                Console.Write("\t\tCPF: ");
                cli.CPF = Console.ReadLine();
                cli = x.RetornaCliente(cli.CPF);
                Conta cont = new Conta();
                Console.Write("\t\tNome da Conta: ");
                cont.Nome = Console.ReadLine().ToUpper();
                cont._Cliente = cli;
                x.InsereConta(cont);


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
                    Console.WriteLine("\t\tESC - Sair");
                    opcao = Console.ReadKey();
                    switch (opcao.KeyChar)
                    {
                        case '1': InserirCliente(); break;
                        case '2': Alterarcliente(); break;
                        case '3': ExcluirCliente(); break;
                        default:
                            break;
                    }
                } while (opcao.Key != ConsoleKey.Escape);                
            }

            public void InserirCliente()
            {
                Cliente cli = new Cliente();
                Console.Clear();
                Console.WriteLine("\t\tSistema Bancário - Estágio Innvent");
                Console.WriteLine("\t\t----------------------------------\n\n-");
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
                Console.WriteLine("\t\t----------------------------------\n\n-");
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
                Console.WriteLine("\t\t----------------------------------\n\n-");
                Console.Write("\t\tCPF: ");
                cli.CPF = Console.ReadLine();
                cli = x.RetornaCliente(cli.CPF);
                x.ExcluirCliente(cli.CPF);
            }
            
            #endregion 
        }
    }
}

