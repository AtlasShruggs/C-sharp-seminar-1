Console.Write("Введите номер задачи для проверки: ");
int num = int.Parse(Console.ReadLine());
if (num == 2)
{
    Console.WriteLine("Введите числа a и b");
    int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
    if (a > b)
    {
        Console.WriteLine(a + " - больше");
    }
    if (b > a)
    {
        Console.WriteLine(b + " - больше");
    }
    else
    {
        Console.WriteLine("a и b равны");
    }

}
if (num == 4)
{
    Console.WriteLine("Введите числа a, b и c");
    int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());
    if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine("Самое большое число - " + a);
        }
        else
        {
            Console.WriteLine("Самое большое число - " + c);
        }
    }
    else
    {
        if (b > c)
        {
            Console.WriteLine("Самое большое число - " + b);
        }
        else
        {
            Console.WriteLine("Самое большое число - " + c);
        }
    }

}
if (num == 6)
{
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine("Четное");
    }
    else
    {
        Console.WriteLine("Нечетное");
    }
}
if (num == 8)
{
   Console.Write("Введите число: ");
   int a = int.Parse(Console.ReadLine());
   int k = 2;
   while (k < a)
   {
    Console.WriteLine(k);
    k += 2;
   }
}