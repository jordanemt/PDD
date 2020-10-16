using PDD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Constructor
{
    abstract class ConstructorArma
    {
        protected Arma arma;

        public Arma GetArma()
        {
            return arma;
        }

        public void CrearArma()
        {
            arma = new Arma();
        }

        public abstract void ConstruirNombre();
        public abstract void ConstruirDanno();
    }
}
