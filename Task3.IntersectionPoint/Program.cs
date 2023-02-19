// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputInt(string message)
{
    System.Console.WriteLine(message);
    int point = Convert.ToInt32(Console.ReadLine());
    return point;
}

(int, int) Coords(string message)
{
    for (int i = 1; i <= 2; i++)
    {
        (int b, int k) = InputInt(message);
    }
    return (b, k);
}

(double,double) IntersectionPoint (int b1,int k1, int b2, int k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    return (x, y);
}

(int b1, int k1) = Coords ("Введите координаты первого отрезка (по очереди)");
(int b2, int k2) = Coords ("Введите координаты второго отрезка (по очереди)");

(double x, double y) = IntersectionPoint (b1, k1, b2, k2);
System.Console.WriteLine($"{x}, {y}");
