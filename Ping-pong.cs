using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Please enter a number that you like");
        string yourString = Console.ReadLine();
        int yourStringToNumber = int.Parse(yourString);

        for (int i = 1; i <= yourStringToNumber; i++) 
        {
            if ( i % 3 == 0 && i % 5 == 0 ) 
            {
            Console.WriteLine("ping-pong");
            }
            else if ( i % 5 == 0 )  
            {
            Console.WriteLine("pong");
            }
            else if ( i % 3 == 0 ) 
            {
            Console.WriteLine("ping");
            }
            else 
            {
            Console.WriteLine(i);
            }
        }
    }
}
