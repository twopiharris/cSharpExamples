using System;

namespace PigLatin
{
	/// <summary>
	/// Pig Latin interpreter
	/// Demonstrate loops, string methods
	/// Andy Harris, 11/16/01
	/// </summary>
	class Pig
	{
		static void Main(string[] args)
		{
			string pigWord = "";
			string sentence = "";
      string firstLetter;
      string restOfWord;
      string vowels = "AEIOUaeiou";
      int letterPos;

      while (sentence.ToLower() != "quit"){
        Console.WriteLine("Please enter a sentence (or type \"quit\" to exit)");
        sentence = Console.ReadLine();

        if (sentence.Length == 0){
          sentence = "you cannot have a blank sentence";
        } // end if
        
			  foreach (string word in sentence.Split())
			  {
          firstLetter = word.Substring(0,1);
          restOfWord = word.Substring(1, word.Length -1);
          letterPos = vowels.IndexOf(firstLetter);
          if (letterPos == -1)
          {
            //it's a consonant
            pigWord = restOfWord + firstLetter + "ay";
          } else {
            //it's a vowel
            pigWord = word + "way";
          } // end if
          
          Console.Write("{0} ", pigWord);
          
			    //debugging code
          /*
			    Console.Write("{0}\t", word);
          Console.Write("{0}\t", firstLetter);
          Console.Write("{0}\t", restOfWord);
          Console.Write("{0}\t", letterPos);
          Console.WriteLine("{0}", pigWord);
          */

			  } // end foreach
        Console.WriteLine();
       } // end while loop
      
		} // end main

	} // end class 
} // end namespace
