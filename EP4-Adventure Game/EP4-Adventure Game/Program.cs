using System.Xml.Serialization;

namespace EP4_Adventure_Game
{

    internal class Program
    {
        // This should allow the change to stay after choice is made after GameStart

          static  bool largeShell = false;
          static  bool shellHandful = false;
          static  bool clamandMuscles = false

        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("Sally Sold Seashells by the Seashore: A game about shells in their many forms");
            Console.WriteLine("This is text base adventure where you are collecting shells for your shell stand by the shore. You will be choosing \npaths bases on the number correlating to the option.");
            Console.WriteLine("Would you like to play? \n1.Yes 2.No");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Great! Let's begin");
                Console.WriteLine("You start off in your shack, observing the shells that you have collected the previous days. You notice that your \ncollection is getting a little low and you need to collect more shells");
                Console.WriteLine("Packing up for the day you decide on which location you start with");
    
                    GameStart();
            }
            if (choice == "2")
            {
                Console.WriteLine("Goodbye!");
            }
        }
        static void GameStart()
        {
            string choice;


                Console.WriteLine("There are three different areas around your shack that have a lot of shells, which one would you like to go to? You can also decide to setup shop instead");
            Console.WriteLine("1.Snail Shore\n2.Mollusc Forest\n3.Gastropod Cove\n4.Set up shop");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You head off to the shore in hopes that it was a high tide last night");
                Console.WriteLine("There looks to be a lot of shells that appeared over night but most of them seem broken.");
                Console.WriteLine("Would you like to scavenge the broken bits?\n1. Yes\n2.No");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("You scavenge what you can from the broken bits, and come upon a large shell!");
                    largeShell = true;
                    Console.WriteLine("You head back to your shack with your large shell in hand");
                    GameStart();
                }

                if (choice == "2")
                {
                    Console.WriteLine("You decide to head back to the shack and find another location to head to");
                    GameStart();
                }
            }

            if (choice == "2")
            {
                Console.WriteLine("You head off into Mollusc forest in hopes that the local snails have decided to upgrade their shells");
                Console.WriteLine("The deeper you go, the darker it gets. Usually a stroll through here doesn't take too long but this time around it takes you much longer explore");
                Console.WriteLine("The path deviates into three offshoots, one is blocked off but the other two seem open. The one to the left leads to a \nclearing and the one to the right leads to a river");
                Console.WriteLine("Would you like to head right or left?\n1.Right\n2.Left");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("You head to the clearing. It is beautiful and the sun is shning through the thick trees that seem to stretch forever");
                    Console.WriteLine("You don't find any shells, but at least it was pretty!");
                    Console.WriteLine("You head back to the shack hopeful that a new location might have shells you can grab");
                    GameStart();
                }

                if (choice == "2")
                {
                    Console.WriteLine("The river flows in a calm pace flowing towards the ocean. The snails that hangout here usually get swept away but often leave their shells at the shore");
                    Console.WriteLine("You peek along the shore and find a lot of traditional snail shells that don't sell well on their own, but make beautiful jewlery once put together");
                    shellHandful = true;
                    Console.WriteLine("Pack feeling full you head back to your shack");
                    GameStart();
                }
            }

            if (choice == "3")
            {
                Console.WriteLine("You head into the cove admirring the colors that reflect on to the ceiling from the small pool of water that puddles in the middle");
                Console.WriteLine("Shells from oceanic creatures end up in here and muscles line the sides of opening");
                Console.WriteLine("You find many pearlistic shells from clams and mind a few muscles that could be shucked as well");
                clamandMuscles = true;
                Console.WriteLine("You head back to your shack feeling confident in todays findings");
                GameStart();

            }

                if (choice == "4")
                {

                    if (largeShell)
                    {
                        Console.WriteLine("You set up your shells on your stand and wait for the evening crowd to pass by");
                        Console.WriteLine("You put shells out that you had previously collected since you only harvested the one large shell from today");
                        Console.WriteLine("The large shell sells rather quickly and you make a good fortune from it! The other shells don't sell as well but you'll have them for the next day");
                        Console.WriteLine("Congrats! You made a large sale and still have some stock left");
                        Console.WriteLine("Would you like to play again?\n1.Yes\n2.No");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            GameStart();
                        }
                        else
                        {
                            Console.WriteLine("Thank you for playing!");
                        }

                    }

                    if (shellHandful)
                    {
                        Console.WriteLine("You set up your shells on your stand and wait for the evening crowd to pass by");
                        Console.WriteLine("The small handful that you collected doesn't catch any eyes but you at least sold a necklace that you made from one of them");
                        Console.WriteLine("The day wasn't very succesful, but there's always tomorrow!");
                        Console.WriteLine("Would you like to play again?\n1.Yes\n2.No");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            GameStart();
                        }
                        else
                        {
                            Console.WriteLine("Thank you for playing!");
                        }
                    }


                    if (clamandMuscles)
                    {
                        Console.WriteLine("You set up your shells on your stand and wait for the evening crowd to pass by");
                        Console.WriteLine("The mussels don't do as well as you hoped but, you can never go wrong with clams!");
                        Console.WriteLine("Congratulations! You had a succesful day on the seashore");
                        Console.WriteLine("Would you like to play again?\n1.Yes\n2.No");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            GameStart();
                        }
                        else
                        {
                            Console.WriteLine("Thank you for playing!");
                        }
                    }
                    Console.WriteLine("You setup shops with the stock from yesterday without collecting anything new");
                    Console.WriteLine("The day wasn't succesful, you take down the shack and head in for the night");
                    Console.WriteLine("Would you like to play again?\n1.Yes\n2.No");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        GameStart();
                    }
                    else
                    {
                        Console.WriteLine("Thank you for playing!");
                    }
                }
            }

        }

        
    }
