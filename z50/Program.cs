Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x (учтите, что нумирация начинается с 0)");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y (учтите, что нумирация начинается с 0)");
int y = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int arrayRows, int arrayColumns)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(-10, 10);
        }
    }
    return filledArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SearchArray(int[,] array, int x, int y)
{
    if (x >= array.GetLength(0) ||  y >= array.GetLength(1) || x < 0 || y < 0)
        Console.WriteLine("элемента с данными индексами в массиве нет");
    else
        Console.WriteLine($"Число с заданными индексами = {array[x,y]}");
}

int[,] array = FillArray(rows, columns);
PrintArray(array);
SearchArray(array, x, y);