delegate bool NumberCheck(int num);
class Arithmetic
{
   
    public static bool IsEven(int num)
    {
        if(num % 2 == 0)
            return true;
        return false;    
    }
    public static bool IsOdd(int num)
    {
        if(num % 2 != 0)
            return true;
        return false;     
    }
    public static bool IsPrime(int num)
    {
        if(num == 1)
            return false;
        else if(num == 2 || num == 3 || num == 5 || num == 7)
            return true;
        else
        {
            for(int i = 2; i <= num/2; ++i)
            {
                if(num % 3 == 0 || num % 5 == 0 || num % 7 == 0)
                    return false;
                if(num % i == 0)
                    return false;  
            }
        }      
        return true;  
    }
  
}