using static Sorting;

Console.Clear();

int n = 20;
int max = 100;

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = Random.Shared.Next(max);
}

Console.WriteLine($"[{String.Join(',', array)}]");

array.SortBouble();

Console.WriteLine($"[{String.Join(',', array)}]");