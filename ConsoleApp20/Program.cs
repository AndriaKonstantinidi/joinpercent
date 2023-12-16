using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int> { 1, 2, 5, 3, 7, 8, 14, 66, 32, 18 };

        var avnum = from originalNumber in nums
                    where originalNumber > PercentageCalculator(nums.Average(), 50)
                    select originalNumber;

        foreach(int i in avnum)
        {
            Console.WriteLine(i);
        }

    }

    static double PercentageCalculator(double originalNumber, double percentage)
    {
        return (originalNumber / 100) * percentage;
    }
}