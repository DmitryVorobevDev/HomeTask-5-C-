// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double GetResult (int len)
{
    double [] arr = new double [len];
    for (int i = 0; i < arr.Length; i++) arr [i] = Convert.ToDouble(new Random().Next(-100,101)/10.0); 
    double min = arr [0];
    double max = arr [0];
    for (int i2 = 0; i2 < arr.Length; i2++)
    {
        if (arr [i2] > max) max = arr [i2];
        if (arr [i2] < min) min = arr [i2];
    }
    Console.WriteLine(String.Join(" | ", arr));
    double dif = max - min;
    return dif;
}

Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + GetResult(10));
