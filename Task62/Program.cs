// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

  void Spiral()
    {
        int MatrixSize = 4;
        int temp = 1;
        int i = 0;
        int j = 0;
        int[,] array = new int[MatrixSize, MatrixSize];


        while (temp <= array.GetLength(0) * array.GetLength(1))
        {
            array[i, j] = temp;
            temp++;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
            else if (i < j && i + j >= array.GetLength(0) - 1) i++;
            else if (i >= j && i + j > array.GetLength(1) - 1)j--;
            else i--;
        }
        for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                Console.Write(array[a, b]);
            }
            Console.WriteLine();
        }
    }

