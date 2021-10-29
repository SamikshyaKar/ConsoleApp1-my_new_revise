using System;

namespace ConsoleApp1_my_new_revise8
{

    class customer
    {
        string _firstname;
        string _secondname;

        public customer(string FIRSTNAME, string SECONDANAME)
        {
           this. _firstname = FIRSTNAME;
           this. _secondname = SECONDANAME;
        }
        public void printfullname()
        {
            Console.WriteLine(" The Full Name Is {0}",this._firstname+" "+this._secondname);

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            customer obj1 = new  customer("Samu ", " DHAMU ");
            obj1.printfullname();

           
        }
    }
}
