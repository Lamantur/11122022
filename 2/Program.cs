// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых
//, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//// / / / / / / /  / / / / / /  / / / / / / / / / / 
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/////////////////////////////////////
//  k1x + b1 = k2x + b2
//  k1x - k2x = b2 - b1
//  (k1 - k2)x = b2 - b1
//  x = (b2 - b1) / (k1 - k2)
//  y = k1x + b1
////////////////////////////////////////////

double Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
double[] ArrayInPrompt()
{
    double[] array = new double[4];
    array[0] = Prompt("Введите значение k из формулы y=kx+b для первой прямой");
    array[1] = Prompt("Введите значение b из формулы y=kx+b для первой прямой");
    array[2] = Prompt("Введите значение k из формулы y=kx+b для второй прямой");
    array[3] = Prompt("Введите значение b из формулы y=kx+b для второй прямой");
    return array;
}

double IntersectionX(double[] array)
{
    return (array[3] - array[1]) / (array[0] - array[2]);
}
double IntersectionY(double[] array)
{
    return (array[0] * IntersectionX(array) + array[1]);
}
double[] array = ArrayInPrompt();

if (array[0] == array[2])
{
    System.Console.WriteLine("Параллельные прямые не пересекаются");
}
else
{
    System.Console.WriteLine($"данные прямые пересекаются в координатах: ({IntersectionX(array)}; {IntersectionY(array)}) >");
}

