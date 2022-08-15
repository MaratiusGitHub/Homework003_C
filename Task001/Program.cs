// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(num) < 10000 || Math.Abs(num) > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}