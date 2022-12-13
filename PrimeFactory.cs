using System;

class Priming  
{
    public static void Factoring()
{
    Console.WriteLine("Number to Prime: ");
    long n = Int32.Parse(Console.ReadLine());
    List<int> sList = new List<int>();
    long temp = 1;
    for (int i = 2; i <= n; i++)
    {
        if ((n % i) == 0)
        {
            temp = n / i;
            sList.Add(i);
            i = 1;
            n = temp;
        }     
    }
    string arr = string.Join(",", sList.ToArray());
    Console.Write(arr);
    Console.WriteLine(".");
}
}