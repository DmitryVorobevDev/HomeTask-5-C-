//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве
int GetResult (int len)
{
    int [] arr = new int [len];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(100,1000);
        if (arr [i] %2 == 0) count++;
    }
    Console.WriteLine(String.Join(" | ", arr));
    return count;
}

Console.WriteLine("Количество четных чисел в массиве: " + GetResult(10));
