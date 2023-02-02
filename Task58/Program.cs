// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размеры массива: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер матрицы: ");
int row = int.Parse(Console.ReadLine());
int columns = row;

int [,] array = new int [m, n];
int [,] secondarray = new int [m, n];



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(0,10);                
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


void MultyArray(int[,] array, int[,] secondarray, int row, int columns)
{
    int[,] multyarray = new int[row, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondarray.GetLength(1); j++)
        {
            multyarray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                multyarray[i, j] += array[i, k] * secondarray[k, j];
            }
            Console.Write(multyarray[i, j]+" ");
        }
    Console.WriteLine();  
    }
    
}

FillArray(array);
FillArray(secondarray);
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

PrintArray(secondarray);
Console.WriteLine();

MultyArray(array, secondarray, row, columns);
