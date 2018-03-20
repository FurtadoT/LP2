using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class PetShop
    {
        Dictionary<long, Pessoa> hashClientes = new Dictionary<long, Pessoa>();

        public void AddPessoa(Pessoa pessoa)
        {
            hashClientes.Add(pessoa.Cpf, pessoa);
        }

        public List<Pessoa> GetPessoas()
        {
            return new List<Pessoa>(hashClientes.Values);
        }

        public bool AddCachorro(long cpf, Cachorro cachorro)
        {
            if (hashClientes.ContainsKey(cpf))
            {
                hashClientes[cpf].AddCachorro(cachorro);
                return true;
            }

            return false;
        }

        public void Listar()
        {
            foreach(Pessoa cliente in hashClientes.Values)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

        public void ListarCachorros()
        {
            foreach(Pessoa cliente in hashClientes.Values)
            {
                foreach(Cachorro cachorro in cliente.GetCachorros())
                {
                    Console.WriteLine(cachorro.ToString());
                }
            }
        }

        public bool RmvPessoa(long cpf)
        {
            if (hashClientes.ContainsKey(cpf))
            {
                hashClientes.Remove(cpf);
                return true;
            }

            return false;
        }
        public bool RmvCachorro(long cpf, string nomeCachorro)
        {
            if (hashClientes.ContainsKey(cpf))
            {
                hashClientes[cpf].RmvCachorro(nomeCachorro);
            }

            return false;
        }

        public void ListarVacinados(bool vacinados)
        {
            foreach(Pessoa pessoa in hashClientes.Values)
            {
                foreach(Cachorro cachorro in pessoa.GetCachorros())
                {
                    if (cachorro.Vacinado == vacinados)
                        Console.WriteLine(cachorro.ToString());
                }
            }
        }

        public void ListarVacinados(bool vacinados, long cpf)
        {
            foreach (long cpfAux in hashClientes.Keys)
            {
                if (cpfAux == cpf)
                {
                    foreach (Cachorro cachorro in hashClientes[cpf].GetCachorros())
                    {
                        if (cachorro.Vacinado == vacinados)
                            Console.WriteLine(cachorro.ToString());
                    }
                }
            }
        }
    }
}
