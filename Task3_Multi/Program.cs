// написать функцию / метод, где на вход
// берём число А, на выход произведение от 1 до А

Console.WriteLine("Введите число А");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetMultiA());

int GetMultiA()
{
    int multi = 1;

    for (int i = 2; i <= num; i++)
    {
       multi *= i;
    }
    return multi;
}

