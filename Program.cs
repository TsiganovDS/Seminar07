Console.Write("Введите количество строк: ");
int lengthRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int lengthCol = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[lengthRow, lengthCol];

void generate2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}


void print2DArray(double[,] array)
{
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

generate2DArray(numbers);
print2DArray(numbers);