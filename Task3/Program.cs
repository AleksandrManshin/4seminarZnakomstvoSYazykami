void Zadacha28()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Произведение всех чисел от 1 до {number} равна " + Raschet(number));
}

int Raschet(int numb)
{
    int sum = 1;
    for (int i = 1; i <= numb; i++)
    {
        sum = sum * i;
 
    }
    return sum;
}

Zadacha28();