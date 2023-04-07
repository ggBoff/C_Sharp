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

    // 12 Program wich make can we a/b without a tail  a=9, b = 3 -> 9 is multiple 3.

// Console.WriteLine("Enter numbers a and b   to check is a multiple b");

// Console.WriteLine("enter number a");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("enter number b");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num1 % num2;

// if (result == 0)
//     Console.WriteLine($"{num1} is multiple {num2}");
// else
//     Console.WriteLine($"{num1} is not multiple {num2}, remainder is {result}");
//________________________________________________________________________
//________________________________________________________________________
// Write programm wich input number and check if it multiple 7 and 23


// Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());


// if (num % 7 == 0 & num % 23 == 0)
//     Console.WriteLine("Yes");
// else 
//     Console.WriteLine("No");

    //________________________________________________________________________
    //________________________________________________________________________


//Enter numbers a and b   to check is a^2= b or n^2=a

// Console.WriteLine("Enter numbers a and b   to check is a^2= b or n^2=a");

// Console.WriteLine("enter number a");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("enter number b");
// int num2 = Convert.ToInt32(Console.ReadLine());

// // Math.Abs - module; Math.Pow - vosvedenie v stepen'

// if (Math.Abs(Math.Pow(num1,2)) == num2 || Math.Abs(Math.Pow(num2,2)) == num1)
//     Console.WriteLine("Yes");
// else 
//     Console.WriteLine("No");

//__________________________________________________________________________________________________________
//__________________________________________________________________________________________________________
// delete second digit of any number

//__________________________________________________________________________________________________________
// variant WITHOUT USING STRING - why not 


// Console.WriteLine("Enter number");

// double num = Convert.ToDouble(Console.ReadLine());
// double count = 0;
// double numForCount = num;
// if (num >= 10)
//     {
//     while (numForCount > 1)
//     {
//         numForCount = numForCount / 10;
//         count++;
//     }
//     Console.WriteLine($"Count for / = {count}");
        
//     int firstNum = Convert.ToInt32(num);
//     while (firstNum > 10 )
//         {
//             firstNum = firstNum / 10;
//         }
//     Console.WriteLine(firstNum);

//     int secondNum =Convert.ToInt32(num);
//     while (secondNum > 100 )
//         {
//             secondNum = secondNum / 10;
//         }
//     secondNum = secondNum - firstNum*10;
//     Console.WriteLine(secondNum);

//     double res = num;
//     while (res > 100)
//         {
//             res = res / 10;
//         }

//     int change = secondNum - firstNum;
//     res = Convert.ToDouble(res -(firstNum*10 + change));

//     res = res * (Math.Pow(10, (count-2)));
//     Console.WriteLine($"{num} with deleted 2d degit is {res}");
//     }
// else 
//     {   
//     int firstNum = Convert.ToInt32(num);
//     while (firstNum > 10 )
//         {
//             firstNum = firstNum / 10;
//         }
//     Console.WriteLine($"First num is {firstNum}");

//     int secondNum =Convert.ToInt32(num*10);
//     while (secondNum > 100 )
//         {
//             secondNum = secondNum / 10;
//         }
//     secondNum = (secondNum - firstNum*10);
//     Console.WriteLine($"Second num is {secondNum}");

//     double res = num;
    
//     Console.WriteLine($"res ={res}");

//     int change = secondNum - firstNum;
//     Console.WriteLine($"Change = {change}");

//     res = Convert.ToDouble(res*10 -((firstNum*10 + change)));
//     Console.WriteLine($"{num} after deliting second digit ={res}");
//     }
   
   //__________________________________________________________________________________________________________
// 
   double arc = Convert.ToDouble(Console.ReadLine());
   string f1 = arc.ToString();
   string result1 = "";
    int i = 0;
   for (i = 0; i < f1.Length; i++)
   {
    if (((f1[i] == '.') || (f1[i] == ',')) & (i == 1))
        {
            result1 += f1[i];
            i = i + 1;
            continue;
        }
    if (i != 1){
        result1 += f1[i];
    }
   }
    Console.WriteLine(result1);

