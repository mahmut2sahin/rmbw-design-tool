using System;

namespace rmbw_design_tool
{
    class Program
    {
        static void Main()
        {
            HudsonsMethod hudson = new();
            VanDerMeersMethod vander = new();

            Console.WriteLine("For decimal numbers, use period, NOT COMMA!");

            while (true)
            {
                Console.WriteLine("HUDSON'S METHOD (1) - VAN DER MEER'S METHOD (2)");
                Console.WriteLine("Which method do you want to use? 1 or 2?");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    hudson.Design();
                    break;
                }
                else if (input == "2")
                {
                    vander.Design();
                    break;
                }
                else
                {
                    Console.WriteLine("Please restart the application and enter valid input :(");
                }
            }
        }
    }
}
