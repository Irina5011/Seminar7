// Задача 3: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}

void SrednArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)  
    {
        int sum = 0;
        double doubleCount = 0;
        for(int i = 0; i < array.GetLength(0); i++) 
        {

        sum += array[i, j];
        doubleCount ++;
        } 
        Console.Write($"Среднее арифметическое {j} столбца = {sum/doubleCount}");
        Console.WriteLine();
        
    }

}

int[,] array = FillArray(5, 4);
PrintArray(array);
Console.WriteLine();
SrednArray(array);

