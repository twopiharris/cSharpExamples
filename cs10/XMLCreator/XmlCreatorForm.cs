using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace XMLCreator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class XmlCreatorForm : System.Windows.Forms.Form
	{

    private XmlDocument doc;
    private XmlNode theNode;
    private string fileName = "practice.xml";

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDisplay;
    private System.Windows.Forms.TextBox txtOutput;
        
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public XmlCreatorForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.btnDisplay = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(72, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(72, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 32);
      this.label2.TabIndex = 1;
      this.label2.Text = "Address";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(72, 160);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 24);
      this.label3.TabIndex = 2;
      this.label3.Text = "phone";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(168, 24);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(136, 20);
      this.txtName.TabIndex = 3;
      this.txtName.Text = "";
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(168, 80);
      this.txtAddress.Multiline = true;
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(136, 56);
      this.txtAddress.TabIndex = 4;
      this.txtAddress.Text = "";
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(168, 160);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(136, 20);
      this.txtPhone.TabIndex = 5;
      this.txtPhone.Text = "";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(120, 208);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(152, 24);
      this.btnAdd.TabIndex = 6;
      this.btnAdd.Text = "add";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Location = new System.Drawing.Point(224, 312);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(152, 24);
      this.btnQuit.TabIndex = 7;
      this.btnQuit.Text = "quit";
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(368, 24);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(240, 216);
      this.txtOutput.TabIndex = 8;
      this.txtOutput.Text = "";
      // 
      // btnDisplay
      // 
      this.btnDisplay.Location = new System.Drawing.Point(416, 256);
      this.btnDisplay.Name = "btnDisplay";
      this.btnDisplay.Size = new System.Drawing.Size(152, 24);
      this.btnDisplay.TabIndex = 9;
      this.btnDisplay.Text = "display XML";
      this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
      // 
      // XmlCreatorForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(648, 349);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnDisplay,
                                                                  this.txtOutput,
                                                                  this.btnQuit,
                                                                  this.btnAdd,
                                                                  this.txtPhone,
                                                                  this.txtAddress,
                                                                  this.txtName,
                                                                  this.label3,
                                                                  this.label2,
                                                                  this.label1});
      this.Name = "XmlCreatorForm";
      this.Text = "XML Creator";
      this.Load += new System.EventHandler(this.XmlCreatorForm_Load);
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new XmlCreatorForm());
		}

    private void XmlCreatorForm_Load(object sender, System.EventArgs e) {
      //initialize
      doc = new XmlDocument();
      //doc.PreserveWhitespace = true;
      
      XmlElement contacts;
      XmlElement person;
      
      //create root node
      theNode = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
      doc.AppendChild(theNode);
      
      //create contacts node
      contacts = doc.CreateElement("contacts");
      doc.AppendChild(contacts);
      
      //create first address
      person = doc.CreateElement("person");
      contacts.AppendChild(person);
      
      //create address elements
      theNode = doc.CreateElement("name");
      theNode.InnerText = "Roger Dodger";
      person.AppendChild(theNode);
      
      theNode = doc.CreateElement("address");
      theNode.InnerText = "123 W 4th St.";
      person.AppendChild(theNode);
      
      theNode = doc.CreateElement("phone");
      theNode.InnerText = "123-4567";
      person.AppendChild(theNode);
    } // end form load

    private void btnAdd_Click(object sender, System.EventArgs e) {
      //duplicate the person node
      XmlNode contacts;
      XmlNode person;
      XmlNode root;
      
      root = doc.FirstChild;
      contacts = root.NextSibling;
      person = contacts.FirstChild;
      theNode = person.Clone();
      
      //copy node values from text boxes
      theNode["name"].InnerText = txtName.Text;
      theNode["address"].InnerText = txtAddress.Text;
      theNode["phone"].InnerText = txtPhone.Text;
      
      //add the new node to contacts
      contacts.AppendChild(theNode);
            
    } // end btnAdd

    private void btnDisplay_Click(object sender, System.EventArgs e) {
      //save the current document
      doc.Save(fileName);
      
      //display with whitespace
      doc.PreserveWhitespace = true;
      doc.Load(fileName);
      txtOutput.Text = doc.OuterXml;
      
      //reload without whitespace
      doc.PreserveWhitespace = false;
      doc.Load(fileName);
      
    } // btnDisplay

    private void btnQuit_Click(object sender, System.EventArgs e) {
      Application.Exit();
    } // end btnQuit
	} // end class def
} // end namespace
