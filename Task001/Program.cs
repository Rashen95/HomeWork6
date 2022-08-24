// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Количество чисел, которое вы хотите ввести в массив: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Ваш массив [{string.Join(", ", array)}]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine($"Количество чисел в вашем массиве больше нуля равно {count}");