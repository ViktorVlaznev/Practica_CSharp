// Напишите программу, в которой пользователь последовательно вводит название текущего дня недели,
// название месяца и дату (номер дня в месяце). Программа выводит сообщение о сегодняшней дате
// (день недели, дата, месяц). Используйте консольный ввод и вывод данных. Предложите версию программы,
// в которой для ввода и вывода данных используются диалоговые окна.

using Microsoft.VisualBasic;

Console.Write("Введите текущий день недели: ");
string dayWeek = Console.ReadLine();
Console.Write("Введите название текущего месяца: ");
string month = Console.ReadLine();
Console.Write("Введите день текущего месяца: ");
int dayMonth = int.Parse(Console.ReadLine());
string txt = "Сегодня " + dayWeek + " " + dayMonth + " " + " " + month;
Console.WriteLine(txt);

dayWeek = Interaction.InputBox("Введите текущий день недели: ", "День недели");
month = Interaction.InputBox("Введите название текущего месяца:", "Месяц");
dayMonth = int.Parse(Interaction.InputBox("Введите день текущего месяца:", "День"));

txt = dayWeek + " " + dayMonth + " " + " " + month;
MessageBox.Show(txt, "Сегодня");
