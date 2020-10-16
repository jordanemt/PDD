using PDD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDD.Interface
{
    interface IVisitorPersonaje
    {
        public void visit(Guerrero guerrero);
        public void visit(Mago mago);
        public void visit(List<IPersonaje> list);
    }
}
