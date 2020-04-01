using System;

namespace SerDemo {
  /// <summary>
  /// Summary description for Contact.
  /// </summary>

  [Serializable]
  public class Contact {
    private string name = "";
    private string address = "";
    private string phone = "";
		
		//properties
    public string Name {
      set {
        name = value;
      } // end set
      get {
        return name;
      } // end get
    } // end name prop
		
    public string Address {
      set {
        address = value;
      } // end set
      get {
        return address;
      } // end get
    } // end address prop
		
    public string Phone {
      set {
        phone = value;
      } // end set
      get {
        return phone;
      } // end get
    } // end phone prop
				
    public Contact() {
      //no constructor necessary
    } // end constructor
  } // end class def
} // end namespace
