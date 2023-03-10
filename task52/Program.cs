// Написать программу которая обменивает элементы первой строки и последней строки

Console.Clear();
Console.WriteLine("Введите размер двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] arr = GetArray(m,n,0,100);
PrintArray(arr);
Console.WriteLine();
arr = ExchangeLine(arr);
PrintArray(arr);
int[,]GetArray(int m,int n,int minValue,int maxValue)
{
    int[,]result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j< n;j++)
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
        for(int j = 0; j < inArray.GetLength(1);j++)
    {
     Console.Write($"{inArray[i,j]} ");
    }
    
        Console.WriteLine();
    }
}
int[,]ExchangeLine(int[,]array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int a = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j]=array[0,j];
        array[0,j] =a;
    }
    return array;
}