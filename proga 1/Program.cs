int lamantino;
int a;
int s;
int d;
do
{
    Console.WriteLine("Какое действие вы предпочитаете?:");
    Console.WriteLine("1. Cумма 2 чисел");
    Console.WriteLine("2. Разность 2 чисел");
    Console.WriteLine("3. Произведение 2 чисел");
    Console.WriteLine("4. Частное 2 чисел");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы и сделать самому а не через прогу");
    lamantino = Convert.ToInt32(Console.ReadLine());
    switch (lamantino)
    {
        case 1:
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            s = Convert.ToInt32(Console.ReadLine());
            d = a + s;
            Console.WriteLine("я тут подумал и получился ответ " + d);
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            s = Convert.ToInt32(Console.ReadLine());
            d = a - s;
            Console.WriteLine("отвечаю, это " + d);
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            s = Convert.ToInt32(Console.ReadLine());
            d = a * s;
            Console.WriteLine("изи, ответ " + d);
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            s = Convert.ToInt32(Console.ReadLine());
            d = a / s;
            Console.WriteLine("это было не сложно, ответ " + d);
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= s; i += 1)
            {
                a *= a;
            }
            d = a;
            Console.WriteLine("вот тут было посложней, но я смог, ответ " + d);
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            d = (int)Math.Sqrt(a
                );
            Console.WriteLine("было сложно, ответ " + d);
            Console.WriteLine();
            break;
        case 7:
            double res;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            res = Convert.ToDouble(a);
            res = (res * 0.01);
            Console.WriteLine("здесь я напряг все свои извилины и получился ответ " + res);
            Console.WriteLine();
            break;
        case 8:
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            d = 1;
            for (int i = 1; i <= a; i += 1)
            {
                d = d * i;
            }
            Console.WriteLine("боги говорят что тут ответ " + d);
            Console.WriteLine();
            break;
    }
        
}
while (lamantino != 9);