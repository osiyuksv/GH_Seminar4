// написать функцию / метод, где на вход
// берём число А, на выход сумма числе от 1 до А

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());

int SumA()
{
    int sumA = 0;
    for (int i = 0; i <= A; i++)
    {
      sumA = sumA + i;
    }
    return sumA;
}

SumA();
Console.WriteLine(SumA());