using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Cachorro
    {
        private string nome, raca;
        private bool vacinado = false;

        public Cachorro(string nome, string raca)
        {
            this.Nome = nome;
            this.Raca = raca;
        }

        public Cachorro(string nome, string raca, bool vacinado)
        {
            this.Nome = nome;
            this.Raca = raca;
            this.Vacinado = vacinado;
        }

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

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        public bool Vacinado
        {
            get
            {
                return vacinado;
            }

            set
            {
                vacinado = value;
            }
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + ". Raça: " + this.Raca + ". Vacinado: " + (this.Vacinado ? "Sim" : "Não");
        }
    }
}
