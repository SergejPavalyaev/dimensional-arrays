namespace HW_Task1
{
    public class Program
    {
        static public void Main (string [] args){
            // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            // и возвращает значение этого элемента или же указание, что такого элемента нет.
            int row = 3;
            int col = 3;
            int min = 1;
            int max = 9;
            int [,] dimArray = InitDimArray(row, col, min, max);
            PrinDimArray(dimArray);
            System.Console.Write("Input number of string => ");
            int indexRow = InputNumber();
            System.Console.Write("Input number of column => ");
            int indexCol = InputNumber();
            System.Console.WriteLine();
            if (indexCol < col && indexRow < row) System.Console.WriteLine($"Required number => {dimArray[indexRow-1,indexCol-1]}");
            else System.Console.WriteLine($"DimArray doesn't have required number");
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
         public static int InputNumber ()
        {
            string ? input = string.Empty;
            int number = 0;
            bool flag = false;
            bool flag2 = false;
            while (!flag2)
            {
                while (!flag)
                {
                    try
                    {
                    input = System.Console.ReadLine();
                    number = Convert.ToInt32(input);
                    flag = true;
                    }
                    catch (System.Exception)
                    {
                    System.Console.WriteLine("Error, input natural number:");
                    }
                }
            if (number > 0)
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Error, input natural number:");
                flag = false;
            }
            }
            return number;
        }
    }
}