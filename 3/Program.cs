// Задача 5: *Найдите максимальное значение в матрице по каждой строке,
// получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
//////////////////////////////////////////////////////////////////////////
//Исходная матрица
int[,] matrix ={
    {1,2,3},
    {3,4,5}
};

//Получаем отдельный столбец матрицы в виде массива
int[] GetColumn(int[,] matrix, int columN)
{
    int[] massiv = new int[matrix.GetLength(0)];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = matrix[i, columN];
    }
    return massiv;
}
//Получаем отдельную строку матрицы
int[] GetString(int[,] matrix, int stringN)
{
    int[] massiv = new int[matrix.GetLength(1)];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = matrix[stringN, i];
    }
    return massiv;
}


// максимальный элемент массива
int max(int[] massiv)
{
    int max = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > max) max = massiv[i];
    }
    return max;
}

// минимальный элемент массива
int min(int[] massiv)
{
    int min = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] < min) min = massiv[i];
    }
    return min;
}


//сложение всех элементов массива
int summa(int[] max)
{
    int sum = 0;
    for (int i = 0; i < max.Length; i++)
    {
        sum = sum + max[i];
    }
    return sum;
}

// Получение массива из максимальных элементов каждой строки
int[] Maximums(int[,] matrix)
{
    int[] maximum = new int[matrix.GetLength(0)];
    for (int n = 0; n < matrix.GetLength(0); n++)
    {
        for (int i = 0; i < maximum.Length; i++)
        {
            maximum[n] = max(GetString(matrix, n));

        }
    }
    return maximum;
}

// Получение массива из минимальны элементов каждой колонкн
int[] Minimums(int[,] matrix)
{
    int[] minimum = new int[matrix.GetLength(1)];
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        for (int i = 0; i < minimum.Length; i++)
        {
            minimum[n] = min(GetColumn(matrix, n));

        }
    }
    return minimum;
}


System.Console.WriteLine("Сумма максимальных элементов каждой строки = " + summa(Maximums(matrix)));
System.Console.WriteLine("Сумма минимальных элементов каждой колонки = " + summa(Minimums(matrix)));
int res = summa(Maximums(matrix)) - summa(Minimums(matrix));
System.Console.WriteLine("Результат вычитания = " + res);


