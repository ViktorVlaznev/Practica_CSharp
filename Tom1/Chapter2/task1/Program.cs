// Напишите программу, которая проверяет, делится ли введенное пользователем число на 3.
using Microsoft.VisualBasic;

int number = int.Parse(Interaction.InputBox("Введите целое число:", "Проверка деления на 3"));
MessageBox.Show(
    "Число " + number + (number % 3 == 0 ? " " : " не ") + "делится на 3.",
    "Проверка деления на 3"
);
