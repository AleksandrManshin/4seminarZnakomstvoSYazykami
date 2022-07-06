void Zadacha19()
{
    int number = 16361;
    int digitOnes = number%10;
    int digitTens = number/10 %10;
    int digitThousands = number/1000 %10;
    int digitTenOfThousands = number/10000;

    if(digitOnes == digitTenOfThousands && digitTens == digitThousands)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

Zadacha19();