int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// номер строки вывожу не согласно нумерации строк массива, а по порядку
void MinSumRow(int[,] inArray)
{
    int[] sumsort = new int[inArray.GetLength(1)];
    int numminrow = 0;
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i, j];
        }
        sumsort[i] = sum;
        Console.WriteLine($"сумма чисел {i + 1} строки = {sum}");
    }
    for(int k = 0; k < sumsort.Length - 1; k++)
    {
        if(sumsort[k] < sumsort [k + 1])
        {
            numminrow = k;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой - {numminrow + 1}");
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("");
MinSumRow(array);