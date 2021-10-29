using System;

namespace ConsoleApp1_my_new_revise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int totalcoffeecost = 0;
            string userdecision = "";
            do
            {
                start:

                Console.WriteLine("Please select your coffee:: 1-small 2-medium 3-large");
                int userchoice = int.Parse(Console.ReadLine());

                switch (userchoice)
                {
                    case 1:
                        totalcoffeecost += 1;
                        Console.WriteLine("Your OPTION is 1 and Cost is ::");
                       
                        break;

                    case 2:
                        Console.WriteLine("Your OPTION is 2 and Cost is ::");
                        totalcoffeecost += 2;
                        break;

                    case 3:
                        Console.WriteLine("Your OPTION is 3 and Cost is ::");
                        totalcoffeecost += 3;
                        break;

                    default:
                        Console.WriteLine("Please enter a  valid userchoice and now you entered {0}", userchoice);
                        break;
                }
                do
                {
                    decide:
                    Console.WriteLine("Do you want to continue ?? YES OR NO ??");
                    userdecision = Console.ReadLine().ToUpper();
                    switch (userdecision)
                    {
                        case "YES":
                            goto start;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine(" Your choice is invaid {0}. make a valid choice YES or NO");
                            goto decide;
                    }
                    //if (userdecision != "YES" && userdecision != "NO")
                    //{
                    //    Console.WriteLine("your user choice {0} is invalid , please enter another : ", userdecision);
                    //}

                } while (userdecision != "YES" && userdecision != "NO");

            } while (userdecision.ToUpper() != "NO");

            Console.WriteLine("YOUR BILL AMOUNT IS {0}", totalcoffeecost);
          

        }
    }
}
