// написать функцию / метод, где на вход
// берём число А, на выход сумма числе от 1 до А

Console.WriteLine("Введите число А");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 0; i <= num; i++)
{
  sum = sum + i;
}
Console.WriteLine(sum);