// See https://aka.ms/new-console-template for more information

// double f(double x) // возвращаемый тип данных название(тип аргумента имя аргумента)
// {
//     double result = x * x +1;
//     return result; // тело мметода -  {функция; возвращаемое значение}
// }

// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(f(x));
// _________________________________________________________________________________________
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;  
//     return result  ;
// }
// задаем переменные без массива
        // int a1 = 1115;
        // int b1 = 2;
        // int c1 = 5;

        // int a2 = 2235;
        // int b2 = 45;
        // int c2 = 55;

        // int a3 = 605;
        // int b3 = 175;
        // int c3 = 85;

// Код без метода
        // int max = a1;
        // if (b1 > max) max = b1;
        // if (c1 > max) max = c1;

        // if (a2 > max) max = a2;
        // if (b2 > max) max = b2;
        // if (c2 > max) max = c2;

        // if (a3 > max) max = a3;
        // if (b3 > max) max = b3;
        // if (c3 > max) max = c3;
        
// код с методом
        // int max1 = Max (a1, b1, c1);
        // int max2 = Max (a2, b2, c2);
        // int max3 = Max (a3, b3, c3);
        // // int max = Max (max1, max2, max3);
        // int max = Max(Max (a1, b1, c1),
        // Max (a2, b2, c2),
        // Max (a3, b3, c3));

// задаем переменные с массивом
//              0  1   2  3  4  5  6  7  8
// int [] array = {11,12,13,21,22,23,31,32,33};
// int max = Max (
//     Max (array[0],array[1], array[2]),
//     Max (array[3],array[4], array[5]),
//     Max (array[6],array[7], array[8])
// );

// Console.WriteLine(max);

// _________________________________________________________________
// _________________________________________________________________
//              0  1   2  3  4  5  6  7  8
// int [] array = {11,12,13,21,22,23,31,32,23};

// int n = array.Length;
// int find = 23;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find) {Console.WriteLine(index);break;}
//     index++;
// }

// _________________________________________________________________
// _________________________________________________________________

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
        {
        collection[index]=new Random().Next(1,10);
        index++;
        }
}

void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if (collection[index] == find) {position = index;    break;}
        
    index++;
    }

    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine(" ");

int pos =IndexOf(array,4);
Console.WriteLine(pos);