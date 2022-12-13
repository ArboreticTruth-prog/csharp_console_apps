using System;

class DivideTheTwo
{
    public static void Divide() 
    {
        var zeroToTwohundred = new Dictionary<string, int>();
        for (int i = 0;i<256;i++){
            zeroToTwohundred[""+i]=i;
        }
        Console.WriteLine("Enter Your First Number from 0 to 255: ");
        var inputOne = Console.ReadLine();
        Console.WriteLine("Enter Your Second Number from 0 to 255: ");
        var inputTwo = Console.ReadLine();

        
        if (zeroToTwohundred.ContainsKey(inputOne) && zeroToTwohundred.ContainsKey(inputTwo)){
            var divided = (Int32.Parse(inputOne)/Int32.Parse(inputTwo));
            Console.WriteLine(inputOne + " Divided By " + inputTwo + " Is: " + divided);
        }
        else 
        {
            Console.WriteLine("Formate Exception: Input string was not in a correct format.");
            Divide();
        }
    }
}