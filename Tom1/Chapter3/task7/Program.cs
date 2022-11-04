// Напишите программу для вычисления суммы квадратов натуральных чисел.


using Microsoft.VisualBasic;

/// <summary>
/// функция возвращает сумму квадратов до заданного натурального числа
/// </summary>
/// <param name="number">натуральное число</param>
/// <returns>сумма квадратов до заданного натурального числа</returns>
uint GetSumSquaresSeriesNaturalNumbers(uint number)
{
    return number * (number + 1) * (2 * number + 1) / 6;
}

try
{
    uint number = uint.Parse(
        Interaction.InputBox("Введите натуральное число:", "Сумма квадратов чисел")
    );
    uint sum = 0;
    MessageBox.Show($"Итог = {GetSumSquaresSeriesNaturalNumbers(number)}", "Сумма квадратов чисел");
    while (number > 0)
    {
        sum += number * number--;
    }
    MessageBox.Show($"Итог = {sum}", "Сумма квадратов чисел");
}
catch
{
    MessageBox.Show("Введено не натуральное число", "Сумма квадратов чисел");
}
