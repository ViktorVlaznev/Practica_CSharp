﻿// Напишите программу, в которой по году рождения определяется воз-раст пользователя.
// Используйте консольный ввод в вывод данных.

int year = 2022;
Console.Write("В каком году Вы родились? ");
int born = int.Parse(Console.ReadLine());
Console.WriteLine("Тогда Вам " + (year - born) + " лет");