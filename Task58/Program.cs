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
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] arrayres = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                arrayres[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return arrayres;
}
Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columns1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columns2 = int.Parse(Console.ReadLine());
if (columns1 != rows2)
{
    Console.WriteLine("Такие матирицы умножать нельзя!");
    return;
}
int[,] Array1 = GetArray(rows1, columns1, 0, 5);
int[,] Array2 = GetArray(rows2, columns2, 0, 5);
PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();
PrintArray(MultiplyMatrix(Array1, Array2));