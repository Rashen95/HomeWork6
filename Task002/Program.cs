// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Есть две прямые заданные уравнениями y = k1 * x + b1 и y = k2 * x + b2. Введите значения b1, k1, b2 и k2, а я выведу вас координаты точки пересечения данных двух прямых");
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
if (b1 == k1 && b1 == b2 && b1 == k2)
{
    Console.Write("Параллельные прямые никогда не пересекутся!");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Две прямые пересекутся в точке с координатой x = {Math.Round(x, 2)} и y = {Math.Round(y, 2)}");
}