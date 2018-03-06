using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Cliente
    {
        private string nome;
        private long cpf;
        private List<Conta> contas = new List<Conta>();

        #region Encapsulamentos
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

        internal List<Conta> Contas
        {
            get
            {
                return contas;
            }

            set
            {
                contas = value;
            }
        }
        #endregion

        public void ListarContas()
        {
            foreach(Conta conta in contas)
                Console.WriteLine(conta.NumConta);
        }
    }
}
