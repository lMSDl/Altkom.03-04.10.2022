using Models;
using System;
using System.Diagnostics;
using System.Globalization;

int a = 5;
Console.WriteLine(a);
Test(a);
Console.WriteLine(a);

var item = new Item();
item.Quantity = 2;

Console.WriteLine(item.Quantity);
TestItem(item);
Console.WriteLine(item.Quantity);

var itemStruct = new ItemStruct();
itemStruct.Quantity = 2;
Console.WriteLine(itemStruct.Quantity);
TestItemStruct(itemStruct);
Console.WriteLine(itemStruct.Quantity);


void Test(int a)
{
    a = 7;
}

void TestItem(Item a)
{
    a.Quantity = 7;
}

void TestItemStruct(ItemStruct a)
{
    a.Quantity = 7;
}


void Exceptions()
{
    while (true)
    {
        var input = Console.ReadLine();

        //try - blok który jest monitorowany pod względem wystąpienia błędu
        try
        {
            var intValue = int.Parse(input);

            if (intValue == 0)
                throw new Exception("Something wrong");
            Console.WriteLine(intValue);
        }
        //catch - blok obsługi błędów danego typu
        catch (FormatException)
        {
            Console.WriteLine("Błędny format");
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
        }
        //finally - blok wykona się zawsze po try i po cache
        finally
        {
            Console.WriteLine();
        }
    }
}

void Loops()
{
    bool exit = true;
    while (!exit)
    {
        Strings();

        //var - typ zmiennej określany na podstawie wyniku prawej strony przypisania
        var input = Console.ReadLine();
        if (input == "exit")
        {
            exit = true;
        }
        else if (input == "break")
        {
            break;
        }
    }

    exit = true;
    do
    {
        Strings();

        //var - typ zmiennej określany na podstawie wyniku prawej strony przypisania
        var input = Console.ReadLine();
        if (input == "exit")
        {
            exit = true;
        }
        else if (input == "break")
        {
            break;
        }
    } while (exit);

    //for([1], [2][5][8][11], [4][7][10]) { [3][6][9] }

    // [1] inicjalizacja 
    // [2] sprawdzenie warunku
    // [3] wykonanie ciała pętli
    // [4] inkrementacja

    for (var i = 0; i < 3; /*i = i+1*/ i++)
    {
        Console.WriteLine(i);
    }

    for (int i = 0, j = 5; i < 5 || j > 0; i = j - i)
    {
        Console.WriteLine(i);
        j = i - j;
    }


    //warunek nie jest wpisany - pętla nieskończona
    for (int i = 0; ; i++)
    {
        if (i % 2 == 0)
            //przewanie wykonywania ciała, ale nie przerywa pętli
            continue;
        if (i > 100)
            //przewanie wykonywania ciała i pętli
            break;
        Console.WriteLine(i);
    }


}


