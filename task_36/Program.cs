/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(-10, 10);
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

int EvenSum (int[] array3)
{
int sum = 0;
for (int index1 = 0; index1 < array3.Length; index1++) 
{
    if (index1%2 != 0)  sum = sum + array3[index1];
}
return(sum);
}

int [] array = new int [4];
FillArray(array);
PrintArray(array);
int number = EvenSum(array);
Console.WriteLine($" -> {number} - сумма элементов, стоящих на нечётных позициях массива");