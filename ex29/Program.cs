// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
void FillArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,8);
    }
}
void PrintArray(int[] array){
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }

}
int arraySize = InputNum("Input size of array: ");
int[] array = new int[arraySize];
FillArray(array);
PrintArray(array);