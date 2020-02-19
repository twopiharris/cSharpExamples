using System;

class ArrayDemo{
  public static void Main(){
    string[] students = {"Jorge", "Marco", "Roberto", "Bryant", "Erick", "Josue", "Hector", "Hesler"};

    for (int i = 0; i < students.Length; i++){
      Console.WriteLine("{0} is amazing.", students[i]);
    } // end for loop
    Console.WriteLine();

    string[] courses = new string[3];
    courses[0] = "Java 1";
    courses[1] = "C Sharp";
    courses[2] = "Algorithms";

    foreach (string course in courses){
      Console.WriteLine ("{0} is a great class.", course);
    } // end foreach

    Console.WriteLine();

    Console.WriteLine("Here are the students in order:");
    Array.Sort(students);
    foreach (string name in students){
      Console.WriteLine(name);
    } // end foreach
  } // end main
} // end class

