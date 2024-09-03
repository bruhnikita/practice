using System.Runtime.CompilerServices;

//public class Calc
//{
//    public int x;
//    public int z;

//    public float Minus(int x, int z)
//    {
//        return x - z;
//    }

//    public float Plus(int x, int z)
//    {
//        return x + z;
//    }

//    public float Umn(int x, int z)
//    {

//    return x * z; 
//    }

//    public float Del(int x, int z)
//    {
//        return x / z;
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calc calc = new Calc();
//        Console.WriteLine("Введите первое число:");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Введите второе число:");
//        int b = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Введите 1 для сложения \n2 - для вычитания\n3 - для деления\n4 - для умножения");
//        int flag = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Результат: ");

//        if (flag == 1) { Console.Write(calc.Plus(a, b)); }
//        else if (flag == 2) { Console.Write(calc.Minus(a, b)); }
//        else if (flag == 3) { Console.Write(calc.Del(a, b)); }
//        else if (flag == 4) { Console.Write(calc.Umn(a, b)); } 
//    }
//}

//public class Counter
//{
//    public string line;

//    public int CounterOfChars(string line)
//    {
//        return line.Length;
//    }

//    public int CounterOfWords(string line)
//    {
//        int counter = 1;

//        for (int i = 0; i < line.Length; i++)
//        {
//            if (line[i] == ' ')
//            {
//                if (line[i + 1] != ' ')
//                {
//                    counter++;
//                }
//            }
//        }
//        return counter;
//    }

//    public int CounterOfLines(string line)
//    {
//        int counter = 1;

//        for (int i = 0; i < line.Length; i++) 
//        {
//            if ((line[i] == '.') && (line[i + 1] != '\n'))
//            {
//                counter++;
//            } 
//        }

//        return counter;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите текст: ");
//        string line = Console.ReadLine();

//        Counter counter = new Counter();

//        Console.Write("\nКоличество символов: ");
//        Console.Write(counter.CounterOfChars(line));

//        Console.Write("\nКоличество слов: ");
//        Console.Write(counter.CounterOfWords(line));

//        Console.Write("\nКоличество предложений: ");
//        Console.Write(counter.CounterOfLines(line));
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        for (int i = 1; i < 10; i++)
//        {
//            Console.Write(i + " | ");

//            for (int j = 1; j < 10; j++)
//            {
//                Console.Write("\t" + i * j);
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//        }
//    }
//}

//public class Factorial
//{
//    int value;

//    public int Factor(int value)
//    {
//        int count = 1;
//        for (int i = value; i > 0; i--)
//        {
//            count = count * i;
//        }

//        return count;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число: ");
//        int value = Convert.ToInt32(Console.ReadLine());

//        Factorial factorial = new Factorial();
//        Console.WriteLine("Факториал: " + factorial.Factor(value));
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Числа Фибоначи: ");

//        int j = 1;
//        for (int i = 1; i <= n; i += j)
//        {
//            Console.Write("{0} ", i);
//            j = i - j;
//        }
//    }
//}

//class ChkNum
//{
//    public bool IsPrime(int x)
//    {
//        if (x <= 1) return false;
//        for (int i = 2; i <= x / i; i++)
//        {
//            if ((x % i) == 0) return false;
//        }
//        return true;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ChkNum ob = new ChkNum();

//        Console.WriteLine("Введите n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Простые числа: ");

//        for (int i = 2; i < n; i++)
//        {
//            if (ob.IsPrime(i)) Console.WriteLine(i);
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Random rnd = new Random();

//        int rand = rnd.Next(0, 100);

//        int x = 10;
//        while (x > 0)
//        {
//            Console.WriteLine($"У вас осталось: {x} попыток. Введите число:");
//            int check = Convert.ToInt32( Console.ReadLine() );

//            if (check == rand)
//            {
//                Console.WriteLine("Вы победили. Вот конфетка."); break;
//            }
//            else if (check != rand)
//            {
//                Console.WriteLine("Ошибка.");
//                x--;
//            }

//        }
//    }
//}

    c
