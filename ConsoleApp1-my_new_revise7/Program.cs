using System;

namespace ConsoleApp1_my_new_revise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ParamsMethod(1,2,3,4);
            ParamsMethod();
           

            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            ParamsMethod(Numbers);
        }

        public static void ParamsMethod( params int[] Numbers )
        {
         Console.WriteLine(" numbers in the array are " + Numbers.Length);

         foreach (int i in Numbers)
          {
           Console.WriteLine(i);
          }
        }

    }
}
