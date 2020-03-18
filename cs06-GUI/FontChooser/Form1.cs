using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FontChooser
{
	/// <summary>
	/// Summary description for myForm.
	/// </summary>
	public class myForm : System.Windows.Forms.Form
	{
    //Here's my own variables
    private System.Drawing.Font myFont;
    private string fontName = "Arial";
    private int fontSize = 20;

    //these variables were created by the designer
    private System.Windows.Forms.ListBox lstFontName;
    private System.Windows.Forms.Label lblOutput;
    private System.Drawing.FontStyle myStyle = FontStyle.Regular;
    private System.Windows.Forms.CheckBox chkBold;
    private System.Windows.Forms.CheckBox chkItalic;
    private System.Windows.Forms.RadioButton rad20;
    private System.Windows.Forms.RadioButton rad10;
    
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public myForm()
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
      this.lblOutput = new System.Windows.Forms.Label();
      this.lstFontName = new System.Windows.Forms.ListBox();
      this.rad10 = new System.Windows.Forms.RadioButton();
      this.chkItalic = new System.Windows.Forms.CheckBox();
      this.rad20 = new System.Windows.Forms.RadioButton();
      this.chkBold = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // lblOutput
      // 
      this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.lblOutput.Location = new System.Drawing.Point(48, 24);
      this.lblOutput.Name = "lblOutput";
      this.lblOutput.Size = new System.Drawing.Size(184, 80);
      this.lblOutput.TabIndex = 1;
      this.lblOutput.Text = "Sample Text";
      this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lstFontName
      // 
      this.lstFontName.Items.AddRange(new object[] {
                                                     "Arial",
                                                     "Times New Roman",
                                                     "Comic Sans MS"});
      this.lstFontName.Location = new System.Drawing.Point(40, 144);
      this.lstFontName.Name = "lstFontName";
      this.lstFontName.Size = new System.Drawing.Size(192, 43);
      this.lstFontName.TabIndex = 0;
      this.lstFontName.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // rad10
      // 
      this.rad10.Location = new System.Drawing.Point(16, 200);
      this.rad10.Name = "rad10";
      this.rad10.Size = new System.Drawing.Size(112, 16);
      this.rad10.TabIndex = 4;
      this.rad10.Text = "10 pts";
      this.rad10.CheckedChanged += new System.EventHandler(this.rad10_CheckedChanged_1);
      // 
      // chkItalic
      // 
      this.chkItalic.Location = new System.Drawing.Point(160, 232);
      this.chkItalic.Name = "chkItalic";
      this.chkItalic.Size = new System.Drawing.Size(104, 16);
      this.chkItalic.TabIndex = 3;
      this.chkItalic.Text = "italic";
      this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
      // 
      // rad20
      // 
      this.rad20.Location = new System.Drawing.Point(16, 232);
      this.rad20.Name = "rad20";
      this.rad20.Size = new System.Drawing.Size(104, 16);
      this.rad20.TabIndex = 5;
      this.rad20.Text = "20 pts";
      this.rad20.CheckedChanged += new System.EventHandler(this.rad20_CheckedChanged);
      // 
      // chkBold
      // 
      this.chkBold.Location = new System.Drawing.Point(160, 200);
      this.chkBold.Name = "chkBold";
      this.chkBold.Size = new System.Drawing.Size(104, 16);
      this.chkBold.TabIndex = 2;
      this.chkBold.Text = "bold";
      this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
      // 
      // myForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 301);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.rad20,
                                                                  this.rad10,
                                                                  this.chkItalic,
                                                                  this.chkBold,
                                                                  this.lblOutput,
                                                                  this.lstFontName});
      this.Name = "myForm";
      this.Text = "Font Chooser";
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new myForm());
		}

    private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
      assignFont();
    }

 
    private void chkBold_CheckedChanged(object sender, System.EventArgs e) {
      assignFont();      
    }
    
    private void assignFont(){
      // uses the variables to assign a font
      
      //check the list box for a font name
      fontName = lstFontName.Text;
      
      //look at check boxes for styles
      myStyle = FontStyle.Regular;
      if (chkBold.Checked){
        myStyle = myStyle | FontStyle.Bold;
      } // end if
      if (chkItalic.Checked){
        myStyle = myStyle | FontStyle.Italic;
      } // end if

      //create the new font and attach to the label
      myFont = new Font(fontName, fontSize, myStyle);
      lblOutput.Font = myFont;
    } // end assignFont 

    private void chkItalic_CheckedChanged(object sender, System.EventArgs e) {
      assignFont();
    }

    private void rad10_CheckedChanged_1(object sender, System.EventArgs e) {
        fontSize = 10;
        assignFont();
    }

    private void rad20_CheckedChanged(object sender, System.EventArgs e) {
      fontSize = 20;
      assignFont();
    } // end assignFont   
	}
}
