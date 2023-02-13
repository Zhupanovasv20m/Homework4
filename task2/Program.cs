// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (num > 0)
{
    int count = num % 10;
    result = result + count;
    num = num / 10;
}
System.Console.WriteLine(result);
