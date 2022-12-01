Console.Write("Введите количество строк: ");
int Row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int Col = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[Row, Col];

void generate2DArray(int[,] array)
{
    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Col; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}

 void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

generate2DArray(numbers);
print2dArray(numbers);

for (int j = 0; j < Col; j++)
{
    double sum = 0;
    for (int i = 0; i < Row; i++)
    {
        sum = (sum + numbers[i, j]);
    }
    sum = sum / Row;
    Console.WriteLine($"Среднее арифметическое {j+1} столбца: {Math.Round(sum, 2)}");
}

