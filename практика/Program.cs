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

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите фигуру:\n1 - треугольник\n2 - прямоугольник\n3 - круг");
//        int flag = Convert.ToInt16(Console.ReadLine());

//        if (flag == 1)
//        {
//            Console.WriteLine("Введите высоту: ");
//            double h = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Введите сторону, на которую опирается высота: ");
//            double a = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Площадь: " + a * h * 0,5);
//        }

//        if (flag == 2)
//        {
//            Console.WriteLine("Введите высоту:");
//            double a = Convert.ToInt16(Console.ReadLine());

//            Console.WriteLine("Введите ширину: ");
//            double b = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Площадь: " + a * b);
//        }

//        if (flag == 3)
//        {
//            Console.WriteLine("Введите радиус круга: ");
//            double r = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Площадь круга: " + r * 3,14 * 3,14);
//        }

//    }
//}

using System;
using System.ComponentModel.DataAnnotations;

//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Введите значение: ");
//        double value = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите единицу измерения, из которой нужно конвертировать (kg, g, s, min, m, cm): ");
//        string fromUnit = Console.ReadLine();

//        Console.Write("Введите единицу измерения, в которую нужно конвертировать (kg, g, s, min, m, cm): ");
//        string toUnit = Console.ReadLine();

//        double result = ConvertUnits(value, fromUnit, toUnit);

//        Console.WriteLine($"{value} {fromUnit} равно {result} {toUnit}");
//    }

//    static double ConvertUnits(double value, string fromUnit, string toUnit)
//    {
//        if (fromUnit == "kg" && toUnit == "g")
//            return value * 1000;
//        else if (fromUnit == "g" && toUnit == "kg")
//            return value / 1000;
//        else if (fromUnit == "s" && toUnit == "min")
//            return value / 60;
//        else if (fromUnit == "min" && toUnit == "s")
//            return value * 60;
//        else if (fromUnit == "m" && toUnit == "cm")
//            return value * 100;
//        else if (fromUnit == "cm" && toUnit == "m")
//            return value / 100;

//        return 0;
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число: ");
//        int count = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Введите желаемый процент: ");
//        double perc = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Результат: " + count * perc / 100);
//    }
//}

//class Program
//{
//    static void Main(string[] args) 
//    {
//        Console.WriteLine("Введите валюту: EUR, USD");
//        string currency = Console.ReadLine().ToLower();

//        if (currency == "eur")
//        {
//            Console.WriteLine("Введите количество: ");
//            double count = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Результат: " + count * 90,0013);
//        }

//        else if (currency == "usd")
//        {
//            Console.WriteLine("Введите количество: ");
//            double count = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Результат: " + count * 99, 2613);
//        }
//    }
//}

//public class Searcher
//{
//    public int[] SearchMaximum(int[] array)
//    {
//        int max = 0;
//        int index = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > max)
//            {
//                max = array[i];
//                index = i;
//            }

//        }

//        int[] result = {max, index};
//        return result;
//    }

//    public int[] SearchMinimum(int[] array)
//    {
//        int min = 100;
//        int index = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < min)
//            {
//                min = array[i];
//                index = i;
//            }
//        }

//        int[] result = {min, index};
//        return result;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Searcher searcher = new Searcher();

//        int[] array = new int[10];
//        Console.WriteLine("Сгенерированный массив: ");

//        Random rand = new Random();
//        for (int i = 0; i < 10; i++)
//        {
//            array[i] = rand.Next(1, 100);
//            Console.Write(array[i] + "\t");
//        }

//        Console.WriteLine("\nМаксимум: " + searcher.SearchMaximum(array)[0] + "\nЕго индекс: " + searcher.SearchMinimum(array)[1] + "\nМинимум: " + searcher.SearchMinimum(array)[0] + "\nИндекс: " + searcher.SearchMinimum(array)[1]);

//    }
//}

using System;

//class SortingArray
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 5, 2, 8, 3, 1, 6, 4 };

//        Console.WriteLine("Оригинальный массив: ");
//        PrintArray(array);

//        BubbleSortAscending(array);
//        Console.WriteLine("Пузырьковая сортировка по возрастанию: ");
//        PrintArray(array);

//        SelectionSortDescending(array);
//        Console.WriteLine("Выборочная сортировка по убыванию:");
//        PrintArray(array);
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//        Console.WriteLine();
//    }

