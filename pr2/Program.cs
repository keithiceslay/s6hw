// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double input (string message)
{
    Console.WriteLine (message);
    double number = int.Parse(Console.ReadLine());
    return number;
}

double b1 = input("Введите значение b1");
double k1 = input("Введите значение k1");
double b2 = input("Введите значение b2");
double k2 = input("Введите значение k2");

double x = (b1-b2)/(k2-k1);
double y = k2*x+b2;

Console.WriteLine($"Две прямые встретятся в точке с координатами ({x}, {y})");