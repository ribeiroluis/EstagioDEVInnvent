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

            Conta obj_Conta = new Conta();
            Operacoes obj_Opera = new Operacoes();
            Cliente obj_cliente = new Cliente();

            List<Cliente> clienteLista = new List<Cliente>();
            obj_cliente.Nome = "Luis";
            obj_cliente.IncluirCliente(obj_cliente);

            obj_Conta.Nome = "Conta Corrente";
            obj_Conta._Cliente = obj_cliente;
            obj_Conta.InsereConta(obj_Conta);

            obj_Opera.Valor = 100.00;
            obj_Opera._Conta = obj_Conta;
            obj_Conta.RealizaDeposito(obj_Opera);

            obj_Opera.Valor = -83.42;
            obj_Opera._Conta = obj_Conta;
            obj_Conta.RealizaSaque(obj_Opera);
            Console.ReadKey();

        }
    }
}
