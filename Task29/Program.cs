// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];

FillArray(array);
PrintArray(array);


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}");
    Console.Write("]");
}