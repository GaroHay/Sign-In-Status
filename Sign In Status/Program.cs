using System;

namespace Sign_In_Status
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][][] arr = new string[10][][];
            string[] accounts = new string[10];

            for (int i = 0; i < 4; i++)
            {
                arr[i] = new string[10][];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i][j] = new string[4];
                }
            }
            int accountnum1 = 0;
            int accountnum2 = 0;
            string accountname;
            int accountchoose = 0;
            bool check = true;
            int numcheck = 0;
            string username;
            string password;
            string[] split;
            string name;
            int age = 0;
            int number;
            
            while (true)
            {
                if (accountnum1 == 0)
                {
                    Console.WriteLine("Please type a name of an account you will create");
                }

                accountname = Console.ReadLine();
                accounts[accountnum1] = accountname;
                while (check)
                {
                    Console.ResetColor();
                    Console.WriteLine("Choose one");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1 = Help");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("2 = Sign up");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("3 = Log in");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("4 = Show");
                    Console.ResetColor();
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine();
                    Console.Write("Command => ");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (number == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Username: ");
                        arr[accountchoose][accountnum2][0] = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Name: ");
                        arr[accountchoose][accountnum2][1] = Console.ReadLine();

                        arr[accountchoose][accountnum2] [2] = Convert.ToString(Messages.IntString("age"));

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Password: ");
                        arr[accountchoose][accountnum2] [3] = Console.ReadLine();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Account created!");

                        accountnum2++;
                    }
                    else if (number == 4 && accountnum2 > 0)
                    {
                        Console.WriteLine("Do you want to show all or show one thing?");
                        Console.WriteLine("1 = Show all");
                        Console.WriteLine("2 = Show one");

                        number = Messages.IntString("Option");

                        if (number == 1)
                        {
                            Console.WriteLine("Which account do you want to choose?");
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.Write("Please write the full username or part of it");
                            username = Console.ReadLine();

                            for (int i = 0; i < accountnum2; i++)
                            {
                                if (arr[accountchoose][i][0].Contains(username))
                                {
                                    numcheck++;
                                    number = i;
                                    username = arr[accountchoose][i][0];
                                    Console.WriteLine(username);
                                }
                            }

                            if (numcheck == 0)
                            {
                                Console.WriteLine("Sorry, none found.");
                            }
                            else if (numcheck == 1)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.WriteLine(arr[accountchoose][number][i]);
                                }
                            }
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Please, press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}