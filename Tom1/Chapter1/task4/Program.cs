// Напишите программу, в которой пользователю предлагается ввести название месяца и количество дней
// в этом месяце. Программа выводит сообщение о том. что соответствующий месяц содержит указанное количество
// дней. Предложите версии программы для ввода/вывода данных через консоль и с помощью диалоговых окон.
using Microsoft.VisualBasic;

Console.Write("Введите название месяца: ");
string month = Console.ReadLine();
Console.Write("Введите количество дней в этом месяце: ");
int daysMonth = int.Parse(Console.ReadLine());
string txt = "В " + month + " " + daysMonth + " дней.";
Console.WriteLine(txt);

month = Interaction.InputBox("Введите название месяца:", "Месяц");
daysMonth = int.Parse(Interaction.InputBox("ведите количество дней в этом месяце:", "Месяц"));
txt = "В " + month + " " + daysMonth + " дней.";
MessageBox.Show(txt, "Месяц");
