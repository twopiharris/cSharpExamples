using System;

namespace Song
{
	/// <summary>
	/// This Old Man Song
	/// Demonstrates methods
	/// Andy Harris, 12/13/01
	/// </summary>
	class ThisOldMan
	{
		static void Main(string[] args)
		{
			doVerse(1);
			doChorus();
			doVerse(2);
			doChorus();
			
			pause();
		} // end main
		
    static void doChorus(){
      string message = "";
      message += "\n...With a knick-knack paddy whack\n";
      message += "give a dog a bone\n";
      message += "This old man came rolling home.";
      message += "\n\n";
      System.Console.WriteLine(message);
    } // end doChorus
    
		static void doVerse(int verseNum){
      string message = "";
      message += "This old man, he played ";
      message += verseNum;
      message += ". \nHe played knick-knack ";
      message += getPlace(verseNum);
      Console.WriteLine(message);
    } // end verse
    
    static string getPlace(int verseNum){
      string message = "";
      switch (verseNum){
        case 1:
          message = "on my thumb ";
          break;
        case 2:
          message = "on my shoe ";
          break;
        default:
          message = "not yet defined";
          break;
      } // end switch
      return message;
    } // end getPlace

    static void pause(){
      Console.WriteLine("Please press enter key to quit");
      Console.ReadLine();
    } // end pause
    		      
  } // end class
} // end namespace 
