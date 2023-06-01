using System;

namespace Mediasoft
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.WriteLine("FB");
                }
                else if (j % 3 == 0)
                {
                    Console.WriteLine("F");
                }
                else if (j % 5 == 0)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
