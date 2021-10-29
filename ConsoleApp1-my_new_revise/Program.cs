using System;

namespace ConsoleApp1_my_new_revise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your name ::::::");
            string name=Console.ReadLine();
            Console.WriteLine("Hello ******** "+name);
            Console.WriteLine("Hello $$$$ {0}",name );
            Console.WriteLine("enter your name last Name ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello last name :: :::"+lastname);
            Console.WriteLine("Total Name ::::---{0} {1}", name,lastname );
            string Names = "C:\\samiks\\tech\\com";
            Console.WriteLine(Names);
            string names1 = @"C:\samu\abc\com";
            Console.WriteLine(names1);

            int? ticketcount = null;
            int totalticketcount;
            if (ticketcount == null)
            {
                totalticketcount = 0;

            }
            else
            {
                totalticketcount = ticketcount.Value;
            }
            Console.WriteLine("ticketcount = {0}", totalticketcount);

            int? available_tickets = 300;
            int totaltickets = available_tickets ?? 0;
            Console.WriteLine( "total available tickets = {0}", totaltickets);

            float f = 123.45F;
            int i = (int)f;
            Console.WriteLine("after conversion value is :::::" +i);
            int j = Convert.ToInt32(f);
            Console.WriteLine("after conversion value is ******" + j);

            string strnum = "100";
            int p = int.Parse(strnum);
            Console.WriteLine("strnum as converted ::::::****"+p);
            int result = 0;
          bool isconversiondone  = int.TryParse(strnum, out result);
            Console.WriteLine("isconversiondone successful ::"+ isconversiondone);
            if (isconversiondone)
            {
                Console.WriteLine("YES "+result);
            }
            else 
                    {Console.WriteLine("NOT "); }

            Console.WriteLine("enter a number :: ");
            int usernum = int.Parse(Console.ReadLine());

            switch (usernum)

            {
                case 10:
                    Console.WriteLine(" usernum number is 10");
                    break;

                case 20:
                    Console.WriteLine(" usernum number is 20");
                    break;

                case 30:
                    Console.WriteLine(" usernum number is 30");
                    break;

                case 40:
                case 50:
                case 60:
                    Console.WriteLine(" usernum number is either 40/50/60");
                    break;

                default:
                    Console.WriteLine("username number is default {0}", usernum);
                    break;

            }

         


        }
    }
}
