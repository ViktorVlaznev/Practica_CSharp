// Напишите программу, в которой пользователь последовательно вводит два
// целых числа. Программа определяет, какое из чисел больше или они равны,
// и выводит сообщение в диалоговом окне. Используейте обработку исключений.

using Microsoft.VisualBasic;

try
{
int numberA = int.Parse(Interaction.InputBox("Введите целое число a:", "Какое число больше?"));
int numberB= int.Parse(Interaction.InputBox("Введите целое число b:", "Какое число больше?"));

if (numberA > numberB)
    {
        MessageBox.Show($"{numberA} > {numberB}", "Какое число больше?");
    } else if (numberA < numberB) 
    {
        MessageBox.Show($"{numberB} > {numberA}", "Какое число больше?");
    } else {MessageBox.Show($"{numberB} = {numberA}", "Какое число больше?");}
}
catch
{
    MessageBox.Show("Введено не число", "Проверка числа на деление");
}