/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

System.Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(System.Console.ReadLine());


int [] GenerateArray (int length)
{
    Random random = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.Next(100);
    }
    return arr;
}

int SumOfOdd(int [] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length ; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}

void OutputArray(int [] arr)
{
    System.Console.WriteLine("Массив: ");
    for(int i = 0; i < arr.Length ; i++)
    {
        System.Console.Write(arr[i] + ",");
    }
}

int[] array = GenerateArray(length);

OutputArray(array);

System.Console.WriteLine("Сумма чисел на нечетных позициях: " + SumOfOdd(array));