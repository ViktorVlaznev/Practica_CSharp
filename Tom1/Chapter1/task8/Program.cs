// Напишите прорамму для вычисления суммы двух чисел. Оба числа вводятся пользователем.
// Для вычисления суммы используйте оператор +. Предложите два варианта программы: программу,
// в которой .данные вводятся и выводятся с помощью диалоговых окон, и программу, к которой
// используется КОНСОЛЬНЫЙ ВВОД И ВЫВОД данных.

using Microsoft.VisualBasic;

int num1 = int.Parse(Interaction.InputBox("Введите первое число:", "Первое число"));
int num2 = int.Parse(Interaction.InputBox("Введите второе число:", "Второе число"));
MessageBox.Show($"{num1} + {num2} = {num1 + num2}", "Сумма");

Console.Write("Введите первое число: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
