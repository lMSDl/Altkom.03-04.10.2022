
using InheritanceApp.Models;
//polimorfizm  - możliwość przedstawienia jednek klasy za pomocą innej z hierarchi dziedziczenia
Shape shape = new Point();
Shape1D shape1d = new Point();
Point point = new Point();

Shape line = new Line(10);
Shape rectangle = new Rectangle(5, 10);

var shapes = new List<Shape>() { point, line, rectangle };

foreach(var item in shapes)
{
    Console.WriteLine(item.ToString());
}

