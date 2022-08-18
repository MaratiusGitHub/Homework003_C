// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void coub (int x)
{
    for (int i = 1; i <= x; i++)
    {
        double res = Math.Pow(i, 3);
        Console.WriteLine($"Число {i} в кубе равно {res}");
    }
}

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
coub(N);