//Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear(); 
Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр --> {SumNumber(number)}");
Console.WriteLine(" ");

int SumNumber (int num)
{
    if (num < 0) num *= -1;
    int sum = 0;
    for (int i = 0; num > 0; i++)  
        { 
            sum = sum + num%10;
            num /= 10;  
        }  
    return sum;
}
