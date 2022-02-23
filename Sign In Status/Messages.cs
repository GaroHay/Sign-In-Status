using System;
using System.Collections.Generic;
using System.Text;

namespace Sign_In_Status
{ 
    public class Messages
    {
        public static int IntString(string type)
        {
            int num;

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    num = Convert.ToInt32(Console.ReadLine());
                    return num;
                }
                catch (FormatException)
                {
                    Console.ResetColor();
                    Console.WriteLine($"Please enter a valid {type}");
                }
            }

            return 0;
        }
    }
}
