public static class Sorting
{

    /// <summary>
    /// Сортировка методом выбора
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortSelection(this int[] collection)
    {
        int size = collection.Length;

        for (int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for (int j = i; j < size; j++)
            {
                if (collection[j] < collection[pos]) pos = j;
            }
            int temp = collection[i];
            collection[i] = collection[pos];
            collection[pos] = temp;
        }

        return collection;
    }

    /// <summary>
    /// Сортировка пузирьком
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>

    public static void SortBouble(this int[] collection)
    {
        for (int k = 0; k < collection.Length - 1; k++)
        {
            for (int i = 0; i < collection.Length - 1 - k; i++)
            {
                if (collection[i] > collection[i + 1])
                {
                    int temp = collection[i];
                    collection[i] = collection[i + 1];
                    collection[i + 1] = temp;
                }
            }
        }
    }

}