using SOLID.L;

int a = 5;
int b = 3;

Rectangle rectangle = new Square();
SetRectangle(rectangle, a, b);

Console.WriteLine($"Pole prostokąta o bokach {a} i {b} = {rectangle.GetArea()}");



static void SetRectangle(Rectangle rectangle, int a, int b)
{
    rectangle.A = a;
    rectangle.B = b;
}