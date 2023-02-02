// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int [,] array = new int [m, n];

void FillAndSortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(0,100);                
            }
            
        }
     
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
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





FillAndSortArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine();



