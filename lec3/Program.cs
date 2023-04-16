
// Вывод таблицы уможения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j =2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// _________________________________________________________________________________
// _________________________________________________________________________________

// Замена символов пробелы замнить на | маленькик к на К большие С на с

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//     + "ежели бы вас послали вместо нашего милого Винценгероде,"
//     + "вы бы взяли приступом согласие прусского короля. "
//     + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i ++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// string newText1 = Replace(newText, 'к', 'К');
// string newText2 = Replace(newText1, 'С', 'с');
// Console.WriteLine(newText2);

// _________________________________________________________________________________
// _________________________________________________________________________________

// sort array from min to max
int [] arr = {1,3,4,5,6,7,8,9,1,5,3,4,8,8,9};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++ ) 
    {
        Console.Write($"{array[i]}");
    }
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i+1; j < array.Length; j ++)
        {
            if (array[j] < array[minPos] ) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

PrintArray(arr);

SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);