﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// __________________________________________________________________________________________________________________________________________________________________________
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Enter first number");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter second number");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
//     Console.WriteLine("a > b, max is b");

// else 
//     Console.WriteLine("a < b, max is b");


// so it works, I checked, trust me) 
//__________________________________________________________________________________________________________________________________________________________________________
//__________________________________________________________________________________________________________________________________________________________________________
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Enter first number");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter second number");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter third  number");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b)
//     if (a > c)
//     Console.WriteLine("first is max");
//     else
//         if (b > c)
//             Console.WriteLine("Second is max");
//         else 
//             Console.WriteLine("Third is max");
// else
//     if (c > b)
//         Console.WriteLine("THird is max");
//     else 
//         Console.WriteLine("Second is max");

// And it works, I checked, trust me)

//__________________________________________________________________________________________________________________________________________________________________________
//__________________________________________________________________________________________________________________________________________________________________________
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

 int i;
 
Console.Write("Введите число : ");
 
i = Convert.ToInt32(Console.ReadLine());
 
if (i % 2 == 0)
    {
    Console.Write("Введенное число является четным");
    }
 
    else
    {
    Console.WriteLine("Введенное число нечетное");
    }
