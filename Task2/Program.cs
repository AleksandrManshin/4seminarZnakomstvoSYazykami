void Zadacha26()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Количество знаков в числе {number} равно {MethodSRaschetom(number)}");


int MethodSRaschetom(int number)
{   
    int count = 1;
    while(number/10 > 0)
    {
        number = number/10;
        count++;
    }
    return count;
}
}

Zadacha26();