using PDD.Domain;
using PDD.Fabrica;
using PDD.Interface;
using PDD.Visitor;
using System;
using System.Collections.Generic;

namespace PDD
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonaje guerrero = PersonajeFabrica.GetPersonaje(PersonajeFabrica.GUERRERO);
            IPersonaje mago = PersonajeFabrica.GetPersonaje(PersonajeFabrica.MAGO);
            Console.WriteLine("====================");
            Console.ReadLine();

            guerrero.Atacar();
            mago.Atacar();
            Console.WriteLine("====================");
            Console.ReadLine();

            List<IPersonaje> personajes = new List<IPersonaje>();
            personajes.Add(guerrero);
            personajes.Add(mago);

            IVisitorPersonaje visitor = new EquiparArmaVisitor();
            visitor.visit(personajes);
            Console.WriteLine("====================");
            Console.ReadLine();

            guerrero.Atacar();
            mago.Atacar();
            Console.WriteLine("====================");
            Console.ReadLine();

            guerrero.SetNivel(6);
            mago.SetNivel(6);
            Console.WriteLine("====================");
            Console.ReadLine();

            visitor.visit(personajes);
            Console.WriteLine("====================");
            Console.ReadLine();

            guerrero.Atacar();
            mago.Atacar();
            Console.WriteLine("====================");
            Console.ReadLine();
        }
    }
}
