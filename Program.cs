using System;

class FibonacciSeries
{
    static void Main()
    {
        
        Console.Write("Enter the number of terms for the Fibonacci series: ");
        int numTerms = int.Parse(Console.ReadLine());

       
        Console.WriteLine("Fibonacci Series:");
        DisplayFibonacciSeries(numTerms);
    }

    
    private static void DisplayFibonacciSeries(int numTerms)
    {
        int firstTerm = 0, secondTerm = 1;

        for (int i = 0; i < numTerms; i++)
        {
            Console.Write(firstTerm + " ");

            
            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
