using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Constructor
{
    class ConstructorArmaDaga : ConstructorArma
    {
        public override void ConstruirDanno()
        {
            this.arma.Danno = 3;
        }

        public override void ConstruirNombre()
        {
            this.arma.Nombre = "Daga";
        }
    }
}
