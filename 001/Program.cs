int [] numbers = new int [12];
FillArray(numbers);

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    {
        sumPositive += numbers[i];
    }
    else 
    {
        sumNegative += numbers[i];
    }
}

Console.WriteLine($"Сумма положительных: {sumPositive}. Сумма отрицательных: {sumNegative}");


void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);

    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}


