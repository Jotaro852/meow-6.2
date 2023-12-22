using System;
using System.IO;

class work_6_2
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask2.txt"); // казываем путь и читаем все строки
        string wordsLine = string.Join(" ", lines); // составляем одну текстовую линию с разделителями

        Console.WriteLine(wordsLine); // вывод
    }
}