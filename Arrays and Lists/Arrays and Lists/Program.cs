using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        bool valid = false;
        while (valid == false)
        {
            string[] tmntArray = { "Leonardo", "Michaelangelo", "Raphael", "Donatello" };
            Console.WriteLine("Welcome to the Teenage Mutant Ninja Turtles Selection Screen");
            Console.WriteLine("\nPlease select one of the following options: \n\nFor Leonardo - Enter 0 \nFor Michaelangelo - Enter 1 \nFor Raphael - Enter 2 \nFor Donatello - Enter 3");
            string x = Console.ReadLine();
            int index = Convert.ToInt16(x);
            if (index <= 3)
            {
                Console.WriteLine("\n\nYou have selected " + tmntArray[index]);
                valid = true;

                bool valid2 = false;
                while (valid2 == false)
                {
                    int[] numArray = { 10, 15, 20, 25 };
                    Console.WriteLine("\n\n" + tmntArray[index] + " derives all of his strength from Pizza.");
                    Console.WriteLine("How many Pizzas should " + tmntArray[index] + " bring on his journey?");
                    Console.WriteLine("\nTo bring 10 pizzas - Enter 0 \nTo bring 15 pizzas - Enter 1 \nTo bring 20 pizzas - Enter 2 \nTo bring 25 pizzas - Enter 3");
                    string y = Console.ReadLine();
                    int index2 = Convert.ToInt16(y);
                    if (index2 <= 3)
                    {
                        Console.WriteLine("\n\nYou are bringing " + numArray[index2] + " pizzas on your journey. I hope that's enough!");
                        valid2 = true;

                        bool valid3 = false;
                        while (valid3 == false)
                        {
                            List<string> villains = new List<string>();
                            villains.Add("Shredder");
                            villains.Add("Bebop");
                            villains.Add("Rocksteady");
                            villains.Add("Baxter Stockman");
                            int length3 = (villains.Count);
                            Console.WriteLine("\n\nTime to battle! Choose an adversary. ");
                            Console.WriteLine("\nTo battle Shredder - Enter 0\nTo battle Bebop - Enter 1\nTo battle Rocksteady - Enter 2\nTo battle Baxter Stockman - Enter 3");
                            string z = Console.ReadLine();
                            int index3 = Convert.ToInt16(z);
                            if (index3 <= 3)
                            {
                                Console.WriteLine("\n\nPrepare to fight " + villains[index3]);
                                valid = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\n\nInvalid Selection. Please choose again.\n\n");
                                valid3 = false;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("\n\nInvalid Selection. Please choose again.\n\n");
                        valid = false;
                    };
                }
            }
            else
            {
                Console.WriteLine("\n\nInvalid Selection. Please choose again.\n\n");
                valid = false;
            };
        }
        Console.ReadLine();
    }
}




//int[] numArray = { 10, 15, 20, 25 };
//Console.WriteLine("\n\n" + tmntArray[index] + " derives all of his strength from Pizza.");
//Console.WriteLine("How many Pizzas should " + tmntArray[index] + " bring on his journey?");
//Console.WriteLine("\nTo bring 10 pizzas - Enter 0 \nTo bring 15 pizzas - Enter 1 \nTo bring 20 pizzas - Enter 2 \nTo bring 25 pizzas - Enter 3");
//string y = Console.ReadLine();
//int index2 = Convert.ToInt16(y);
//int length2 = (numArray.Length);
//Console.WriteLine("\n\nYou are bringing " + numArray[index2] + " pizzas on your journey. I hope that's enough!");


//List<string> villains = new List<string>();
//villains.Add("Shredder");
//villains.Add("Bebop");
//villains.Add("Rocksteady");
//villains.Add("Baxter Stockman");
//int length3 = (villains.Count);
//Console.WriteLine("\n\nTime to battle! Choose an adversary. ");
//Console.WriteLine("\nTo battle Shredder - Enter 0\nTo battle Bebop - Enter 1\nTo battle Rocksteady - Enter 2\nTo battle Baxter Stockman - Enter 3");
//string z = Console.ReadLine();
//int index3 = Convert.ToInt16(z);
//Console.WriteLine("\n\nPrepare to fight " + villains[index3]);

