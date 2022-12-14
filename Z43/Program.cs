/*                          Домашнее задание к семинару 6 С#
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Например:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)                 */

// x = -(b1 - b2) / (k1 - k2);  y = k1 * x + b1;

void FindIntersectionPoint2Lines()
{
    double K1, B1;
    double K2, B2;
    double СoordinateX, CoordinateY;

    Console.WriteLine("Укажите запрошенные переменные для двух прямыx заданых уравнением:");
    Console.WriteLine("y = k * x + b");

    Console.Write("k1 = ");
    K1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1 = ");
    B1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    K2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    B2 = Convert.ToDouble(Console.ReadLine());

if (K1 != K2)
{
    СoordinateX = (B2 - B1) / (K1 - K2);
    CoordinateY = K2 * СoordinateX + B2;

    Console.WriteLine("Координаты точки пересечения:");
    Console.WriteLine($"X = {СoordinateX} ; Y = {CoordinateY}");
}
else if (B1 == B2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны");
}

FindIntersectionPoint2Lines();  