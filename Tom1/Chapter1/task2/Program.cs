// Напишите программу, в которой пользователь вводит имя и возраст.
// Программа отображает сообщение об имени и возрасте пользователя.
// Предложите консольную версию программы и версию, в которой данные
// вводятся и выводятся с помощью диалоговых окон.

using Microsoft.VisualBasic;

string name = Interaction.InputBox("Введите Ваше имя:", "Давайте познакомимся: Имя");
string age = Interaction.InputBox("Введите Ваш возраст:", "Давайте познакомимся: Возраст");
string txt = "Очень приятно, " + name + ". Вам " + age + " лет!";
MessageBox.Show(txt, "Знакомство состоялось");

Console.Write("Введите Ваше имя: ");
name = Console.ReadLine();
Console.Write("Введите Ваш возраст: ");
age = Console.ReadLine();
txt = "Очень приятно, " + name + ". Вам " + age + " лет!";
Console.WriteLine(txt);
