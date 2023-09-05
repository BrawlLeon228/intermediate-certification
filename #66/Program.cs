int FindSum(int m, int n)
{
    if (m <= 0 || n <= 0)
    {
        Console.WriteLine("Введено не натуральное число");
        return 0;
    }
    else if (m > n)
    {
        Console.WriteLine("M больше N");
        return 0;
    }
        else
        {
            if (m < n){
                return m+=FindSum(m+1, n);
            }
            else return n;
        }
}
Console.WriteLine(FindSum(3, 1));