﻿using System;

namespace ConsoleApp1_my_new_revise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer C1 = new Customer();
            string fullName = C1.GetFullName("Pragim", "Tech");
            Console.WriteLine("Full Name = {0}", fullName);

        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}


//// Load the current executing assembly as the Customer class is present in it.
//Assembly executingAssembly = Assembly.GetExecutingAssembly();
//// Load the Customer class for which we want to create an instance dynamically
//Type customerType = executingAssembly.GetType("Pragim.Customer");
//// Create the instance of the customer type using Activator class 
//object customerInstance = Activator.CreateInstance(customerType);
//// Get the method information using the customerType and GetMethod()
//MethodInfo getFullName = customerType.GetMethod("GetFullNames");
//// Create the parameter array and populate first and last names
//string[] methodParameters = new string[2];
//methodParameters[0] = "Pragim"; //FirstName
//            methodParameters[1] = "Tech";     //LastName
//            // Invoke the method passing in customerInstance and parameters array
//            string fullName = (string)getFullName.Invoke(customerInstance, methodParameters);
//Console.WriteLine("Full Name = {0}", fullName);
//        }
//    }
//    public class Customer
//{
//    public string GetFullName(string FirstName, string LastName)
//    {
//        return FirstName + " " + LastName;
//    }
//}
//}