/*
 Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FillArray(int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] collection)             
{
    int count = collection.Length;
    int position = 0;
    Console.Write("[");
    while (position < count - 1)
    {
        Console.Write($"{collection[position]}, ");
        position++;
    }
    Console.Write($"{collection[position]}]");
}

int EvenNumbers(int[]array2)
{
    int i=0;
    int count2 = 0;
    while (i < array2.Length)
    {
        if ( array2[i] % 2 == 0) count2++;
    i++;   
    }
    return (count2);
}

int [] array = new int [7];
FillArray(array);
PrintArray(array);
int number = EvenNumbers(array);
Console.WriteLine($" -> {number} четных чисел в массиве");