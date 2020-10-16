using PDD.Domain;
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
            Guerrero guerrero = new Guerrero();
            Mago mago = new Mago();
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

            guerrero.Nivel = 5;
            mago.Nivel = 5;
            Console.WriteLine("Guerrero y Mago suben a nivel 5");
            Console.WriteLine("====================");
            Console.ReadLine();

            visitor.visit(personajes);
            Console.WriteLine("====================");
            Console.ReadLine();

            guerrero.Atacar();
            mago.Atacar();
            Console.WriteLine("====================");
            Console.ReadLine();

            mago.Nivel = 10;
            Console.WriteLine("Mago sube a nivel 10");
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
