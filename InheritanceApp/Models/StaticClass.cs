using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public static class StaticClass
    {
        public static string Name { get; set; }
        public static void ShowName() { Console.WriteLine(Name);  }
    }

    //klasa nie może dziedziczyć po klsie statycznej
    /*public class SuperClass : StaticClass
    {

    }*/

    //klasa statyczna nie może dziedziczyć po żandej klasie
    /*public static class SuperStaticClass : Shape
    {

    }*/
}
