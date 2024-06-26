namespace TextAventureGame
{

    // Conditional if else game
     class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to the aventure Game: ");
            Console.WriteLine("Enter your character name: ");
            string playername = Console.ReadLine();
            Console.WriteLine("Choose your character class: (warrior, wizard, Archer)"  );
            string characterType = Console.ReadLine();

            Console.WriteLine($" Your {playername} the {characterType} find yourselft at the edge of the dark forest.");
            Console.WriteLine("Do you enter the forest or camo outside? (Enter/camp)");

            string choice1 = Console.ReadLine();
            

            if(choice1.ToUpper() == "enter")
            {
                Console.WriteLine("You bravely enter the forest"); 
            
            
            } else
            {
                Console.WriteLine("You decide to camp out and wait for dayligth.");
            }

            bool gameContinues = true;

            while (gameContinues)
            {
                Console.WriteLine("You com to a fork in the road. Go to left or  rigth?");

                string direction = Console.ReadLine();

                if(direction.ToLower() == "Left")
                {

                    Console.WriteLine("You find a treasure chest!");
                    gameContinues = false;

                }
                else
                {
                    Console.WriteLine("You encounter a wild beast!");
                    Console.WriteLine("Fight or flee? (fight / flee) ");
                    string fightchoice = Console.ReadLine();

                    if(fightchoice.ToLower() == "fight")
                    {
                        Random rand = new Random();

                        int luck = rand.Next(1, 11);
                        if(luck > 5)
                        {
                            Console.WriteLine("You beat the wild beast!");

                            if(luck > 8)
                            {
                                Console.WriteLine( "The wild beast dropped a treasure!");
                            }


                        }



                    }
                    else
                    {
                        Console.WriteLine("The beast attacked you where you didnt expect it!");
                        Console.WriteLine("It rammed its tusks into your chest and you blood out");
                        gameContinues = false;
                    }







                }
            }

            Console.WriteLine("Game over");
            Console.ReadKey();
        }
    }
}
