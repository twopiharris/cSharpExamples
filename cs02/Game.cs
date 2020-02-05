using System;

namespace MathGame
{
	/// <summary>
	/// Simple Math Game
	/// Asks four math questions
	/// Using Random Numbers
	/// Andy Harris, 11/7/01
	/// </summary>
	class Game
	{
		static void Main(string[] args)
		{
		  int a, b, c, guess, score;
		  score = 0;

		  //create the random number generator
		  Random roller = new Random();

		  Console.WriteLine("Welcome to the math Game!  I'll give you some simple problems to solve.");

      //addition
      a = (int)(roller.NextDouble() * 10);
      b = (int)(roller.NextDouble() * 10);
      c = a + b;
      
      Console.Write("What is {0} + {1}? ", a, b);
      guess = Convert.ToInt32(Console.ReadLine());
      
      if (guess == c) {
        score++;
      }
      
      //subtraction
      a = (int)(roller.NextDouble() * 10) + 1;
      b = (int)(roller.NextDouble() * 10) + 1;
      c = a + b;
      
      Console.Write("What is {0} - {1}? ", c, a);
      guess = Convert.ToInt32(Console.ReadLine());
      
      if (guess == b) {
        score++;
      }
      
      //multiplication
      a = (int)(roller.NextDouble() * 10) + 1;
      b = (int)(roller.NextDouble() * 10) + 1;
      c = a * b;
      
      Console.Write("What is {0} * {1}? ", a, b);
      guess = Convert.ToInt32(Console.ReadLine());
      
      if (guess == c) {
        score++;
      }
      
      //division
      a = (int)(roller.NextDouble() * 10) + 1;
      b = (int)(roller.NextDouble() * 10) + 1;
      c = a * b;
      
      Console.Write("What is {0} / {1}? ", c, a);
      guess = Convert.ToInt32(Console.ReadLine());
      
      if (guess == b) {
        score++;
      }
      
      Console.WriteLine("Score: {0} out of 4", score);
      
      switch (score)
      {
        case 4:
          Console.WriteLine("You're a genius!");
          break;
        case 3:
          Console.WriteLine("You're pretty smart!");
          break;
        case 2:
          Console.WriteLine("You could do better");
          break;
        case 1:
          Console.WriteLine("You could use some practice");
          break;
        case 0:
          Console.WriteLine("Maybe you were good at gym class in school");
          break;
        default:
          Console.WriteLine("Hey, something went wrong here!");
          break;
      } // end switch        		  
		  
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Please press enter key to quit");
      //hold the screen to see results
		  Console.ReadLine(); 
		} // end main
	} // end class
} // end namespace







