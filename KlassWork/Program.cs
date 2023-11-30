namespace KlassWork
{
    public class Program
    {
        static public void Main (string [] args){
                int row = 3;
                int col = 5;
                int min = 0;
                int max = 9;
                int [,] dimArray = InitDimArray (row,col,min,max);
                PrinDimArray(dimArray);
                System.Console.WriteLine();
                // Task 1:
                // dimArray = ModDimArrayTask1(dimArray);
                // PrinDimArray(dimArray);

                // Task 2. Задайте двумерный массив. 
                // Найдите сумму элементов, находящихся 
                // на главной диагонали (с индексами (0,0); (1;1) и т.д.
                // int summ = SummCheafDiag(dimArray);
                // System.Console.WriteLine($"Summ on cheaf diagonal = {summ}");

                // Task 3. Задайте двумерный массив из целых чисел. 
                // Сформируйте новый одномерный массив, состоящий из средних 
                // арифметических значений по строкам двумерного массива.
                int [] array = CreateArrayFromDim(dimArray);
                PrintArray(array);
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
        }
        static public int [,] ModDimArrayTask1 (int [,] array){
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0) array [i,j] = (int)Math.Pow(array[i,j],2);
                } 
            }
            return array;
        }
        public static int SummCheafDiag (int [,] array){
            int summ = 0;
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == j) summ += array[i,j];
                }
            }
            return summ;
        }
        public static void PrintArray (int [] array){
            foreach (int item in array)
            {
                System.Console.Write(item + " ");
            }
        }
        public static int [] CreateArrayFromDim (int [,] dimArray){
            int row = dimArray.GetLength(0);
            int col = dimArray.GetLength(1);
            int [] array = new int [row];
            int temp;
            for (int i = 0; i < row; i++)
            {
                temp = 0;
                for (int j = 0; j < col; j++)
                {
                    temp += dimArray[i,j];
                }
                array[i] = temp / col;
            }
            return array;
        }
    }
}