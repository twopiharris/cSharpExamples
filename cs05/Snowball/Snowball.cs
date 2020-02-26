using System;

namespace Snowball
{
	/// <summary>
	/// A snowball fight against a robot opponent
	/// demonstrates object oriented programming
	/// Andy Harris, 12/23/01
	/// </summary>
	class MainMenu
	{
    int range;                //distance between fighters
    Fighter player;
    RoboFighter opponent;
    int oppStrength = 3;     //opponent strength
    bool keepGoing = true;

		static void Main(string[] args)
		{
			MainMenu mm = new MainMenu();
		}
		
		public MainMenu(){
		  int choice;
		  string name;
		  
		  //set up the contestants
		  Console.Write("What is your name? ");
		  name = Console.ReadLine();
		  player = new Fighter(name);
		  Console.Write("What's your opponent's name? ");
		  name = Console.ReadLine();
      opponent = new RoboFighter(player, name);

		  range = 10;
		  while(keepGoing){
		    choice = displayMenu();
		    switch (choice){
		      case 0: 
		        //quit
		        Console.WriteLine("quitting");
		        keepGoing = false;
		        break;
          case 1:
            //make a snowball
            player.snowballs++;
            break;
		      case 2:
		        range--;
		        if (range < 0) {
		          range = 0;
		        } // end if
		        break;
		      case 3:
		        range++;
		        break;
		      case 4:
		        if (player.throwSnow(range)){
		          Console.WriteLine("You hit {0}", opponent.name);
		          opponent.strength--;
		        } else {
		          Console.WriteLine("You missed {0}", opponent.name);
		        } // end if
		        break;
		      default:
		        Console.WriteLine("you said {0}", choice);
		        break;
		    } // end switch
		    range = opponent.choosePlay(range);
        checkWinner();
		  } // end while loop
		} // end constructor
		
		public void checkWinner(){
		  if (opponent.strength <= 0){
		    Console.WriteLine("You win!");
		    keepGoing = false;
		    Console.ReadLine();
		  } else if (player.strength <= 0){
		    Console.WriteLine("You have been defeated");
		    keepGoing = false;
		    Console.ReadLine();
		  } // end if
		} // end checkWinner
		
		public int displayMenu(){
		  int choice;
		  Console.WriteLine("Stats:");
		  Console.WriteLine("  distance: \t{0}", range);
		  Console.WriteLine("  snowballs: \t{0}", player.snowballs);
		  Console.WriteLine("  {0}: \t{1}", player.name, player.strength);
      Console.WriteLine("  {0}: \t{1}", opponent.name, opponent.strength);
		  Console.WriteLine();
      Console.WriteLine("0.  Quit");
      Console.WriteLine("1. Make a snowball");
      Console.WriteLine("2. Move closer");
      Console.WriteLine("3. Run away");
      Console.WriteLine("4. Throw");
      Console.WriteLine();

      Console.Write("Indicate your choice: ");
      choice = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine();
      return choice;
    } // end dispayMenu
  } // end class
} // end namespace
