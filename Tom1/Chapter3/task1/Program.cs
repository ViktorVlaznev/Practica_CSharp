﻿// Напишите программу, в которой пользователь вводит число, а программа
// проверяет, делится ли это число на 3 и на 7. Результат проверки
// отображаются в сообщении в диалоговом окне. Используйте обработку исключений.

using Microsoft.VisualBasic;

try
{
int number = int.Parse(Interaction.InputBox("Введите целое число:", "Проверка числа на деление"));
if (number % 3 == 0 && number % 7 == 0)
    {
        MessageBox.Show("Число делится и на 3 и на 7!", "Проверка числа на деление");
    } else {MessageBox.Show("Число не делится ни на 3 и на 7!", "Проверка числа на деление");}
}
catch
{
    MessageBox.Show("Введено не число", "Проверка числа на деление");
}