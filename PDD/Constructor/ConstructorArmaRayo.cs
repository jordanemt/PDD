using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Constructor
{
    class ConstructorArmaRayo : ConstructorArma
    {
        public override void ConstruirDanno()
        {
            this.arma.Danno = 10;
        }

        public override void ConstruirNombre()
        {
            this.arma.Nombre = "Rayo";
        }
    }
}
