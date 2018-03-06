using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Banco
    {
        private int numBanco;
        private List<Conta> contas = new List<Conta>();

        #region Encapsulamentos
        public int NumBanco
        {
            get
            {
                return numBanco;
            }

            set
            {
                numBanco = value;
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
            foreach (Conta conta in contas)
                Console.WriteLine(conta.NumConta);
        }

        public void ListarContas(long numAgencia)
        {
            foreach (Conta conta in contas)
                if (conta.NumAgencia == numAgencia)
                    Console.WriteLine(conta.NumConta);
        }

        public double AprovarLimite(double valor, int tempoConta)
        {
            if (valor < 0)
                valor = 0;

            if (tempoConta < 0)
                tempoConta = 0;

            return Math.Min(valor, (200+300*tempoConta));
        }
    }
}
