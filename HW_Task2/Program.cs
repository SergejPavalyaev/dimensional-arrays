namespace HW_Task2
{
    public class Program
    {
        static public void Main (string [] args){
        // Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
        int row = 3;
        int col = 3;
        int min = 0;
        int max = 9;
        int [,] dimArray = InitDimArray(row, col, min, max);
        PrinDimArray(dimArray);
        System.Console.WriteLine();
        dimArray = ModDimArray(dimArray);
        PrinDimArray(dimArray);
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
        static public int [,] ModDimArray (int [,] dimArray){
            int row = dimArray.GetLength(0);
            int col = dimArray.GetLength(1);
            int [,] thDimArray = dimArray; 
            int temp = 0;
            for (int i = 0; i < col; i++)
            {
                temp = thDimArray[0,i];
                thDimArray[0,i] = thDimArray[row-1,i];
                thDimArray[row-1,i] = temp;
            }
            return thDimArray;
        }
    }
}