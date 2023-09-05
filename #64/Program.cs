string WriteNum(int n)
{
    if (n <= 0)
    {
        return "Введено не натуральное число";
    }
    else
    {
        if (n > 1) return n + ", " + WriteNum(n - 1);
        else return "1";
    }

}

Console.WriteLine(WriteNum(-1));