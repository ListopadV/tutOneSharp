namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // third commit :) 
        // second commit 

        int[] nn = new int[5] { 2, 4, 6, 8, 10 };

        Console.WriteLine(calculateAverage(nn));

        // some changes on new feature branch 
    
    }

    static int calculateAverage(int[] integers)
    {
        int n = 0;
        for (int i = 0; i <= integers.Length; i++)
        {

            n += integers[i];
        }

        return n / integers.Length;
    }

    static int calculateMax(int[] integers)

        // second mian change 
    {
        int n = 0;
        for (int i = 0; i <= integers.Length; i++) {
            if (integers[i] > n) {
                n = integers[i];
            }
        }
        return n;
    }
}