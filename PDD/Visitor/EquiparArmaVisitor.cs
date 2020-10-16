using PDD.Domain;
using PDD.FabricaLigera;
using PDD.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Visitor
{
    class EquiparArmaVisitor : IVisitorPersonaje
    {
        private ArmasFabricaLigera fabricaLigera;

        public EquiparArmaVisitor()
        {
            fabricaLigera = new ArmasFabricaLigera();
        }

        public void visit(Guerrero guerrero)
        {
            if (guerrero.Nivel < 5)
            {
                Console.WriteLine("Visitor solicita la Daga en la fabrica");
                guerrero.Arma = fabricaLigera.getArma("Daga");
                Console.WriteLine("Visitor asigna Daga a Guerrero");
            }
            else 
            {
                Console.WriteLine("Visitor solicita la Espada en la fabrica");
                guerrero.Arma = fabricaLigera.getArma("Espada");
                Console.WriteLine("Visitor asigna Espada a Guerrero");
            }
        }

        public void visit(Mago mago)
        {
            if (mago.Nivel < 10)
            {
                Console.WriteLine("Visitor solicita el arma Fuego en la fabrica");
                mago.Arma = fabricaLigera.getArma("Fuego");
                Console.WriteLine("Visitor asigna Fuego a Mago");
            }
            else
            {
                Console.WriteLine("Visitor solicita el arma Rayo en la fabrica");
                mago.Arma = fabricaLigera.getArma("Rayo");
                Console.WriteLine("Visitor asigna Rayo a Mago");
            }
        }

        public void visit(List<IPersonaje> list)
        {
            foreach (IPersonaje p in list) 
            {
                p.Accept(this);
            }
        }
    }
}
