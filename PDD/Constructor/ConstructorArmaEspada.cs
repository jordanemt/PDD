using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Constructor
{
    class ConstructorArmaEspada : ConstructorArma
    {
        public override void ConstruirDanno()
        {
            this.arma.Danno = 7;
        }

        public override void ConstruirNombre()
        {
            this.arma.Nombre = "Espada";
        }
    }
}
