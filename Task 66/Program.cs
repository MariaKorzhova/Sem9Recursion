// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
int sum = 0;
if (!Merge(N, M))
{
Swap();
}
Number(N,M);
System.Console.WriteLine();
System.Console.Write($"Сумма натуральных элементов в промежутке от M до N равна {sum} ");
System.Console.WriteLine();
System.Console.WriteLine();


bool Merge(int n,int m)
{
if(n>m)
return true;
else
return false;
}

void Swap()
{
int temp=N;
N=M;
M=temp;
}

void Number(int n,int m)
{
    
    if (n==m-1)
    {
        return;
    }
    else
    {
        if (n >= 0)
        {
            sum += n;
        }
    }
Number(n-1,m);
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


