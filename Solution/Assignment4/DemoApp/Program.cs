delegate void Printer(string msg);

 class Program
 {   
    static void Meet(string person)
    {
        Console.WriteLine("Hii {0}", person);
    }
    static void Leave(string person)
    {
        Console.WriteLine("Bye {0}", person);
    }
    static void Main()
    {
        Printer p = Meet;
        p+=Leave;
        p.Invoke("Jack");
    }
 }