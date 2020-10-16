using PDD.Domain;
using PDD.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Fabrica
{
    class PersonajeFabrica
    {
        public const int GUERRERO = 1;
        public const int MAGO = 2;

        public PersonajeFabrica()
        {
        }

        public static IPersonaje GetPersonaje(int tipo)
        {
            IPersonaje personaje;

            switch (tipo)
            {
                case GUERRERO:
                    personaje = new Guerrero();
                    Console.WriteLine("Se ha creado un guerrero");
                    break;

                case MAGO:
                    personaje = new Mago();
                    Console.WriteLine("Se ha creado un mago");
                    break;

                default:
                    personaje = null;
                    break;
            }

            return personaje;
        }
    }
}
