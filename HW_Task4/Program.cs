namespace HW_Task4
{
    public class Program
    {
        public static void Main (string [] args){
        // Задайте двумерный массив из целых чисел. 
        // Напишите программу, которая удалит строку и столбец,
        // на пересечении которых расположен наименьший элемент массива. 
        // Под удалением понимается создание нового двумерного массива без строки и столбца
        int row = 4;
        int col = 3;
        int min = 1;
        int max = 9;
        int [,] dimArray = InitDimArray(row, col, min, max);
        PrintDimArray(dimArray);
        int [] minIndex = FindMinDimArray(dimArray);
        System.Console.WriteLine($"min i = {minIndex[0]}, min j = {minIndex[1]}, min number = {dimArray[minIndex[0],minIndex[1]]}");
        System.Console.WriteLine();
        int [,] modDimArray = ModDimArray(dimArray, minIndex);
        PrintDimArray(modDimArray);
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
        static public void PrintDimArray (int [,] array){
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
        static public int [] FindMinDimArray (int [,] dimArray){
            int row = dimArray.GetLength(0);
            int col = dimArray.GetLength(1);
            int min = dimArray[0,0];
            int [] minIndex = new int [2];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (dimArray[i,j] < min)
                    {
                        min = dimArray[i,j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }
            return minIndex;
        }
        public static int [,] ModDimArray (int [,] dimArray, int [] minIndex){
            int row = dimArray.GetLength(0) - 1;
            int col = dimArray.GetLength(1) - 1;
            int [,] modDimArray = new int [row,col];
            bool flagCol = false;
            bool flagRow = false;
            for (int i = 0; i < row; i++)
            {
                if (i == minIndex[0]) flagRow = true;
                flagCol = false;
                for (int j = 0; j < col; j++)
                {
                    if (j == minIndex[1]) flagCol = true;
                    if (!flagRow && !flagCol) modDimArray[i,j] = dimArray[i,j];
                    if (!flagRow && flagCol) modDimArray[i,j] = dimArray[i,j+1];
                    if (flagRow && !flagCol) modDimArray[i,j] = dimArray[i+1,j];
                    if (flagRow && flagCol) modDimArray[i,j] = dimArray[i+1,j+1];
                }
            }
            return modDimArray;
        }
    }
}