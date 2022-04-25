Console.Write("Введите количество элементов массива -> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[number];
Console.Write("Введите число: ");
int aNumber = Convert.ToInt32(Console.ReadLine());


FillArray(numbers);
WriteArray(numbers);
FindArray(numbers, aNumber);


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

void FindArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            Console.WriteLine("Да!");
            break;
        }
        else 
        {
            if (i == array.Length - 1)
            {
                Console.WriteLine("Нет!");
            }
        }
        
    }
}