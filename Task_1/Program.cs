void FillTwoDimArray(int[,] array, int RandomFrom, int RandomTo, int RowCount, int ColumnCount)
{   
    RowCount = array.GetLength(0);
    ColumnCount = array.GetLength(1);
    Random arr = new Random();
    for(int i = 0; i < RowCount; i++)
    {
        for(int j = 0; j < ColumnCount; j++)
        {
            array[i,j] = arr.Next(RandomFrom, RandomTo);
        }
    }
}
void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int FindMinRow(int[,] array, int RandomTo, int ColumnsCount)
{
    int RowMinNumber = 0;
    int SumMin = RandomTo * ColumnsCount;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(sum < SumMin)
        {
            SumMin = sum;
            RowMinNumber = i;
        }
    }
    return RowMinNumber; 
}
Console.WriteLine("Введите количество строк в массиве: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int Columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int [Rows, Columns];
Console.WriteLine("Введите диапазон элементов в массиве ОТ: ");
int From = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон элементов в массиве ДО: ");
int To = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Полученный массив: ");
FillTwoDimArray(numbers, From, To, Rows, Columns);
PrintTwoDimArray(numbers);
int RowMinNumber = FindMinRow(numbers, To, Columns);
Console.WriteLine($"Номер последней строки с наименьшей суммой элементов: {RowMinNumber}");