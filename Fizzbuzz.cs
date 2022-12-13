using System;
class Fizzing
{
    public static void Buzzing()
    {
        var fizzbuzz = new Dictionary<int, string>();
        string fullSet = "";

        for (int i = 1; i< 100; i++)
        {
            if ((i%3) == 0 && (i%5) == 0)
            {
                fizzbuzz[i] = "fizzbuzz";
            }
            else if ((i%3) == 0)
            {
                


                fizzbuzz[i] = "fizz";
            } 
            else if ((i%5) == 0)
            {
                fizzbuzz[i] = "buzz";
            }
            else 
            {
                fizzbuzz[i] = ""+i;
            }       

            fullSet += " " + string.Format(fizzbuzz[i]);
        }
        Console.WriteLine(fullSet);
    }
}