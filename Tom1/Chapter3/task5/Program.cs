// Напишите программу, в которой пользователю предлагается ввести название дня в неделе.
// По введенному названию программа определяет порядковый номер дня в неделе.
// Если пользователь вводит неправильное название дня, программа выводит сообщение о том,
// что такого дня нет. Предложите версию программу на основе вложенных условных операторов
// и на основе оператора выбора switch.

using Microsoft.VisualBasic;

bool flag = true;

while (flag)
{
    string nameDayWeek = Interaction.InputBox("Введите название дня недели:", "День недели");
    switch (nameDayWeek)
    {
        case "Понедельник":
            MessageBox.Show("1", "День недели");
            flag = false;
            break;
        case "Вторник":
            MessageBox.Show("2", "День недели");
            flag = false;
            break;
        case "Среда":
            MessageBox.Show("3", "День недели");
            flag = false;
            break;
        case "Четверг":
            MessageBox.Show("4", "День недели");
            flag = false;
            break;
        case "Пятница":
            MessageBox.Show("5", "День недели");
            flag = false;
            break;
        case "Суббота":
            MessageBox.Show("6", "День недели");
            flag = false;
            break;
        case "Воскресенье":
            MessageBox.Show("7", "День недели");
            flag = false;
            break;
        default:
            MessageBox.Show("Введён не название дня недели, повторите ввод!", "День недели");
            break;
    }
}

flag = true;

while (flag)
{
    string nameDayWeek = Interaction.InputBox("Введите название дня недели:", "День недели");
    if (nameDayWeek == "Понедельник")
    {
        MessageBox.Show("1", "День недели");
        flag = false;
    }
    else if (nameDayWeek == "Вторник")
    {
        MessageBox.Show("2", "День недели");
        flag = false;
    }
    else if (nameDayWeek == "Среда")
    {
        MessageBox.Show("3", "День недели");
        flag = false;
    }
    else if (nameDayWeek == "Четверг")
    {
        MessageBox.Show("4", "День недели");
        flag = false;
    }
    else if (nameDayWeek == "Пятница")
    {
        MessageBox.Show("5", "День недели");
        flag = false;
    }
    else if (nameDayWeek == "Суббота")
    {
        MessageBox.Show("6", "День недели");
        flag = false;
    }
    else if (nameDayWeek == "Воскресенье")
    {
        MessageBox.Show("7", "День недели");
        flag = false;
    }
    else
    {
        MessageBox.Show("Введён не название дня недели, повторите ввод!", "День недели");
    }
}
