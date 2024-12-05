using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(CountBits(4));
        Console.WriteLine(CountBits(10));
        Console.WriteLine(CountBits(1));
        Console.WriteLine(CountBits(32));

        Console.WriteLine(Persistence(39));
        Console.WriteLine(Persistence(9));
        Console.WriteLine(Persistence(999));

        Console.WriteLine(DigitalRoot(16));
        Console.WriteLine(DigitalRoot(942));
    }
    static int CountBits(int num)
    {
        string binum = Convert.ToString(num, 2);
        int count = 0;
        for (int i = 0; binum.Length > i; i++) 
        {
            if (binum[i] == '1') 
            {
                count++;
            }
        }
        return count;
    }
    static int Persistence(int num)
    {
        if (num < 10) return 0;
        int count = 0;
        while (num >= 10)
        {
            num = Mdig(num);
            count++;
        }
        return (count);
    }
    static int Mdig(int num)
    {
        int mequal = 1;
        while (num > 0)
        {
            mequal *= num % 10;
            num /= 10;
        }
        return mequal;
    }
    static int DigitalRoot(int num)
    {
        if (num < 10) return num;
        int s = 0;
        while (num > 0)
        {
            s += num % 10;
            num /= 10;
        }
        return DigitalRoot(s);
    }
}