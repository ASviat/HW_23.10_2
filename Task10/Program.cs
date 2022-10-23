// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// 22 -> Ошибка.
// 1234 -> Ошибка.
// // Выполнять задание не используя string.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 | number > 999) Console.WriteLine("Трехзначное, Вась.");
else ThirdNumber(number);


void ThirdNumber(int num)
{
    Console.WriteLine($"Вторая цифра в числе равна: {num / 10 % 10}");
}

