void FillandPrintTwoDimArray(int[,] array, int RandomFrom, int RandomTo, int RowCount)
{   
    RowCount = array.GetLength(0);
    int ColumnCount = RowCount;
    ColumnCount = array.GetLength(1);
    Random arr = new Random();
    for(int i = 0; i < RowCount; i++)
    {
        for(int j = 0; j < ColumnCount; j++)
        {
            array[i,j] = arr.Next(RandomFrom, RandomTo);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void FindAndPrintMatrixMult(int[,] arrayMult, int[,] array1, int[,] array2, int lengthForAllMatrix)
{
    for (int i = 0; i < lengthForAllMatrix; i++)
    {
        for (int j = 0; j < lengthForAllMatrix; j++)
        {
            for (int k = 0; k < lengthForAllMatrix; k++)
            {
                arrayMult[i, j] += array1[i, k] * array2[k, j];
            }
            Console.Write(arrayMult[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в Матрице №1: ");
int Rows1 = Convert.ToInt32(Console.ReadLine());
int Columns1 = Rows1;
int[,] matrix1 = new int [Rows1, Columns1];
Console.WriteLine("Введите диапазон элементов в Матрице №1 ОТ: ");
int From1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон элементов в Матрице №1 ДО: ");
int To1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Полученная Матрица №1: ");
FillandPrintTwoDimArray(matrix1, From1, To1, Rows1);
int Rows2 = Rows1;
int Columns2 = Rows2;
int[,] matrix2 = new int [Rows2, Columns2];
Console.WriteLine("Введите диапазон элементов в Матрице №2 ОТ: ");
int From2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон элементов в Матрице №2 ДО: ");
int To2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Полученная Матрица №2: ");
FillandPrintTwoDimArray(matrix2, From2, To2, Rows2);
int Rows3 = Rows1;
int Columns3 = Rows3;
int[,] matrixMult = new int[Rows3,Columns3];
Console.WriteLine("Произведение Матрицы №1 и Матрицы №2 равно: ");
FindAndPrintMatrixMult(matrixMult, matrix1, matrix2, Rows3);