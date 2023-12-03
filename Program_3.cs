//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива
    Console.Write("Введите количество элементов массива:");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write("{0: 0.00}",randomArray[i]);
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
 i++;
}
return max-min;
}

mas(a);
Console.WriteLine("  Разница между max и min элементом массива ===>");
Console.WriteLine("{0: 0.00}",raz(randomArray));