// Console.Clear();

// int n = 5;
// int[] array = new int[n];

// for (int i = 0; i < n; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine()!);
// }

// Console.WriteLine($"[{string.Join(" ", array)}]");
// Console.WriteLine(array[3]);

// // Сложность алгоритма O(1)

int n = int.Parse(Console.ReadLine()!);

// O(n^2)

int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i,j] = (i + 1) * (j + 1);
        matrix[j,i] = (i + 1) * (j + 1);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

PrintArray(matrix);
