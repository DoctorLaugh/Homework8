int[,] GetArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int rowH = size - 1;
    int columnH = size - 1;
    int rowV = 0;
    int columnV = 0;
    bool left = true;
    bool top = true;
    for(int count = 1; count < (size * size) + 1; count++)
    {
        result[i, j] = count;
        if (left && top)
        {
            if (j == columnH)
            {
                rowV++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        if (!left && top)
        {
            if (i == rowH)
            {
                columnH--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        if (!left && !top)
        {
            if (j == columnV)
            {
                rowH--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        if (left && !top)
        {
            if (i == rowV)
            {
                columnV++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
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
Console.Clear();
Console.Write($"Введите размер матрицы: ");
int matrSize = int.Parse(Console.ReadLine());
int[,] array = GetArray(matrSize);
PrintArray(array);