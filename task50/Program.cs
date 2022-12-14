// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void EnterElements(int rowsIndex, int colunsIndex, int[,] massive, int rows, int coluns)
{
    if ((rowsIndex < rows) && (rowsIndex > -1) && (colunsIndex < rows) && (colunsIndex > -1))
        Console.WriteLine(massive[rowsIndex,colunsIndex]);
    else 
        Console.WriteLine ("Элемента с таким значением не существует. Введите новые значения");
        rowsIndex = EnterNumber("Введите значение i: ");
        colunsIndex = EnterNumber("Введите значение j: ");
        Console.WriteLine(massive[rowsIndex,colunsIndex]);
        
}

void ShowArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] CreateRandomArray(int rows, int coluns, int LeftRange, int RightRange)
{
    int[,] array = new int[rows, coluns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coluns; j++)
        {
            array[i, j] = new Random().Next(LeftRange, RightRange);

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
int[,] matrix = CreateRandomArray(m, n, 0, 10);
// ВЫвести массив
ShowArray(matrix);

// Получить от пользователя i j индекс
int i = EnterNumber("Введите значение i: ");
int j = EnterNumber("Введите значение j: ");

// Вывести элемент с заданной позицией или указание, что такого элемента нет и проверить новый индекс.
EnterElements(i, j, matrix, m, n);


