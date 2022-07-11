// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int GetResult (int len)
{
    int [] arr = new int [len];
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(-10,11);
        if (i%2 == 0) sum += arr[i];
    }
   
    Console.WriteLine(String.Join(" | ", arr));
    return sum;
}

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + GetResult(10));
