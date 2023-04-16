// See https://aka.ms/new-console-template for more information

double f(double x) // возвращаемый тип данных название(тип аргумента имя аргумента)
{
    double result = x * x +1;
    return result; // тело мметода -  {функция; возвращаемое значение}
}

double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(f(x));
