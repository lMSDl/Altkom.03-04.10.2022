using System;
using System.Globalization;


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

