﻿// Напишите программу, в которой вычисляется сумма чисел, которые вводит пользователь.
// Программа выводит запрос на ввод числа, считывает введенное пользователем число,
// прибавляет его к сумме и снова выводит запрос на ввод числа.
// Процесс продолжается до тех пор, пока пользоваетель не введет нулевое значение.
// Используйте обработку исключений.

using Microsoft.VisualBasic;

try
{
int number = int.Parse(Interaction.InputBox("Введите целое число:", "Сумма числа"));
int sum = 0;
while (number != 0)
{
    sum += number;
    MessageBox.Show($"Промежуточная сумма = {sum}", "Сумма чисел");
    number = int.Parse(Interaction.InputBox("Введите целое число:", "Сумма числа"));
}
MessageBox.Show($"Итог = {sum}", "Сумма чисел");
}
catch
{
    MessageBox.Show("Введено не число", "Сумма чисел");
}
