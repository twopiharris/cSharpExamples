using System;

namespace Snowball
{
	/// <summary>
	/// RoboFighter
	/// A computer-controlled snowball fighter
	/// derived from fighter
	/// </summary>
	
	public class RoboFighter: Fighter
	{
	  private Fighter player;
	  
		public RoboFighter(Fighter thePlayer, string theName): base(theName)
		{
			player = thePlayer;
		} // end constructor
		
		public int choosePlay(int range){
		  int thePlay;
		  Random roller = new Random();
		  if (snowballs <= 0){
		    //make a new snowball if out of them
        Console.WriteLine(name + " is making a snowball");
        snowballs++;
      } else {
		    //decide to throw or move
		    thePlay = roller.Next(6);
		    switch (thePlay){
		      case 0:
		        //go closer
            Console.WriteLine("{0} moves closer.", name);
            range--;
		        break;
		      case 1:
		        //back up
            Console.WriteLine("{0} backs away.", name);
            range++;
		        break;
		      case 2:
		        //make a snowball
            Console.WriteLine(name + " is making a snowball");
            snowballs++;
            break;      
		      default:
		        //otherwise, throw a snowball
		        Console.WriteLine("{0} throws a snowball", name);
		        if (throwSnow(range)){
		          Console.WriteLine("{0} has been hit", player.name);
		          player.strength--;
		        } else {
		          Console.WriteLine("{0} missed you.", name);
		        } // end if
		        break;
		    } // end switch
		  } // end out of snowballs if
		  return range;
    } // end choosePlay
    
	} // end roboFighter class def
} // end namespace
