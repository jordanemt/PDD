using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Interface
{
    interface IPersonaje
    {
        public void Atacar();
        public void Accept(IVisitorPersonaje visitor);
    }
}
