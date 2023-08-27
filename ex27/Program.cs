// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int SummDigitsInNum(int num)
{
    int sum = 0;

    while (num != 0)
    {
        sum +=  num % 10;
        num = num / 10;

    }
    return sum;
}
int num = InputNum("Input number: ");
System.Console.WriteLine(SummDigitsInNum(num));