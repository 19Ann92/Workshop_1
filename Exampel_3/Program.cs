﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите первое число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(num % 2 == 0 ? $"Число {num} четное." 
: $"Число {num} не четное.");
