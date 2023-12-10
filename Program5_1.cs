//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
using System.Runtime.InteropServices;


    int[,] twoDimArray=CreateTwoDimArray(3,3,1,9);
    Console.WriteLine ("Есть массив: ");
    Print (twoDimArray);
    

static int [,] CreateTwoDimArray (int rows,int cols,int min,int max)
{

    int [,] twoDimArray = new int [rows, cols];
    Random rand = new();
    for (int i=0;i<rows;i++)
    { for (int j=0;j<cols;j++) {
        
    twoDimArray [i,j]=rand.Next (min,max+1);
    }
    }

    return twoDimArray;
}

static void Print (int[,]array){
    int rows=array.GetLength(0);
    int cols=array.GetLength(1);
    for (int i=0; i<rows; i++){
        for (int j=0; j<cols;j++)
        {
         Console.Write (array[i,j] +"\t");
        }
         Console.WriteLine();
    }
   

Console.WriteLine("Введите строку:");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите столбец:");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>rows && b>cols)
 Console.WriteLine("Такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine($"Этот элемент=> {c}");
 }
}