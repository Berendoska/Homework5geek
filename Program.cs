using System.Collections.ObjectModel;

//Задача 34:
// Задайте массив заполненный 
//случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество
//чётных чисел в массиве.
void CreateArray(int[] collection) //заполение массива
{
    int length = collection.Length;
   
    for(int i=0; i<length; i++)
    {
        collection[i] = new System.Random().Next(100, 999);
    }
}


void Print1DArray(int[] col) //печатаем массив
{
     int count = col.Length;
     int position = 0;
     Console.Write("[");
  
   
    while (position < count)
    {
        Console.Write(col[position] + " "  );
        position++;

    }
    Console.Write("]");
     
   
}


int[] arr = new int[4];
CreateArray(arr);
Print1DArray(arr);
int count = 0;  //здесь надоим четные
for (int a = 0; a < arr.Length; a++)
if (arr[a] % 2 == 0)
count++;

Console.WriteLine($"всего {arr.Length} чисел, {count} из них чётные");

//Задача 36
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
void CreateArray2(int[] collection) //заполение массива
{
    int length = collection.Length;
   
    for(int i=0; i<length; i++)
    {
        collection[i] = new System.Random().Next(-100, 100);
    }
}
int[] arr2 = new int[4];
CreateArray2(arr2);
Print1DArray(arr2);

int sum = 0; //находим сумму
for (int i = 1; i < arr2.Length; i+=2)
{
    
        sum += arr2[i];
}
Console.WriteLine($"Сумма нечетных позиций = {sum}");

//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
void CreateArray3(double[] collection) //берем переменную double, так как числа вещественные
{
   double length = collection.Length;
   
    for(int i=0; i<length; i++)
    {
        collection[i] = new System.Random().Next(-100, 100);
    }
}
void Print1DArray2(double[] col)
{
     int count = col.Length;
     int position = 0;
     Console.Write("[");
  
   
    while (position < count)
    {
        Console.Write(col[position] + " "  );
        position++;

    }
    Console.Write("]");
     
   
}


double[] arr3 = new double[4];
CreateArray3(arr3);
Print1DArray2(arr3);
//Difference(arr3);
double maxNumber = arr3[0];
double minNumber = arr3[0];

  for (int i = 1; i < arr3.Length; i++)
  {
    if (maxNumber < arr3[i])
    {
      maxNumber = arr3[i];
    }
        if (minNumber > arr3[i])
    {
      minNumber = arr3[i];
    }
  }

  double decision = maxNumber - minNumber;
  Console.WriteLine($"Разница между минимальным и максимальным, {decision} ");