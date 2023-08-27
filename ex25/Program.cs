//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

double numPow (int num, int pow){
    int powResult = num;
    for (int i = 2; i <= pow; i++)
    {
       powResult *= num; 
    }
    return powResult;
}

int numA = InputNum("Input num: ");
int pow = InputNum("Input pow: ");
System.Console.WriteLine(numPow(numA, pow));
