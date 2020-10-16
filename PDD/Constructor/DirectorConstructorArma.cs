using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Constructor
{
    class DirectorConstructorArma
    {
        public DirectorConstructorArma() { }

        public void Construir (ConstructorArma constructor) 
        {
            constructor.CrearArma();

            constructor.ConstruirNombre();
            constructor.ConstruirDanno();
        }
    }
}
