using PDD.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Domain
{
    class Mago : IPersonaje
    {
        public Arma Arma { get; set; }

        public int Nivel { get; set; }

        public Mago()
        {
            Nivel = 1;
        }

        public void Atacar()
        {
            if (Arma == null)
            {
                Console.WriteLine("Mago ataca con las manos desnudas, inflinge " + Nivel + " de daño");
            }
            else
            {
                Console.WriteLine("Mago ataca con " + Arma.Nombre + ", inflinge " + (Nivel * Arma.Danno) + " de daño");
            }
        }

        public void SetNivel(int nivel)
        {
            Nivel = nivel;
            Console.WriteLine("El nivel del Mago aumenta a " + Nivel);
        }

        public void Accept(IVisitorPersonaje visitor)
        {
            Console.WriteLine("Visitor visita Mago");
            visitor.visit(this);
        }
    }
}
