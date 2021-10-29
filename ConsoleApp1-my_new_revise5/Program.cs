using System;

namespace ConsoleApp1_my_new_revise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;

            }

            for(int j=0; j<Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);              

            }                    

            foreach (int k in Numbers)
            {
                
                Console.WriteLine(k);
            }
            for (int p = 0; p < 10; p++)
            {
                Console.Write(p + "");

            }
        }
    }
}
