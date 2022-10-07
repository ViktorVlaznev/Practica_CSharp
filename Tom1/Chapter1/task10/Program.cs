// Напишите программу, в которой пользователь вводит два числа,а программой вычисляется и отображается
// сумма и разность этих чисел. Предложите варианты программы с использованием консольного ввода/вывода
// данных и ввода и вывода данных с помощью диалоговых окон.

using Microsoft.VisualBasic;

int num1 = int.Parse(Interaction.InputBox("Введите первое число:", "Первое число"));
int num2 = int.Parse(Interaction.InputBox("Введите второе число:", "Второе число"));
MessageBox.Show(
    $"Сумма: {num1} + {num2} = {num1 + num2}, разность: {num1} - {num2} = {num1 - num2}!",
    "Сумма"
);

Console.Write("Введите первое число: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine(
    $"Сумма: {num1} + {num2} = {num1 + num2}, разность: {num1} - {num2} = {num1 - num2}!"
);
