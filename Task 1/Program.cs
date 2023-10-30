Console.WriteLine("Введите количество элементов: ");
bool isCorrectLength = int.TryParse(Console.ReadLine(), out int arrayLength);
if (isCorrectLength)
{
    int[,] array = new int[arrayLength, arrayLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите в {i + 1} строку {j + 1} столбца значение: ");
            array[i, j] = int.Parse(Console.ReadLine());
        }
    }

    int sum = 0;
    for (int k = 0; k < arrayLength; k++)
    {
        sum += array[k, arrayLength - k - 1];
    }

    Console.WriteLine($"Сумма элементов побочной диагонали равна: {sum}");

    int sumBelow = 0;
    for (int i = 1; i < arrayLength; i++)
    {
        for (int j = arrayLength - 1; j > 0; j--)
        {
            if (i + j > arrayLength - 1)
            {
                sumBelow += array[i, j];
            }
        }
    }

    Console.WriteLine($"Сумма элементов под побочной диагональю равна: {sumBelow}");
}
else
{
    Console.WriteLine("Неверно введен размер массива");
}