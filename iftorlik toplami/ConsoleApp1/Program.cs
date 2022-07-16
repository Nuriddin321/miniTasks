

class Program
{
    public static void Main(string[] args)
    {
        task(6, 8, 9);
        task(5, 18, 8);
    }

    static void task(int s, int h, int b)
    {
        // s 1, h 3, b 2
        int x = 0;

        key:
       
        if (s >= 1 && h >= 3 && b >= 2)
        {
            s -= 1;
            h -= 3;
            b -= 2;
            x++;
            goto key;
        }
        else
        {
            Console.WriteLine(x);
        }
       
    }
}