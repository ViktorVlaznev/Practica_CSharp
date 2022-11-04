// Напишите программу, которая выводит последовательность чисел Фибоначчи.
// Первые два числа в этой последовательности равны 1, а каждое следующее
// число равно сумме двух предыдущих(получается полседовательность 1,1,2,3,5 и тд)
// Количество чисел в полседовательности вводится пользователем.
// Предложите версии программы, использующие разные операторы цикла.

using Microsoft.VisualBasic;

/// <summary>
/// функция возвращает n-ый член последовательности Фибоначи
/// </summary>
/// <param name="number">порядковый номер последовательности</param>
/// <returns>n-ый член последовательности Фибоначи</returns>
int GetFibonachiNumber(int number)
{
    int numFibonachi = 1;
    int result = 1;
    for (int i = 3; i <= number; i++)
    {
        int temp = result;
        result += numFibonachi;
        numFibonachi = temp;
    }
    return result;
}

try
{
    int number = int.Parse(Interaction.InputBox("Введите число:", "Числа Фибоначчи"));
    int count = 1;
    string GetFibonachiRow = "";
    while (count <= number)
    {
        GetFibonachiRow += $"{GetFibonachiNumber(count++)} ";
    }
    MessageBox.Show(GetFibonachiRow, "Числа Фибоначчи");
}
catch
{
    MessageBox.Show("Введено не число", "Числа Фибоначчи");
}
