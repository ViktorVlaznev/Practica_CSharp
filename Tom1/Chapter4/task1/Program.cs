// Напишите программу, в которой создается одномерный числовой массив и
// заполняется числами, которые при делении на 5 дают в остатке 2(числа 2, 7, 12, 17 и так далее).
// Размер массива вводится пользователем. Предусмотреть обработку ошибки,
// связанной с вводом некорректного значения.

using Microsoft.VisualBasic;

try
{
    uint number = uint.Parse(Interaction.InputBox("Введите длину массива:", "Массив чисел"));
    uint count = 0;
    uint[] arrNumber = new uint[number];
    uint temp = 1;
    while (count < number)
    {
        if (temp % 5 == 2)
        {
            arrNumber[count] = temp;
            count++;
        }
        temp++;
    }
    MessageBox.Show(string.Join(", ", arrNumber), "Массив чисел");
}
catch
{
    MessageBox.Show("Введено не число", "Массив чисел");
}
