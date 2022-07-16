using ExtensionMethod;

class Program
{
    static void Main(string[] args)
    {
       
       
       Person p = new Person( age: 33, name: "jeki");
       p.GetName();

       int x = 5;
       Console.WriteLine($"{x.PowiniBer(2)}");
      Console.WriteLine($"{x.IsKottami(4)} \n { x.IsKottami(7)}");
       
      
       
        

    }   



}