//    static void BubbleSortAscending(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (array[j] > array[j + 1])
//                {
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void SelectionSortDescending(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            int maxIndex = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if (array[j] > array[maxIndex])
//                {
//                    maxIndex = j;
//                }
//            }
//            int temp = array[maxIndex];
//            array[maxIndex] = array[i];
//            array[i] = temp;
//        }
//    }
//}

//class Searcher
//{
//    static void SearchInArray(int[] array, int value)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] == value)
//            {
//                Console.WriteLine($"Элемент найден под индексом {i + 1}");
//            }
//            else Console.WriteLine("Элемент не найден.");
//        }
//    }

//    static void Main(string[] args)
//    {
//        int[] array = new int[10];
//        Random random = new Random();

//        Console.WriteLine("Массив: ");
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(0, 100);
//            Console.Write(array[i] + "\t");
//        }

//        Console.WriteLine("\nВведите элемент: ");
//        int value = Convert.ToInt16(Console.ReadLine());

//        SearchInArray(array, value);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Random rand = new Random();
//        int[] array = new int[10];

//        Console.WriteLine("Массив: ");

//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = rand.Next(0, 100);
//            Console.Write(array[i] + "\t");
//        }

//        Console.WriteLine("\nМассив в обратном порядке: ");
//        for (int i = 9; i != 0; i--)
//        {
//            Console.Write(array[i] + "\t");
//        }
//    }
//}

using System;

using System;

//public class Matrix
//{
//    private double[,] data;

//    public Matrix(double[,] data)
//    {
//        this.data = data;
//    }

//    public Matrix Add(Matrix other)
//    {
//        double[,] result = new double[data.GetLength(0), data.GetLength(1)];
//        for (int i = 0; i < data.GetLength(0); i++)
//        {
//            for (int j = 0; j < data.GetLength(1); j++)
//            {
//                result[i, j] = data[i, j] + other.data[i, j];
//            }
//        }
//        return new Matrix(result);
//    }

//    public Matrix Sub(Matrix other)
//    {
//        double[,] result = new double[data.GetLength(0), data.GetLength(1)];
//        for (int i = 0; i < data.GetLength(0); i++)
//        {
//            for (int j = 0; j < data.GetLength(1); j++)
//            {
//                result[i, j] = data[i, j] - other.data[i, j];
//            }
//        }
//        return new Matrix(result);
//    }
//    public Matrix Transpose()
//    {
//        double[,] result = new double[data.GetLength(1), data.GetLength(0)];
//        for (int i = 0; i < data.GetLength(0); i++)
//        {
//            for (int j = 0; j < data.GetLength(1); j++)
//            {
//                result[j, i] = data[i, j];
//            }
//        }
//        return new Matrix(result);
//    }

//        public static void Main(string[] args)
//    {
//        double[,] data1 = { { 1, 2 }, { 3, 4 } };
//        double[,] data2 = { { 5, 6 }, { 7, 8 } };

//        Matrix matrix1 = new Matrix(data1);
//        Matrix matrix2 = new Matrix(data2);

//        Matrix resultAdd = matrix1.Add(matrix2);
//        Matrix resultSub = matrix1.Sub(matrix2);
//        Matrix resultTranspose1 = matrix1.Transpose();
//        Matrix resultTranspose2 = matrix2.Transpose();

//        Console.WriteLine("Матрица 1:");
//        PrintMatrix(matrix1);
//        Console.WriteLine("Матрица 2:");
//        PrintMatrix(matrix2);
//        Console.WriteLine("Результат сложения:");
//        PrintMatrix(resultAdd);
//        Console.WriteLine("Результат вычитания:");
//        PrintMatrix(resultSub);
//        Console.WriteLine("Результат транспорирования 1 матрицы: ");
//        PrintMatrix(resultTranspose1);
//        Console.WriteLine("Результат транспорирования 2 матрицы: ");
//        PrintMatrix(resultTranspose2);
//    }

//    public static void PrintMatrix(Matrix matrix)
//    {
//        for (int i = 0; i < matrix.data.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.data.GetLength(1); j++)
//            {
//                Console.Write(matrix.data[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число: ");
//        int value = Convert.ToInt32(Console.ReadLine());

//        string binary = Convert.ToString(value, 2);
//        string octal = Convert.ToString(value, 8);
//        string hexadecimal = Convert.ToString(value, 16);

//        Console.WriteLine("Двоичное представление: " + binary + "\nВосьмиричное представление: " + octal + "\nШестнадцатиричное: " + hexadecimal);
//    }
//}

using System;

//class Program
//{
//    static void PrintPyramid(int n)
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write(new string(' ', n - i));
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write(j + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void Main(string[] args)
//    {
//        PrintPyramid(10);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку: ");
//        string line = Console.ReadLine();

//        Console.WriteLine("Введите подстроку: ");
//        string subline = Console.ReadLine();

//        if (line.Contains(subline)) Console.WriteLine("Подстрока найдена под индексом: " + line.IndexOf(subline));
//        else Console.WriteLine("Подстрока не найдена.");
//    }
//}

//class LineCleaner
//{
//    public string LineClean(string line)
//    {
//        return string.Join(" ", line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку: ");
//        string line = Console.ReadLine();

//        LineCleaner cleaner = new LineCleaner();
//        Console.WriteLine("Чистая строка: " + cleaner.LineClean(line));
//    }
//}


