using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Constructor
{
    class ConstructorArmaFuego : ConstructorArma
    {
        public override void ConstruirDanno()
        {
            this.arma.Danno = 5;
        }

        public override void ConstruirNombre()
        {
            this.arma.Nombre = "Fuego";
        }
    }
}
