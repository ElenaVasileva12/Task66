// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//ввод пользовательских данных
int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//сумма в промежутке
int SumNamber(int n1, int n2)
{
    if (n1 == n2) return n2;
    else return n1 + SumNamber(n1+1,n2);
}

//проверка на корректность
bool CheckNaturalNumbers (int num1,int num2)
{
   return num1>0 && num2>0;      
}



int number1 = EnterNumber("Введите целое число");
int number2 = EnterNumber("Введите целое число");


if (CheckNaturalNumbers(number1,number2)) 
{
    if (number1<number2)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {number1} до {number2} = {SumNamber(number1, number2)}");
        
    }
    else if (number2<number1)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {number2} до {number1} = {SumNamber(number2, number1)}");
    }
    else
    {
        Console.WriteLine($"Числа равны, сумма равна {number1+number2}");
    }
}
else 
{
Console.WriteLine($"Ошибка, число должно быть натуральным");
}
