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
void SortRow(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        int[] rowForSort = new int[inArray.GetLength(1)];
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            rowForSort[j] = inArray[i, j];
        }
        for(int k = 0; k < rowForSort.Length; k++)
        {
            for(int l = 0; l < rowForSort.Length - 1; l++)
            {
                if(rowForSort[l] < rowForSort[l + 1])
                {
                    int min = rowForSort[l];
                    rowForSort[l] = rowForSort[l + 1];
                    rowForSort[l + 1] = min;
                }
            }
        }
        for (int m = 0; m < inArray.GetLength(1); m++)
        {
            inArray[i,m] = rowForSort[m];
        }
    }
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);
SortRow(array);
Console.WriteLine("");
PrintArray(array);