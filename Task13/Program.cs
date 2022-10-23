// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// // выполнять задание не используя string.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdNumber(number);

void ThirdNumber(int num)
{
    if (num < 100) Console.WriteLine("Вась, нет третьей цифры.");
    else
    {
        int count = -3;
        int copy = num;
        int kostyl = num;
        while (copy > 0)
        {

            copy = copy / 10;
            count++;
        }

        int magic = 1;

        while (count > 0)
        {

            magic = magic * 10;
            count--;
        }

        num = num / magic % 10;

        Console.WriteLine($"Число {num} является третьим");

    }
}