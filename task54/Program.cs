// Написать программу которая в двумерном массиве заменяет строки на столбы или сообщает что это на возможно.
// Транспортирование матрицы
Console.Clear();
Console.WriteLine("Введите размер двумерного масссива");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
if(m == n)
{
int[,] arr = GetArray(m, n, 0, 10);
PrintArray(arr);
Console.WriteLine();
int[,]arr2 = ExchangeArr(arr);
PrintArray(arr2);
}
else Console.WriteLine("Это невозможно!");
int[,]GetArray(int m, int n, int minValue, int maxValue)
{
    int[,]result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue+1);
        }

    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for(int i =0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
    {
     Console.Write($"{inArray[i,j]} ");
    }
   
    Console.WriteLine();
    }
    
}
int[,] ExchangeArr(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = i+1; j < Array.GetLength(1); j++)
        {
        int a = Array[i, j];
        Array[i, j] = Array[j, i];
        Array[j, i] = a;
    }
    }
    return Array;

}