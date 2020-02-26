using System;

namespace GlitCrit
{
  /// <summary>
  /// Another Critter Viewer
  /// Adding capabilities to an inherited class
  /// Andy Harris, 12/21/01
  /// </summary>
  
  class CritViewer {
    static void Main(string[] args) {
      CritViewer cv = new CritViewer();
    } // end main
		
    public CritViewer(){
      GlitterCritter gc = new GlitterCritter("Sparky");
      gc.shine();
      Console.WriteLine(gc.talk());
		  
      Console.WriteLine("Please press Enter to continue");
      Console.ReadLine();
    } // end constructor
  } // end CritViewer class
} // end namespace
