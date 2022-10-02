/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(1, 30);
        index++;
    }
}

void PrintArray(int[] array2)
{
    int count = array2.Length;
    int position = 0;
    Console.Write("[");
    while (position < count - 1)
    {
        Console.Write($"{array2[position]}, ");
        position++;
    }
    Console.Write($"{array2[position]}]");
}

int MaxArray(int[] array3)
{
    int Max = 0;
    int index1 = 0;
       while ( index1 < array3.Length)
    {
        if (array3[index1] > Max)Max = array3[index1];
        index1++;
    }
    return (Max);
}

int MinArray(int[] array4) // метод поиска минимального без привязки к значению Max
{
    int min = array4[0];
for (int i = 1; i < array4.Length; i++)
{
	if (array4[i] < min) min = array4[i];
}
  return min;
}


// int MinArray(int[] array4) // метод поиска минимального через вызов метода поиска максимального
// {
//     MaxArray(array4);
//     int Max = MaxArray(array4);
//     int index2 = 0;
//     int Min = Max;
//     while ( index2 < array4.Length)
//     {
//         if (array4[index2] < Min)Min = array4[index2];
//         index2++;
//     }
//     return (Min);
// }

int[] array = new int[4];
FillArray(array);
PrintArray(array);
int Max = MaxArray(array);
int Min = MinArray(array);
int result = Max - Min;
Console.WriteLine($" -> {result} - разница между максимальным и минимальным элементом массива.");