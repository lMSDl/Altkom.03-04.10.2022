
using Models;

//new - wytworzenie nowego obiektu. Używa konstruktowa wskazanej klasy
var item1 = new Item();
item1.Name = "mleko";
item1.Quantity = 2;

//używamy konstruktora z parametrem
var item2 = new Item("masło"); //konstruktor zapewnia, że quantity jest ustawione na 1

//używamy konstruktora bezparametrowego i inicjalizator (w nawiasach klmrowych)
var item3 = new Item() { Name = "chleb", Quantity = 1 };

/*var car = new Car(1, 2, 3, 4, 5, 6);
car = new Car() { Doors = 2, Seats = 3, EnginePower = 400, Wheels = 4, Windows = 4, TrunkCapacity = 200 };*/