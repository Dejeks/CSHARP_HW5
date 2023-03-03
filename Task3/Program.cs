/*Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. */

System.Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(System.Console.ReadLine());


float [] GenerateArray (int length)
{
    Random random = new Random();
    float[] arr = new float[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.Next(100);
    }
    return arr;
}

float FindMax(float [] arr)
{
    float max = arr[0];
    for(int i = 0; i < arr.Length ; i++)
    {
        if(max < arr[i])
            max = arr[i];
    }
    return max;
}

float FindMin(float [] arr)
{
    float min = arr[0];
    for(int i = 0; i < arr.Length ; i++)
    {
        if(min > arr[i])
            min = arr[i];
    }
    return min;
}

void OutputArray(float [] arr)
{
    System.Console.Write("Массив: ");
    for(int i = 0; i < arr.Length ; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
}

float [] array = GenerateArray(length);

float result = FindMax(array) - FindMin(array);
OutputArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальное значение массива: {FindMax(array)}, Минимальное значение: {FindMin(array)}" + 
",\n" + $"Разница между максимальным и минимальным: {result}." );