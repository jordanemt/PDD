using PDD.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Domain
{
    class Guerrero : IPersonaje
    {
        public Arma Arma { get; set; }

        public int Nivel { get; set; }

        public Guerrero() 
        {
            Nivel = 1;
            Console.WriteLine("Guerrero fue creado");
        }

        public void Atacar()
        {
            if (Arma == null)
            {
                Console.WriteLine("Guerrero ataca con las manos desnudas, inflinge " + Nivel + " de daño");
            }
            else
            {
                Console.WriteLine("Guerrero ataca con " + Arma.Nombre + ", inflinge " + (Nivel * Arma.Danno) + " de daño");
            }
        }

        public void Accept(IVisitorPersonaje visitor)
        {
            Console.WriteLine("Visitor visita Guerrero");
            visitor.visit(this);
        }
    }
}
