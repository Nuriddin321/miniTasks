namespace  ExtensionMethod;

static class exForGeek
{
    public static void M4(this Geek geek)
    {
        Console.WriteLine($"methosd name M4");
        
    }

//=====================================================
    public static void M5(this Geek g , string x)
    {
        Console.WriteLine(x);
        
    }

    //=====================================================


    public static void GetName(this Person p)
    {
        Console.WriteLine($"{p.Name}  {p.Age}");
    }

//=====================================================

    public static int PowiniBer(this int x, int y)
    {
        int temp = x;
        for(int i = 1; i < y; i++)
        {
            x *= temp;
        }
        return x;
    }

    //=====================================================

    public static bool IsKottami(this int x , int y)
    {
        return x > y ? true : false;
    }

    //=====================================================

}