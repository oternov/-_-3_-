// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

using System.ComponentModel;

double[] array = new double[7];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i].ToString("F2") + " "); // вывод массива с округлением до двух знаков после запятой
}

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine();

string smax = max.ToString("F2"); // преобразование числа max до двух знаков после запятой
string smin = min.ToString("F2"); // преобразование числа min двух знаков после запятой
Console.WriteLine("максимум " + smax);
Console.WriteLine("минимум " + smin);

double result = max - min;
string res = result.ToString("F2"); // преобразование вывода до двух знаков после запятой

Console.WriteLine ("Разница между максимальным и минимальным элементом равна " + res);