// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int [,] array = new int [m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(0,100);                
            }
            
        }
     
}

void PrintArray(int[,] array)
{   

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   

            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
    
}


void FindMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

FillArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine();
FindMinSumElements(array);