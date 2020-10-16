using PDD.Constructor;
using PDD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.FabricaLigera
{
    class ArmasFabricaLigera
    {
        private DirectorConstructorArma director;
        private List<Arma> armas;

        public ArmasFabricaLigera() 
        {
            director = new DirectorConstructorArma();
            armas = new List<Arma>();
        }

        public Arma getArma(String nombre)
        {
            foreach (Arma arma in armas) 
            {
                if (arma.Nombre.Equals(nombre))
                {
                    Console.WriteLine(" - El arma " + nombre + " ya existe");
                    Console.WriteLine(" - Se obtiene el arma de la lista");
                    return arma;
                }
            }

            ConstructorArma constructor;
            switch (nombre)
            {
                case "Daga":
                    constructor = new ConstructorArmaDaga();
                    director.Construir(constructor);
                    break;

                case "Espada":
                    constructor = new ConstructorArmaEspada();
                    break;

                case "Fuego":
                    constructor = new ConstructorArmaFuego();
                    break;

                case "Rayo":
                    constructor = new ConstructorArmaRayo();
                    break;

                default:
                    return null;
            }

            Console.WriteLine(" - El arma " + nombre + " no existe");
            Console.WriteLine(" - Se crea el arma y se añade a la lista");
            director.Construir(constructor);
            armas.Add(constructor.GetArma());
            return constructor.GetArma();
        }
    }
}
