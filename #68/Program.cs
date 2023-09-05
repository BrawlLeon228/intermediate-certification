int Akkerman(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.Write("Введено число меньше чем ");
        return 0;
    }
    else
    {
        if (m == 0) return n + 1;
        else if (n == 0) 
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        } 
    }
    
}

Console.Write(Akkerman(3, 2));