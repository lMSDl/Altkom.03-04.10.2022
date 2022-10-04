
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

var items = new List<Item>() { item1, item2, item3 };

var working = true;
while (working)
{
    ShowListItems(items);
    var option = ReadUserOption();
    
    switch(option)
    {
        case 1:
            Add(items);
            break;
        case 2:
            Delete2(items);
            break;
        case 0:
            working = false;
            break;
    }
}

void Add(List<Item> items)
{
    var item = new Item();

    do
    {
        Console.Write("Podaj nazwę produktu: ");
        item.Name = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(item.Name));

    do
    {
        Console.Write("Podaj ilość: ");
        var quantity = Console.ReadLine();
        item.Quantity = ParseUserInputToInt(quantity);
    } while (item.Quantity == 0);

    items.Add(item);
}

void Delete(List<Item> list)
{
    Console.Write("Podaj pozycję do usunięcia: ");
    var input = Console.ReadLine();
    var index = ParseUserInputToInt(input) - 1;
    if(index < list.Count && index >= 0)
        list.RemoveAt(index);
}

void Delete2(List<Item> list)
{
    Console.Write("Podaj nazę produktu do usunięcia: ");
    var name = Console.ReadLine();

    Item itemToDelete = null;
    foreach (var item in list)
    {
        if (item.Name != name)
        {
            continue;
        }
        itemToDelete = item;
        break;
    }

    list.Remove(itemToDelete);
}


int ReadUserOption()
{
    // \n - znak nowje linii
    Console.WriteLine("\n1. Dodaj\n2. Usuń\n0. Koniec");
    var inputKey = Console.ReadKey();
    Console.WriteLine();
    return ParseUserInputToInt(inputKey.KeyChar.ToString());
}



void ShowListItems(List<Item> items)
{
    /*var enumerator = items.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var item = enumerator.Current;
        Console.WriteLine($"{item.Name} {item.Quantity}");
    }

    for (var i = 0; i < items.Count; i++)
    {
        var item = items[i];
        Console.WriteLine($"{item.Name} {item.Quantity}");
    }*/

    // foreach - pętla przechodząca po każdym elemencie kolekcji (lista lub tablica)
    // foreach([typ i nazwa zmiennej] in [kolekcja])
    Console.Clear();
    foreach (var item in items)
    {
        Console.WriteLine($"{item.Name} {item.Quantity}");
    }
}

int ParseUserInputToInt(string input)
{
    /*try
        {
            return int.Parse(input);
        }
        catch
        {
            return -1;
        }*/

    int result = -1;
    //TryParse - posiada paramert wyjściowy (out). Jest to sposób na zwrócenie z metody więcej niż jednego rezultatu
    //metoda ta zwraca informację o tym, czy da się sparsować podany parametr, jeśli tak to w parametrze wyjściowym umieszcza wynik parsowania
    if (int.TryParse(input, out result))
        return result;

    return -1;
}