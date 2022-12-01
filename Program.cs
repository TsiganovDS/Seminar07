Console.Write("Введите количество строк: ");
int Row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int Col = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;

Console.Write("Введите номер столбца: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] arrayOfElements = generate2DArray(Row,Col,10);
                
int[,] generate2DArray(int Row, int Col, int deviation)
{
    int[,] array = new int[Row,Col];
    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Col; j++)
        {
            array[i,j] = new Random().Next(-deviation,deviation + 1);
        }
    }
    return array;
     
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
        print2dArray(arrayOfElements);  
     if (pos1 < 0 | pos1 > arrayOfElements.GetLength(0) - 1 | pos2 < 0 | pos2 > arrayOfElements.GetLength(1) - 1)
        {
           Console.WriteLine("Элемент массива не существует");
        }
    else
        {
           Console.WriteLine("Значение элемента массива - {0}", arrayOfElements[pos1, pos2]);
        }
