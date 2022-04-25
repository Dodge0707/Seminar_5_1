Console.Write("Введите количество элементов массива -> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[number];


FillArray(numbers);
WriteArray(numbers);
ConvertArray(numbers);
WriteArray(numbers);

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10, 11);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ConvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i]= array[i] * -1;
    }
}



