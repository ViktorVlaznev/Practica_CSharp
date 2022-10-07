// Напишите программу, в которой пользователь водит имя и год рождения. а программа отображает
// сообщение, содержащее имя пользователя и его возраст. Предложите консольную версию программы,
// а также версию программы, в которой ввод и вывод данных выполняется с помощью диалоговых окон.

using Microsoft.VisualBasic;

Console.WriteLine("Введите Ваше имя: ");
string name = Console.ReadLine();
int year = 2022;
Console.Write("В каком году Вы родились? ");
int born = int.Parse(Console.ReadLine());
Console.WriteLine(name + ", Вам " + (year - born) + " лет");

name = Interaction.InputBox("Введите Ваше имя:", "Имя");
born = int.Parse(Interaction.InputBox("Введите год своего рождения:", "Год рождения"));
MessageBox.Show(name + ", Вам " + (year - born) + " лет", "Имя и возраст");
