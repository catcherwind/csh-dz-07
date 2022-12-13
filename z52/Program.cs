Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

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

double[] SearchArithmeticMeanArray(int[,] array)
{
    double[] amArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           amArray[j] += array[i,j]; 
        }
    }
    for (int i = 0; i < amArray.Length; i++){
        amArray[i] = amArray[i] / amArray.Length;
    }
    return amArray;
}

int[,] array = FillArray(rows, columns);
PrintArray(array);
double[] amArray = SearchArithmeticMeanArray(array);
Console.WriteLine();
Console.WriteLine(String.Join(' ', amArray));