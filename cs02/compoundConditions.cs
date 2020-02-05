/* compoundConditions.cs
   demonstrate boolean operators and
   how to simulate them
*/


using System;

class CompoundCondition {
  public static void Main(){
    string fullName;
    int year;

    Console.WriteLine("What is your full name? ");
    fullName = Console.ReadLine();

    Console.WriteLine("What year is it?");
    year = Convert.ToInt32(Console.ReadLine());

    // using an && statement

    if (fullName == "Bill Gates" && year < 2006){
      Console.WriteLine("You are still running Microsoft");
    } // end if

    // note that an else clause at the end of the preceding statement
    // would be confusing, because we don't know which part of the 
    // condition is wrong.

    // so we need a second compound if to check for other years

    if (fullName == "Bill Gates" && year >= 2006){
      Console.WriteLine("You are trying to cure Malaria");
    } // end if

    // we can actually get the same logic with a nested pair of ifs

    if (fullName == "Bill Gates"){
      if (year < 2006){
        Console.WriteLine("Nice job running Microsoft");
      } else { // we already know it's Bill, just checking for other years
        Console.WriteLine("Hooray for you.  Keep solving malaria");
      } // end year if
      // I can now write some code for 'not bill' as I separated the conditions
    } else {
      Console.WriteLine("I was looking for Bill...");
    } // end fullName if

    // getting OR behavior

    if (fullName == "Bill Gates" || fullName == "James Gosling"){
      Console.WriteLine("Yea for OOP!");
    } // end if

    // again we get more control by breaking into two if statements.
    // this time they can be in parallel rather than nested.

    if (fullName == "Bill Gates"){
      Console.WriteLine("Yea for OOP!");
    } // end if

    if (fullName == "James Gosling"){
      Console.WriteLine("Yea for OOP!");
    } // end if
  } // end main
} // end class def

