//napespace - przestrzeń nazw, czylki adres pod którym "mieszka" klasa
namespace Models
{
    //class - opisuje zachowania i wartości obiektów (instancje klas), które na jej podstawie są wytwarzane
    //pełna nazwa klasy: namespace + nazwa klasy
    //public - modyfikator dostępu: klasa dostępna jest wszędzie
    public class Item
    {/*
        //private - modyfikator dostępu: dostęp jest tylko w obrębie klasy
        //brak modyfikatora dostępu = private
        private string name;

        //setter - do ustawiania wartości pola
        public void SetName(string value)
        {
            name = value;
        }
        //getter do pobierania wartości pola
        public string GetName()
        {
            //return - return kończy metodę i zwraca wartość (obowiązkowy, gdy metoda nie jest void)
            return name;
        }

        private int quantity;
        public void SetQuantity(int value)
        {
            quantity = value;
        }
        public int GetQuantity()
        {
            return quantity;
        }
*/
        //back-filed dla full-property
        private int quantity;

        //właściwość
        //auto-property
        //private - opcjonalna zmiana poziomu dostępu do gettera albo settera. Możliwość tylko ograniczania poziomu dostępu.
        public string Name { get; /*private*/ set; }

        //full-property
        public int Quantity
        {
            get { 
                return quantity;
            }
            //setter posiada niejany parametr o nazwie value
            set
            {
                if(value > 0)
                    quantity = value;
            }
        }
    }
}