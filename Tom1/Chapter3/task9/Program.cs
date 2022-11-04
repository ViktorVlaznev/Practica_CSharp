// Напишите программу, в которой пользователем вводится два целых числа.
// Программа выводит все целые числа - начиная с наименьшего (из двух введенных чисел)
// и заканчивая наибольшим(из двух введенных чисел). Предложите разные версии программы
// (с использованием разных операторов цикла), а также механизм обработки исключений для этой программы.

using Microsoft.VisualBasic;

try
{
    int numberA = int.Parse(Interaction.InputBox("Введите число a: ", "Ряд чисел"));
    int numberB = int.Parse(Interaction.InputBox("Введите число b: ", "Ряд чисел"));
    int min = (numberA > numberB) ? numberB : numberA;
    int max = (numberA > numberB) ? numberA : numberB;
    string strNumber = "";
    while (min <= max)
    {
        strNumber += $"{min++} ";
    }
    MessageBox.Show(strNumber, "Ряд чисел");
}
catch
{
    MessageBox.Show("Введено не число", "Ряд чисел");
}
