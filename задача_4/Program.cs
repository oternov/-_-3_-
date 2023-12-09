// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int K = 0;
int P = N;

while (P % 10 > 0)
{
    K = K+1;
    P = P / 10;
}

int[] array = new int[K];
int[] array2 = new int[K];

if (N >= 1 && N <= 100000)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = N % 10;
        N = N/10;  
    }
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array[array.Length-1-i];
        Console.Write(array2[i] + " ");
    }
}
else
{
    Console.WriteLine("Число не подходит");
}