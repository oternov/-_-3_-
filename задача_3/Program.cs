// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[7];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i] + " ");
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
Console.WriteLine("максимум " + max);
Console.WriteLine("минимум " + min);

double result = max - min;
string res = string.Format("{0:f}", result); // преобразование вывода до двух знаков после запятой

Console.WriteLine ("Разница между максимальным и минимальным элементом равна " + res);