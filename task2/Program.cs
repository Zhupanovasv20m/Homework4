// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int count = Convert.ToString(num).Length;
    int step = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        step = num % 10;
        result = result + step;
        num = num / 10;
    }
    return result;
}

int sum = Sum(num);
Console.WriteLine($"{num} => {sum}");

