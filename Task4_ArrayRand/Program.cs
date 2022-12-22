// заполнить массив из 8 элементов
// в случайном порядке

int[] RandArray()
{
    int[] ArrayR = new int[8];
    for (int i = 0; i < ArrayR.Length; i++)
    {
      ArrayR[i] = new Random().Next(0,2); // правое число всегда ставим +1
    }
    return ArrayR;
}
Console.Write(String.Join((", "), RandArray()));