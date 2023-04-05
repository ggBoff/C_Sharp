// Random number [10;99] , program need to show max digit from RandomNumber

// int num = new Random().Next(10,100);
// Console.WriteLine($"Was generated random number {num}");

// int x1 =num / 10;
// int x2 = num % 10;

// if (x1 > x2)
//     Console.WriteLine($"Max number is {x1}");
// else if (x1 == x2)
//     Console.WriteLine($"numbers are equal {x1}={x2}");
// else
//     Console.WriteLine($"Max number is {x2}");

// // Ouytput all numbers from 1 to GeneratedRandomNum

// for (int i = 1; i<=num; i++)
//     Console.Write(i + " ");

//____________________________________________________________________
//____________________________________________________________________

// Write a 3d digit number. program is deliting 2d digit of the number
// example 321 -> 31
// Console.WriteLine("Enter number from 100 to 999");
// int num = Convert.ToInt32(Console.ReadLine());


// if (num > 100 & num < 1000)
// {
//     int x1 = num / 100;
//     Console.WriteLine(x1);
    
//     int x2 = (num % 100) / 10;
//     Console.WriteLine(x2);

//     int x3 = num % 10;
//     Console.WriteLine(x3);

//     int newNum = x1*10 + x3;
//     Console.WriteLine(newNum);
// }
// else 
//     Console.WriteLine("Pls use only number from 100 to 1000");

    //________________________________________________________________________
    //________________________________________________________________________

    // 12 Program wich make can we a/b without a tail  a=9, b = 3 -> 9 is "Kratno" 3 )))

Console.WriteLine("Enter numbers a and b   to check is a multiple b");

Console.WriteLine("enter number a");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter number b");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;

if (result == 0)
    Console.WriteLine($"{num1} is multiple {num2}");
else
    Console.WriteLine($"{num1} is not multiple {num2}, remainder is {result}");