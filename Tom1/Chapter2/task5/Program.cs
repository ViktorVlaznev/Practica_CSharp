﻿// Напишите программу, которая проверяет, сколько тысяч во введенном пользователем числе
// (определяется четвертая цифра справа в десятичном представлении числа).

using Microsoft.VisualBasic;

int number = int.Parse(Interaction.InputBox("Введите целое число:", "Проверка"));
MessageBox.Show("У числа " + number + " " + number / 1000 % 10 + " тысяч(и)", "Тысячи");