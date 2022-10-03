using System;
using System.Globalization;


int value = int.Parse(Console.ReadLine());
int calculatedValue = value % 2;
if(calculatedValue == 0)
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
if (value <= 0)
{
    Console.WriteLine($"Wartość jest mniejsza lub równa 0");
}
if (value >= 0)
{
    Console.WriteLine($"Wartość jest więszka lub równa 0");
}
if (value == 0)
{
    Console.WriteLine($"Wartość jest równa 0");
}

if(calculatedValue > value)
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

if(stringValue == "exit")
{
    Console.WriteLine("Bye!");
}
else if(stringValue == "o/")
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