void Conditions()
{

    int value = int.Parse(Console.ReadLine());
    int calculatedValue = value % 2;
    if (calculatedValue == 0)
    {
        Console.WriteLine("Wartość jest podzielna przez 2");
    }
    else
    {
        Console.WriteLine($"Reszta z dzielenia przez 2 to {calculatedValue}");
    }

    if (value > 0)
    {
        Console.WriteLine($"Wartość jest większa od 0");
    }
    if (value < 0)
    {
        Console.WriteLine($"Wartość jest mniejsza od 0");
    }
    //if (value <= 0)
    // || - lub
    if (value < 0 || value == 0)
    {
        Console.WriteLine($"Wartość jest mniejsza lub równa 0");
    }
    if (value >= 0)
    {
        Console.WriteLine($"Wartość jest więszka lub równa 0");
    }
    //if (value == 0)
    // && - i
    // ! - negacja
    if (!(value < 0) && !(value > 0))
    {
        Console.WriteLine($"Wartość jest równa 0");
    }

    if (calculatedValue > value)
    {
        Console.WriteLine("calculatedValue > value");
    }
    else if (calculatedValue < value)
    {
        Console.WriteLine("calculatedValue < value");
    }
    else
    {
        Console.WriteLine("calculatedValue == value");
    }


    string stringValue = Console.ReadLine();


    //if wybiera sprawdzając po kolei warunki
    if (stringValue == "exit")
    {
        Console.WriteLine("Bye!");
    }
    else if (stringValue == "o/")
    {
        // ukośnik opadający to oznaczenie znaku specjalnego
        // @ wyłącza rozpoznawanie znaków specjalnych
        Console.WriteLine(@"\o");
        // \t - znak tabulatora
        Console.WriteLine("\to");
        // \\ - znakiem specjalnym jest sam ukośnik opadający
        Console.WriteLine("\\o");
    }
    else if (stringValue.Equals("Paul", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("Wpisałeś swoje imię");
    }
    else
    {
        Console.WriteLine(stringValue);
    }

    //switch wybiera na podstawie dopasowania wzorca 
    switch (stringValue)
    {
        case "exit":
            Console.WriteLine("Bye!");
            break;
        case "o/":
            Console.WriteLine("\\o");
            break;
        case "Paul":
        case "paul":
            Console.WriteLine("Wpisałeś swoje imię");
            break;
        default:
            Console.WriteLine(stringValue);
            break;
    }

}



void Numebrs()
{
    int a = 20;
    int b = 8;
    int c = a + b;
    Console.WriteLine(c);
    c = a - b;
    Console.WriteLine(c);
    c = a * b;
    Console.WriteLine(c);
    c = a / b;
    Console.WriteLine(c);
    //reszta z dzielenia
    c = a % b;
    Console.WriteLine(c);


    c = a + a * a;
    Console.WriteLine(c);
    c = (a + a) * a;
    Console.WriteLine(c);


    float aa = 20f;
    float bb = 8f;
    float cc = aa / bb;
    Console.WriteLine(cc);
    cc = a / bb;
    Console.WriteLine(cc);

    Console.WriteLine(5 / 3);
    Console.WriteLine(5 / 3f);

    string stringA = a.ToString();
    string stringB = b.ToString();
    Console.WriteLine(stringA + stringB);

    Console.WriteLine($"short max:{short.MaxValue} min:{short.MinValue}");
    Console.WriteLine($"int max:{int.MaxValue} min:{int.MinValue}");
    Console.WriteLine($"long max:{long.MaxValue} min:{long.MinValue}");
    Console.WriteLine($"float max:{float.MaxValue} min:{float.MinValue}");
    Console.WriteLine($"double max:{double.MaxValue} min:{double.MinValue}");
    Console.WriteLine($"decimal max:{decimal.MaxValue} min:{decimal.MinValue}");


    Console.WriteLine(5 / 3.0f);
    //double
    Console.WriteLine(5 / 3.0);
    Console.WriteLine(500000000 / 3.0d);
    //decimal
    Console.WriteLine(5 / 3m);
    Console.WriteLine(500000000 / 3.0m);


    int intValue = int.MaxValue;
    long longValue = 1;

    longValue = intValue;
    Console.WriteLine(longValue);

    longValue = long.MaxValue;
    //rzutowanie
    intValue = (int)longValue;
    Console.WriteLine(intValue);

    intValue = int.MaxValue;
    intValue = intValue + 1;
    Console.WriteLine(intValue);

    float floatValue = (float)3.77777777777;
    Console.WriteLine(floatValue);

    string stringValue = "123";
    intValue = int.Parse(stringValue); ;
    Console.WriteLine(intValue);


    stringValue = "123,456";
    floatValue = float.Parse(stringValue); ;
    Console.WriteLine(floatValue);
}


void Strings()
{
    //deklaracja zmiennej lokalnej o typie string i nazwie hello
    string hello;

    //inicjalizacja zmiennej - pierwsze przypisanie wartości
    hello = "Hello";

    //delaracja z inicjalizacją
    string toWhom = "World";

    Console.WriteLine(hello);
    Console.WriteLine(toWhom);

    //przypisanie wartości
    toWhom = "class";

    Console.Write(hello);
    Console.Write(" ");
    Console.Write(toWhom);
    Console.WriteLine();

    toWhom = Console.ReadLine();

    //łączenie stringów
    string outputString = hello + " " + toWhom;
    outputString = outputString.ToUpper();
    Console.WriteLine(outputString);

    //łączenie za pomocą string.Format
    outputString = string.Format("{0} {1}!", hello, toWhom);
    Console.WriteLine(outputString);

    outputString = string.Format("{1} {0}!", hello, toWhom);
    Console.WriteLine(outputString);

    //string interpolowany
    outputString = $"{hello} {toWhom}!";
    Console.WriteLine(outputString);

    Console.WriteLine($"Your name has {toWhom.Length} letters");

    outputString = "     Hello World!   ";

    Console.WriteLine($"[{outputString.TrimEnd()}]");
    Console.WriteLine($"[{outputString.TrimStart()}]");
    Console.WriteLine($"[{outputString.Trim()}]");

    outputString = "Hello World!!";
    Console.WriteLine($"{outputString.Trim('a')}");


    outputString = "Hello World!!";
    Console.WriteLine($"{outputString.Contains("!!")}");
    outputString = "Hello World! How do you do, World?";
    Console.WriteLine($"{outputString.Contains("!!")}");

    //zastąpienie części ciągu znaków czułe na wielkość liter
    outputString = outputString.Replace("World", toWhom);
    Console.WriteLine(outputString);

    //włączamy ignoreCase - podmianka niezależnie od wielkości liter
    outputString = outputString.Replace("world", toWhom, true, CultureInfo.CurrentCulture);
    Console.WriteLine(outputString);
}


