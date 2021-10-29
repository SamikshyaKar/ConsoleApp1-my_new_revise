using System;

namespace ConsoleApp1_my_new_revise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userchoice = "";
            do
            {
               
                Console.WriteLine("Hello World!");
                Console.WriteLine("enter a user target ");
                int usertarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start < usertarget) { Console.Write(start + " "); start = start + 2; }

                do
                {
                    Console.WriteLine("Do you want to continue ?? ");
                    userchoice = Console.ReadLine().ToUpper();
                    if (userchoice != "YES" && userchoice != "NO")
                    {
                        Console.WriteLine("invalid choice :: Please say YES OR NO : ");
                    }
                } while (userchoice != "YES" && userchoice != "NO");

            } while(userchoice == "YES");
        }
    }
}
