using PrefixTree;
using System.Diagnostics;

static class Programm
{
    public static void Main()
    {
        RandomNumbersPerformTest();
        Console.WriteLine();
        OrderedNumbersPerformTest();
        Console.ReadLine();
    }

    static void RandomNumbersPerformTest()
    {
        int N = 100000;
        int[] rndNum = GetRandomNumbers(N);
        string[] rngStrs = GetRandomStrings(N);

        Trie trie = new Trie();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            trie.Insert(rngStrs[i], rndNum[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в [Trie] случайных чисел от 1 до {N} занимает: {sw.ElapsedMilliseconds} мс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            var searh = trie.Search(rngStrs[i]);
        }
        sw.Stop();
        Console.WriteLine($"Поиск в [Trie] {N / 10} случайных чисел занимает: {sw.ElapsedMilliseconds} мс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            trie.Delete(rngStrs[i]);
        }
        sw.Stop();
        Console.WriteLine($"Удаление в [Trie] {N / 10} случайных чисел занимает: {sw.ElapsedMilliseconds} мс.");
    }
    static void OrderedNumbersPerformTest()
    {
        int N = 100000;
        int[] num = GetOrderNumbers(N);
        string[] rngStrs = GetRandomStrings(N);

        Trie trie = new Trie();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            trie.Insert(rngStrs[i], num[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в [Trie] упорядоченных чисел от 1 до {N} занимает: {sw.ElapsedMilliseconds} мс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            var searh = trie.Search(rngStrs[i]);
        }
        sw.Stop();
        Console.WriteLine($"Поиск в [Trie] {N / 10} упорядоченных чисел занимает: {sw.ElapsedMilliseconds} мс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            trie.Delete(rngStrs[i]);
        }
        sw.Stop();
        Console.WriteLine($"Удаление в [Trie] {N / 10} упорядоченных чисел занимает: {sw.ElapsedMilliseconds} мс.");
    }
    static Random random = new Random();
    static int[] GetRandomNumbers(int N)
    {
        int[] mass = new int[N];
        for (int i = 0; i < N; i++)
        {
            if (i != N)
                mass[i] = random.Next(1, int.MaxValue);
        }
        return mass;
    }
    static string[] GetRandomStrings(int N)
    {
        string[] strings = new string[N];
        for(int i = 0; i < strings.Length; i++)
        {
            strings[i] = GetRandomString();
        }
        return strings;
    }
    static string GetRandomString()
    {
        int size = random.Next(8, 30);
        string str = string.Empty;
        for (int i = 0; i < size; i++)
        {
            char c = (char)random.Next(33, 127);
            str += c;
        }
        return str;
    }
    static int[] GetOrderNumbers(int N)
    {
        int[] mass = new int[N];
        for (int i = 1; i < N; i++)
        {
            if (i != N)
                mass[i] = i;
        }
        return mass;
    }
}

