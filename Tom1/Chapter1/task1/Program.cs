﻿// Напишите программу, в которой пользователь вводит сначала имя,
// а затем фамилию. Программа выводит сообщение с информацией об имени
// и фамилии пользователя. Предложите версию программы, в которой
// ввод и вывод текста осуществляется с помощью диалоговогых окон.
// Также предложите консольную версию программы.

using Microsoft.VisualBasic;

string name = Interaction.InputBox("Введите Ваше имя:", "Давайте познакомимся: Имя");
string surname = Interaction.InputBox("Введите Вашу фамилию:", "Давайте познакомимся: Фамилия");
string txt = "Очень приятно, " + name + " " + surname + "!";
MessageBox.Show(txt, "Знакомство состоялось");

Console.Write("Введите Ваше имя: ");
name = Console.ReadLine();
Console.Write("Введите Вашу фамилию: ");
surname = Console.ReadLine();
txt = "Очень приятно, " + name + " " + surname + "!";
Console.WriteLine(txt);
