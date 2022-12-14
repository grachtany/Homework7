// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// / 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
void ShowArray(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]} ");
        }
        Console.WriteLine();
    }

}

double[,] CreateRandomArray(int rows, int coluns, int LeftRange, int RightRange)
{
    double[,] array = new double[rows, coluns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coluns; j++)
        {
            int count = 2;
            double value = new Random().NextDouble()* 20 - 10;
            array[i, j]  = Math.Round(value, count);
            
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Получить от пользователя m b n

int m = EnterNumber("Введите значение m: ");

int n = EnterNumber("Введите значение n: ");

// Создать двумерный массив
double[,] matrix = CreateRandomArray(m, n, -10, 10);
// ВЫвести массив
ShowArray(matrix);
