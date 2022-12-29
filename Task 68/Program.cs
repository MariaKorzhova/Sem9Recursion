// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
int res = 0;
System.Console.WriteLine();
PrintAnswer(M,N);




void PrintAnswer(int M, int N)
{
    if (M < 0 || N < 0)
    {
        System.Console.WriteLine($"Одно из чисел или оба отрицательные");
        System.Console.WriteLine();
    }
    else
    {
        System.Console.WriteLine($"Значение функции Аккермана равно A(m,n) = {Number(M, N)} ");
        System.Console.WriteLine();
    }
}

int Number(int m, int n)
{
    if (m == 0)
    {
        res = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        Number(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        Number(m - 1, Number(m, n - 1));
    }
    return res;
}

int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
