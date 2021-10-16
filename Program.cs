using System;

namespace RandomReviewGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100000;i++)
            {
                Random r = new Random();
                int rInt = r.Next(1, 10);
                Console.WriteLine($"{rInt}");
            }
        }
    }
}
