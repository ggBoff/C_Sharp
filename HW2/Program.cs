﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Input 3digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(num) > 999)
//         Console.WriteLine("Try again)");
// else if (num < 0 & num > -999)
// {
//    string a = num.ToString();
//     Console.WriteLine(a[2]); 
// }
// else
// {
//     string a = num.ToString();
//     Console.WriteLine(a[1]);
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(num) >= 100)
// {
//     int firstNum = Convert.ToInt32(num);
//     while (firstNum > 10 )
//         {
//             firstNum = firstNum / 10;
//         }
    

//     int secondNum =Convert.ToInt32(num);
//     while (secondNum > 100 )
//         {
//             secondNum = secondNum / 10;
//         }
//     secondNum = secondNum - firstNum*10;
   
//     int thirdNum =Convert.ToInt32(num);
//     while (thirdNum > 1000 )
//         {
//             thirdNum = thirdNum / 10;
//         }
//     thirdNum = thirdNum - firstNum*100 - secondNum*10;
//     Console.WriteLine(thirdNum);
// }
// else
//     Console.WriteLine("There is no 3d num");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num <= 7) & (num >=1))
// {
//     {
//         if (num == 6 || num == 7)
//             Console.WriteLine("yes");
//         else
//             Console.WriteLine("no");
//     }
// }
// else    Console.WriteLine("Try more");
// 6 -> да
// 7 -> да
// 1 -> нет

// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
// Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, 
// но нужно получить наиболее простое и красивое решение.

int i = 1;
string count = "";
  for(i = 1;i < 101;i++)
  { 
    string n=Convert.ToString(i),  f = "Fizz", b="Buzz"; 
    if(i%15 == 0)
        count =" " + f + b;
    else 
     {
        if(i%3==0)
            count =" " + f;
        else  
        {
            if(i%5==0)
                count =" " + b;
            else
                count =" " + n; 
        }
     }
    Console.Write(count);
  }
// Задача необязательная 2:

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу,
// по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное),
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально 
// общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, 
//как минимум до 1000 человек.