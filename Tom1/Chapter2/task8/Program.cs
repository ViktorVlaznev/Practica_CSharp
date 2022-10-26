// Напишите программу, в которой для введенного пользователем числа
// в бинарном представлении третий бит устанавливает равным единице.

using Microsoft.VisualBasic;

string ChangeThirdCharinBinar(int num)
{   
    num |= 1 << 2;
    string binar = Convert.ToString(num, 2);
    
    return binar;
}

int number = int.Parse(Interaction.InputBox("Введите целое число:", "Двоичная система"));

MessageBox.Show(ChangeThirdCharinBinar(number), "Двоичная система");
