using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Conta
    {
        private long numConta;
        private long numAgencia;
        private double saldo;
        private long senha;
        private double limite;
        private int tempoConta;
        private Cliente cliente;
        private Banco banco;

        #region Encapsulamentos
        public long NumConta
        {
            get
            {
                return numConta;
            }

            set
            {
                numConta = value;
            }
        }

        public long NumAgencia
        {
            get
            {
                return numAgencia;
            }

            set
            {
                numAgencia = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public long Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public double Limite
        {
            get
            {
                return limite;
            }

            set
            {
                limite = value;
            }
        }

        public int TempoConta
        {
            get
            {
                return tempoConta;
            }

            set
            {
                tempoConta = value;
            }
        }

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        internal Banco Banco
        {
            get
            {
                return banco;
            }

            set
            {
                banco = value;
            }
        }
        #endregion

        public bool Sacar(double valor, long senha)
        {
            if (valor >= 0)
                if (senha == this.senha)
                    return true;

            return false;
        }

        public void Depositar(double valor)
        {
            if (valor >= 0)
                saldo += valor;
        }

        public double SolicitarLimite(double valor, long senha)
        {
            return senha == this.senha ? limite : -1;
        }
    }
}
