//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
int[,] twoDimArray=CreateTwoDimArray(3,3,1,9);
    Console.WriteLine ("Исходный массив: ");
    Print (twoDimArray);
    Console.WriteLine ("Новый массив: ");
    Print (ModArray(twoDimArray));
    

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

static void Print (int[,]array)
{
    int rows=array.GetLength(0);
    int cols=array.GetLength(1);
    for (int i=0; i<rows; i++){
        for (int j=0; j<cols;j++)
        {
         Console.Write (array[i,j] +"\t");
        }
         Console.WriteLine();
    }
}
static int[,] ModArray(int[,]array){
     {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (i > 0 && i < array.GetLength(1))
            {
                int temporary = array[i, j];
                array[i, j] = array[i, j];
                array[i, j] = temporary;
            }
            else
            {
                int temporary = array[i, j];
                array[i, j] = array[(array.GetLength(1) - 1), j];
                array[(array.GetLength(1) - 1), j] = temporary;
            }
        }
    }
    return array;
}
}