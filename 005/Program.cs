void Fillrray(int[] array)   
{
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(1, 10);
    }
}
void WriteArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];

Fillrray(array);
WriteArray(array);

int newSizeArray = 0;
if (sizeArray % 2 == 0)
{
    newSizeArray = sizeArray / 2;
}
else
{
    newSizeArray = (sizeArray / 2) + 1;
}

int[] newArray = new int[newSizeArray];
for(int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length - (1 + i)];
}

if (sizeArray % 2 != 0)
{
    newArray[newArray.Length - 1] = array[newArray.Length -1];
}

WriteArray(newArray);
