// написать функцию / метод, где на вход
// берём число А, на выход сумма числе от 1 до А

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());

int numA()
{
    int num = 0;
    int B = A;
    for (int i = 0; B > 0; i++)
    {
      B = B/10;
      num = i+1;
    }
    return num;
}
numA();
Console.WriteLine(numA());