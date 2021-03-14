using System;

namespace Study_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///СТРОКИ
            
            ///Вывод текста
            Console.WriteLine("Hello World!");
            ///Ввод и виды вывода текста
            string Hometown = "Moscow";
            Console.WriteLine($"My hometown is {Hometown} and what is yours?");
            string guest_town = Console.ReadLine();
            Console.WriteLine("Okey. And what is your name?");
            string guest_name = Console.ReadLine();
            Console.WriteLine($"Nice, you are {guest_name} from {guest_town}.");
            Console.WriteLine($"Your name has {guest_name.Length} letters!");
            ///Замена слова в тексте
            string text = "Example";
            Console.WriteLine(text);
            text = text.Replace("Example", "Not example");
            Console.WriteLine(text);
            ///Поиск слова в тексте (Вывод: булевы значения)
            string song_text = "Hello, i am Sergey, not Serezha";
            Console.WriteLine(song_text.Contains("Hello"));
            Console.WriteLine(song_text.Contains("Hi"));
            ///Поиск слова в начале текста (Вывод: булевы значения)
            Console.WriteLine(song_text.StartsWith("Hello"));
            Console.WriteLine(song_text.StartsWith("Serezha"));
            ///Поиск слова в конце текста (Вывод: булевы значения)
            Console.WriteLine(song_text.EndsWith("Hello"));
            Console.WriteLine(song_text.EndsWith("Serezha"));
            Console.WriteLine("");

            ///ЧИСЛА
            
            ///Вычисления с целыми числами, изучение порядка операций
            ///Изучение точности и ограничений для целых чисел
            int a = 10;
            int b = 15;
            int c = a + b;
            int d = b / a; ///Только целая часть
            int e = b % a; ///Остаток
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            ///Максимальное и минимальное значение int
            int max_i = int.MaxValue;
            int min_i = int.MinValue;
            Console.WriteLine($"Максимальное значение int: {max_i}. Минимальное значение int: {min_i}.");
            ///Числа double - числа с плавающей запятой двойной точности
            ///Числа float - числа с плавающей запятой одиночной точности
            double f = 19;
            double g = 23;
            double h = 8;
            double i = (f + g) / h;
            Console.WriteLine(i);
            ///Максимальное и минимальное значение int
            double max_d = double.MaxValue;
            double min_d = double.MinValue;
            Console.WriteLine($"Максимальное значение double: {max_d}. Минимальное значение double: {min_d}.");
            ///Ошибки округления
            double error = 1.0 / 3.0;
            Console.WriteLine(error);
            ///Максимальное и минимальное значение decimal
            decimal max_de = decimal.MinValue;
            decimal min_de = decimal.MinValue;
            Console.WriteLine($"Максимальное значение decimal: {max_de}. Минимальное значение decimal: {min_de}.");
            ///decimal даёт большую точность в сравнении с double, пример:
            Console.WriteLine("Различие точности double(1) и decimal(2)");
            double j = 1.0;
            double k = 3.0;
            Console.WriteLine(j / k);
            decimal l = 1.0M;
            decimal m = 3.0M;
            Console.WriteLine(l / m);
            ///Математика(геометрия)
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

            ///ВЕТВИ И ЦИКЛЫ
        }
    }
}
