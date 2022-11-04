// Напишите программу, в которой вычисляется сумма чисел, удовлетворяющих таким условиям:
// при делении на 5 в остатке получается 2, или при делении на 3 в остатке получается 1.
// Количество чисел в сумме выводится пользователем. Программа отоброжает числа, которые
// суммируются, и значение суммы. Используйте обработку исключений. Предложите версии программы,
// использующие разные операторы цикла.

using Microsoft.VisualBasic;

try
{
    uint number = uint.Parse(Interaction.InputBox("Введите кол-во чисел:", "Сумма чисел"));
    uint count = 0;
    uint sum = 0;
    string strNumber = "";
    uint temp = 1;
    while (count < number)
    {
        if (temp % 5 == 2 && temp % 3 == 1)
        {
            sum += temp;
            strNumber += $"{temp} + ";
            count++;
        }
        temp++;
    }
    MessageBox.Show($"{strNumber.Remove((strNumber.Length - 2), 1)} = {sum}", "Ряд чисел");
}
catch
{
    MessageBox.Show("Введено не число", "Ряд чисел");
}
