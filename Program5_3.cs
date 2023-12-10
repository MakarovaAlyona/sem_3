//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 int[,] twoDimArray=CreateTwoDimArray(4,4,1,9);
    Console.WriteLine ("Массив: ");
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
}
int SumLine(int[,] twoDimArray, int i)
{
int sum = twoDimArray[i,0];
for (int j = 1; j < twoDimArray.GetLength(1); j++)
{
sum += twoDimArray[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(twoDimArray, 0);
for (int i = 1; i < twoDimArray.GetLength(0); i++)
{
if (sum > SumLine(twoDimArray, i))
{
sum = SumLine(twoDimArray, i);
minSum = i+1;
}
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");