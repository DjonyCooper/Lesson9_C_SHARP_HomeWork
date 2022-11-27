// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Важно: Выполнить с помощью рекурсии!
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNumbers(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNumbers(num - 1);
    if(num < 1) ShowNumbers(num + 1);
}

Console.Write("░ Здравствуй юный падаван!\n░ Магистр Йода завещал познать рекурсию.\n░ От тебя требуется задать число, а R2-D2 произведет необходимые вычисления!\n");
Console.Write("> Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"░ R2-D2 издает странные звуки...\n░ Кажется это вычисление ему дается трудно, но..\n░ Формируем список значений от {num} до 1, отлично вот и ответ:\n");
Console.Write("> ");
ShowNumbers(num);
Console.Write("\n░ До встречи! Приходи еще!");
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumNumBetweenMN(int m, int n)
{
    if(m == n) return n;
    if(m < n) return m + SumNumBetweenMN(m + 1, n);
    else return m + SumNumBetweenMN(m - 1, n); 
}

Console.Write("> Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("> Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine()); 

int sum = SumNumBetweenMN(m, n);
Console.Write(sum);
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int FuncAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return FuncAkkerman(m - 1, 1);
    else
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}

Console.Write("> Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("> Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine()); 
if(m < 0 || n < 0)
{
    Console.Write($"░ Для вычисления функции Аккермана необходимы положительные значения.\n░ Попробуйте снова используя положительные числа.");
}
else
{
    int FunAkk = FuncAkkerman(m, n);
    Console.Write(FunAkk);
}
*/