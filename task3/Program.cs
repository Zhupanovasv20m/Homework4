// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int [] Array = GetRandomArray (8);

for (int i = 0; i < Array.Length; i++)
{
    Array [i] = new Random().Next(0, 10000);
    System.Console.WriteLine(" " + PrintArray (i) + " ");
}


void PrintArray (int [] Array)
{
    foreach (int item in Array)
    {
        System.Console.WriteLine(item);
    }
}
System.Console.WriteLine(item + " " );