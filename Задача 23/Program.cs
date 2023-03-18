/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

Console.WriteLine();
if (N >= 1)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
    for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"{i * i * i}");
        }
}
else
    Console.Write($"Пожалуйста введите натуральное число");