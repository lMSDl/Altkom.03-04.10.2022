using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    //sealed - zapieczętowanie klasy - nie można po niej dziedziczyć
    public sealed class Point : Shape1D
    {
        public Point() : base("Punkt", 1)
        {
        }
    }

    //niemożliwe dziedziczenie
    /*public class SuperPoint : Point
    {

    }*/
}
