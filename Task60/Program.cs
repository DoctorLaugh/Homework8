int[,,] GetArray(int[] matrSize, int minValue, int maxValue)
{
    int[,,] result = new int[matrSize[0], matrSize[1], matrSize[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                int element = new Random().Next(minValue, maxValue + 1);
                if (FindEqual(result, element)) continue;
                result[i, j, k] = element;
            }
        }
    }
    return result;
}
bool FindEqual(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num) return true;
            }
        }
    }
    return false;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите введите размеры трёхмерного массива через пробел: ");
string[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] { int.Parse(size[0]), int.Parse(size[1]), int.Parse(size[2]) }, 10, 99);
PrintArray(array);