//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear(); 
Console.WriteLine("Программа принимает на вход два числа A и B и возводит число A в натуральную степень B");
Console.WriteLine();
int[] arrAB = new int[2];
FilArr (arrAB);
Console.WriteLine($"{arrAB[0]} ^ {arrAB[1]} = {Math.Pow(arrAB[0], arrAB[1])}");
Console.WriteLine();

int[] FilArr (int[] arr)
{
Console.Write("Введите число A: ");
arr[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число B: ");
arr[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();  
return arr;
}





