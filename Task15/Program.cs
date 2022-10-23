﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// сделать это задание в методе. В методе будет находиться логика определения выходной ли день или нет. 
// Метод принимает как параметр число(int) и возвращает bool. В методе не должно быть считывания(ReadLine) и вывода в 
// консоль (WriteLine). Вывод и считывание должно быть в месте где метод вызывается.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Weekend(number)) Console.WriteLine("Да, выходной.");
else Console.WriteLine("Нет, не выходной.");

bool Weekend(int num)
{
    return num == 6 || num == 7;
}
