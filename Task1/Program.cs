/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

System.Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(System.Console.ReadLine());


int [] GenerateArray (int length)
{
    Random random = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}

int NumberOfEven(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length ; i++)
    {
        if(arr[i] % 2 == 0)
            count++;
        
    }
    return count;
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

System.Console.WriteLine("Количество четных чисел: " + NumberOfEven(array));