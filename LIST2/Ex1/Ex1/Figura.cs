using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    abstract class Figura
    {
        private int x, y;

        public Figura(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //O modificador 'virtual' indica que o método pode ser
        //sobrescrito por subclasses desta classe.
        //SÓ QUE NÃO TEM MAIS VIRTUAL NE AMIGUINHO
        abstract public double Area();

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}
