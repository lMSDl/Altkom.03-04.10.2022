using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    //klasa abstrakcyjna - nie można utworzć instancji tej klasy
    //każda klasa niejawnie dziedziczy po Object
    public abstract class Shape /*: Object*/
    {
        //read-only property - brak settera, możliwość ustawienia wartości tylko w konstruktorze
        private string Name { get; }
        //protected - pozwala na dostęp w klasach pochodnych, ale nie pozwala na dostęp z zewnątrz
        public string Description { get; protected set; }

        public Shape(string name)
        {
            Name = name;
        }

        //override - pozwala na nadpisywanie/zmianę kodu sanej metody
        public override string ToString()
        {
            return Name;
        }

        public void SomeMethod()
        {

        }
        //metoda virtualna - posiada zachowanie (czyli jakąś bazową implementację), ale możemy je zmienić w klasach pochodnych
        public virtual void SomeVirtualMethod()
        {

        }
        //metoda abstrakcyjna - nie posiada ciała i MUSI mieć implementację w klasach pochodnych
        //Jeśli klasa posiada metodę abstrakcyjną to sama klasa też musi być abstrakcyjna
        public abstract void SomeAbstractMethod();
    }
}
