// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

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

void CalcArray(int[,] array, int pos1, int pos2)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[pos1, pos2])
            {
                Console.WriteLine($"Это элемент {array[i, j]}");

                return;
            }

        }
    }

}

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int[,] array = FillArray(5, 4);
PrintArray(array);
Console.WriteLine();

int pos1 = Prompt("Введите позицию по i ");
int pos2 = Prompt("Введите позицию по j ");

if (pos1 > array.GetLength(0) || pos2 > array.GetLength(1)) Console.WriteLine("!! Вы вышли за границы массива");
CalcArray(array, pos1, pos2);

