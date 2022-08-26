// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float x = 0;
float y = 0;

Console.WriteLine("Введите b1");
float b1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите k1");
float k1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите b2");
float b2 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите k2");
float k2 = float.Parse(Console.ReadLine()!);

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine("Точка пересечения прямых будет иметь координату (" + x + "; " + y + ")");
}


