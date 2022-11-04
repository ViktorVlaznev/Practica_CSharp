// Напишите программу, в которой вычисляется сумма нечетных чисел.
// Для проверки результата воспользуйтес тем, что 2+4+6+...+2n= n(n+1).
// Предложите версии программы, использующие разные операторы циклы.

using Microsoft.VisualBasic;

/// <summary>
/// функция возвращает сумму арифметической прогрессии из целых чисел
/// </summary>
/// <param name="minValue">первоначальный элемент</param>
/// <param name="maxValue">конечный элемент</param>
/// <param name="step">шаг</param>
/// <returns>сумма арифметической прогрессии</returns>
int GetSumArithmeticProgression(int minValue, int maxValue, int step)
{
    return (minValue + maxValue) * (1 + (maxValue - minValue) / step) / 2;
}

try
{
    int number = int.Parse(Interaction.InputBox("Введите натуральное число:", "Сумма числа"));
    int sum = 0;
    number = number % 2 == 0 ? number - 1 : number;
    MessageBox.Show($"Итог = {GetSumArithmeticProgression(1, number, 2)}", "Сумма чисел");
    while (number > 0)
    {
        sum += number;
        number -= 2;
    }
    MessageBox.Show($"Итог = {sum}", "Сумма чисел");
}
catch
{
    MessageBox.Show("Введено не число", "Сумма чисел");
}
