using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Pessoa
    {
        private string nome;
        private long cpf;
        private List<Cachorro> cachorros = new List<Cachorro>();

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public void AddCachorro(Cachorro cachorro)
        {
            this.cachorros.Add(cachorro);
        }

        public List<Cachorro> GetCachorros()
        {
            return this.cachorros;
        }

        public bool RmvCachorro(string nomeCachorro)
        {
            foreach (Cachorro cachorro in cachorros)
            {
                if (cachorro.Nome == nomeCachorro)
                {
                    cachorros.Remove(cachorro);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + ". CPF: " + this.Cpf;
        }
    }
}
