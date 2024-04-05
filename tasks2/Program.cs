using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();

        Console.Write("Введите количество строк (0 < N < 27): ");
        int N = int.Parse(Console.ReadLine());

        if (N < 1 || N >= 27)
        {
            Console.WriteLine("Недопустимое количество строк.");
            return;
        }

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 1; i <= N; i++)
            {
                string line = new string((char)('a' + i - 1), i);
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Файл создан и успешно записан.");
    }
}