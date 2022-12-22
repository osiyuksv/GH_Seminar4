// написать функцию / метод, где на вход
// берём число А, на выход сумма числе от 1 до А

Console.WriteLine("Введите число А");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetCountNumberA());

int GetCountNumberA()
{
    int count = 0;

    while(num > 0)
    {
       count++;
       num /= 10;
    }
    return count;
}
