class Program2
{
    public static int Lower
    {
        get;
        set;
    }
    public static int Higher
    {
        get;
        set;
    }
    public static int TotalSum(NumberCheck obj)
    {
        int total = 0;
        for(int i = Lower; i<= Higher; ++i)
        {
            if(obj.Invoke(i))
                total += i;
                // Console.WriteLine("total c "+total + "  element= "+i);
        }
        return total;
    
    }
    
    public static void Main(string[] args)
    {
        Lower = 1;
        Higher = 10;

        Console.WriteLine("Total sum for Even numbers is {0}", TotalSum(Arithmetic.IsEven));
        Console.WriteLine("Total sum for Odd numbers is {0}", TotalSum(Arithmetic.IsOdd));
        Console.WriteLine("Total sum for Prime numbers is {0}", TotalSum(Arithmetic.IsPrime));    
    }
}