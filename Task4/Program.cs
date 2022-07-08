void Zadacha30()
{   
    int size = 8;
    int [] array = new int [size];
    array = FillArrayFunction(size);
    PrintArray(array);
}

int [] FillArrayFunction(int size)
{
    int [] fillArray = new int [size];
    Random random = new Random();
    for(int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = random.Next(0, 2);
    }
    return fillArray;
}

void PrintArray(int [] array)
{
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

Zadacha30();