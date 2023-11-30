namespace HM_Task3
{
    public class Program
    {
        public static void Main (string [] args){
        // Задайте прямоугольный двумерный массив. 
        // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        int row = 3;
        int col = 3;
        int min = 0;
        int max = 9;
        int [,] dimArray = InitDimArray(row, col, min, max);
        PrinDimArray(dimArray);
        int minRow = FindMinRowsSumm(dimArray);
        System.Console.WriteLine($"Required row => {minRow}");
        }
        static public int [,] InitDimArray (int row, int col, int min, int max){
            int [,] array = new int [row,col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i,j] = rand.Next(min,max+1);
                }
            }
            return array;
        }
        static public void PrinDimArray (int [,] array){
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    System.Console.Write(array[i,j] + " "); //"\t" - знак табуляции
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
        static public int FindMinRowsSumm (int [,] dimArray){
            int row = dimArray.GetLength(0);
            int col = dimArray.GetLength(1);
            int summ = 0;
            int indexRow = 0;
            int summMinRow = 0;
            for (int i = 0; i < col; i++)
            {
                summMinRow += dimArray[indexRow,i];
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    summ += dimArray[i,j];
                }
                if (summ < summMinRow) {
                    summMinRow = summ;
                    indexRow = i;
                }
                summ = 0;
            }
            return indexRow;
        }

    }
}