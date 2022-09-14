void FillUniqueRandomArray(int[,] array, int RowCount, int ColumnCount)
{   
    RowCount = array.GetLength(0);
    ColumnCount = array.GetLength(1);
    Random arr = new Random();
    List<int> list = Enumerable.Range(10, ColumnCount * RowCount).OrderBy(x => arr.Next()).ToList();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColumnCount; j++)
        {
            array[i, j] = list[i * ColumnCount + j];
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
New:
int RowsCount = new Random().Next(1,51);
int ColumnsCount = new Random().Next(1,51);
int[,] numbers = new int [RowsCount, ColumnsCount];
if(RowsCount * ColumnsCount <= 50)
{
    FillUniqueRandomArray(numbers, RowsCount, ColumnsCount);
    PrintTwoDimArray(numbers);
}
else goto New;