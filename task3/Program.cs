// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// void array(string[] args)
// {
//     int[] Array = new int[8];
// }

// Random num = new Random();
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = num.Next(1000);
//     System.Console.WriteLine(Array);
// }


PrintArr(GetRan (8));
System.Console.Write($"]");
int [] GetRan (int length)
{
    System.Console.Write($"[");
    int [] result = new int [length];
    for (int i = 0; i< length ; i++)
    {
        result [i] = new Random ().Next (0, 1000);
    }
    return result;
}

void PrintArr(int [] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item},");
    }
}