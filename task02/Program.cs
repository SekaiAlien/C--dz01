// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Напиши какое-нибудь число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напиши еще какое-нибудь число, а я их сравню: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB)
{
    Console.WriteLine("Ого! Да они же равны!");
}

else
{
    if(numberA > numberB)
    {
    Console.WriteLine();
    Console.Write(numberA);
    Console.WriteLine(" больше второго числа");
    Console.Write("А меньшее число: ");
    Console.WriteLine(numberB);
    }

    else
    {
        Console.WriteLine();
        Console.Write(numberB);
        Console.WriteLine(" больше первого числа");
        Console.Write("А меньшее число: ");
        Console.WriteLine(numberA);
    }
}