using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            double areaTot = 0;

            //Instancia as figuras
            for (int contador = 0; contador < 50; contador++)
            {
                figuras.Add(new Circulo(contador, contador, contador));
                figuras.Add(new Retangulo(contador, contador, contador, contador));
                figuras.Add(new TrianguloRetangulo(contador, contador, contador, contador));
            }

            foreach (Figura figura in figuras)
            {
                areaTot += figura.Area();
            }

            Console.WriteLine("Area total das figuras: " + areaTot);

            Console.Read();
        }
    }
}
