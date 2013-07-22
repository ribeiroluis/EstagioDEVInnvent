using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Cliente
    {
        List<Cliente> clienteLista = new List<Cliente>();

        public Cliente(List<Cliente> _ClienteLista)
        {
            clienteLista = _ClienteLista;
        }

        public List<Cliente> IncluirCliente(Cliente _novoCliente)
        {
            try
            {
                clienteLista.Add(_novoCliente);
                Console.WriteLine("Cliente Inserido com Sucesso..");
                return clienteLista;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return clienteLista;
            }
        }

        public List<Cliente> ExcluirCliente(string _cpfCliente)
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
                return clienteLista;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return clienteLista;
            }
        }

        public List<Cliente> AlteraCliente(string _cpfCliente, Cliente _clienteAlterado)
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
                return clienteLista;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return clienteLista;
            }
        }

        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }



    }
}
