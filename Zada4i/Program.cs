// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 

Console.Write("Введите пятизначное число: ");
Link1:
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[5];
int i = 0;

if ((N / 10000 >= 10) || (N / 10000 == 0))                         
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Вы ввели НЕ ПЯТИЗНАЧНОЕ число!!!!! ");
    Console.Write("Введите КОРРЕКТНОЕ ПЯТИЗНАЧНОЕ число: ");
    Console.ForegroundColor = ConsoleColor.White;
    goto Link1;                                                     
}
else
{
    for (i = 4; i >= 0; i--)
    {
        array[i] = N % 10;
        N = N / 10;
    }

    if ((array[0] == array[4]) && (array[1] == array[3]))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("ДА!!! Число является полиндромом!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else { Console.Write("нет:( Это не полиндром"); }
}





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите координаты X1: ");
// int X1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите координаты Y1: ");
// int Y1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите координаты Z1: ");
// int Z1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите координаты X2: ");
// int X2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите координаты Y2: ");
// int Y2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите координаты Z2: ");
// int Z2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2)):f2}");





// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125


// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// for (int i = 1; i <= N; i++)
// {
//     if (i < N) 
//     {
//     Console.Write($"{Math.Pow(i, 3)}, ");
//     }
//      if (i == N) 
//     {
//     Console.Write($"{Math.Pow(i, 3)}");
//     }
// }

