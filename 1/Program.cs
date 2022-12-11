int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int[] NewArray(int Length)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt("Введите следующий элемент массива > ");
    }
    return array;
}

int PositiveInArray(int[] array)
{
    int positivenumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positivenumber++;
    }
    return positivenumber;
}

int[] array = NewArray(Prompt("Введите количество элементов массива >"));
System.Console.WriteLine("вы ввели " + PositiveInArray(array) + " положительных числа");
