using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.NumBanco = 01;

            Cliente cliente = new Cliente();
            cliente.Nome = "Tobias Furtado";
            cliente.Cpf = 11111111111;

            Conta conta = new Conta();
            conta.Banco = banco;
            conta.Cliente = cliente;
            conta.NumConta = 10098483;
            conta.NumAgencia = 1960;

            banco.setConta(conta);
            cliente.setConta(conta);


            cliente.ListarContas();
            Console.Read();
        }
    }
}
