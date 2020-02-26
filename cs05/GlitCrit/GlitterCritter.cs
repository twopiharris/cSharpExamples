using System;

namespace GlitCrit
{
	/// <summary>
	/// New version of Critter that adds a "shine" method
	/// </summary>
	public class GlitterCritter : Critter
	{
		//overloaded constructors map to base (Critter) constructors
		public GlitterCritter(): base(){ }
    public GlitterCritter(string name): base(name){ }
    public GlitterCritter(string theName, int fullness, int happiness, int theAge)
           : base(theName, fullness, happiness, theAge){ }
           
    //new shine method
    public void shine(){
      Console.WriteLine(name + " shines beautifully.");
    } // end shine
		
	} // end GlitterCritter
} // end namespace
