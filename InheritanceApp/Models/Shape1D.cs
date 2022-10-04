using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    //: - oznacza dziedziczenie
    public abstract class Shape1D : Shape
    {
        //base - wywołanie konstruktora klasy bazowej
        public Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        public int Width { get;  }

        public override string ToString()
        {
            return $"{base.ToString()}; szerokość: {Width}";
        }

        //nadpisywać możemy tylko metody virtual lub abstract
        public override void SomeVirtualMethod()
        {
            base.SomeVirtualMethod();
        }
        public override void SomeAbstractMethod()
        {
            throw new NotImplementedException();
        }
    }
}
