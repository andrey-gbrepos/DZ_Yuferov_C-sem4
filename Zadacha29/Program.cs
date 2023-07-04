//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear(); 
Console.WriteLine("Программа задает массив из 8 элементов и выводит их на экран");
                                            Console.WriteLine();
Console.Write("Введите минимальное значение в массиве:");
int minValue = EnterParam ();
                                            Console.WriteLine();
Console.Write("Введите максимальное значение в массиве:");
int maxValue = EnterParam ();
                                            Console.WriteLine();
Console.Write($"{String.Join(", ", Fillarr(minValue, maxValue))}");
                                            Console.WriteLine();

// Метод - Ввод параметров
int EnterParam ()
{
int val = Convert.ToInt32(Console.ReadLine()); return val;
}
// метод - Заполнение массива
int[] Fillarr (int min, int max)
{
    int[] arr = new int[8];
        
    for (int i = 0; i < 8; i++) arr[i] = new Random().Next(min,max+1);
    
    return arr;
}