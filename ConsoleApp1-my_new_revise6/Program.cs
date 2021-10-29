using System;

namespace ConsoleApp1_my_new_revise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int total = 0;
            int product = 0;
            Calculate(10,20,out total, out product );
            Console.WriteLine("sum ={0} && Product ={1}", total,product);
        }

        public static void Calculate(int FN, int SN, out int SUM, out int PROD)
        {

            SUM = FN + SN;
            PROD = FN * SN;
        }
    }
}
