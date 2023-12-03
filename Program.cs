//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве
Random rand = new Random();
int size = 10;
int [] array = new int[size];
for (int i=0; i< size; i++) {
    array [i] = rand.Next (1,100);
}
int count = 0;
for (int i=0; i<size; i++)
if (array [i]%2 ==0)
{
     count++;
}
foreach (int item in array)
{
    Console.Write (item + " ");
}
Console.Write ($"----> {count}");
