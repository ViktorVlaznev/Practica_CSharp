// Напишите программу, в которой пользователь вводит целое число в диапазоне от 1 до 7,
// а программа определяет по этому числу день недели. Если введенное пользователем число
// выходит за допустимый диапазон, выводится сообщение о том, что введено некорректное значение.
// Используйте оператор switch. Предложите механизим обработки ошибки,
// связанной с вводом нечислового значения.

using Microsoft.VisualBasic;

bool flag = true;

while(flag)
{
try
{
int number = int.Parse(Interaction.InputBox("Введите номер дня недели:", "День недели"));
flag = number >= 1 && number <= 7 ? false : true;
switch (number)
{
    case 1:
        MessageBox.Show("Понедельник", "День недели");
        break;
    case 2:
        MessageBox.Show("Вторник", "День недели");
        break;
    case 3:
        MessageBox.Show("Среда", "День недели");
        break;
    case 4:
        MessageBox.Show("Четверг", "День недели");
        break;
    case 5:
        MessageBox.Show("Пятница", "День недели");
        break;
    case 6:
        MessageBox.Show("Суббота", "День недели");
        break;
    case 7:
        MessageBox.Show("Воскресенье", "День недели");
        break;
    default:
        MessageBox.Show("Введён не номер дня недели, повторите ввод!", "День недели");
        break;
}
}
catch
{
    MessageBox.Show("Введено не число, повторите ввод!", "День недели");
}
}