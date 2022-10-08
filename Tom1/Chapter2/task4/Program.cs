// Напишите программу, которая проверяет, попадает ли введенное
// пользователем число в диапазон от 5 до 10 включительно.

using Microsoft.VisualBasic;

int number = int.Parse(Interaction.InputBox("Введите целое число:", "Проверка"));
MessageBox.Show(
    "Число " + number + (number >= 5 && number <= 10 ? " " : " не ") + " удовлетворяет критерию."
);
