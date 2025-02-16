using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // 生成随机字符
        char randomChar = (char)random.Next(65, 91); // 从 A 到 Z 的字符
        Console.Write($"Here's your car nunber: {randomChar}");

        // 生成随机字符
        char randomChar1 = (char)random.Next(65, 91); // 从 A 到 Z 的字符
        Console.Write($"{randomChar1}");

        // 生成随机字符
        char randomChar2 = (char)random.Next(65, 91); // 从 A 到 Z 的字符
        Console.Write($"{randomChar2}");

        Console.Write("-");

        // 生成随机数字
        int randomNumber = random.Next(0, 9);
        Console.Write($"{randomNumber}");

        // 生成随机数字
        int randomNumber1 = random.Next(0, 9);
        Console.Write($"{randomNumber1}");

        // 生成随机数字
        int randomNumber2 = random.Next(0, 9);
        Console.Write($"{randomNumber2}");
    }
}
