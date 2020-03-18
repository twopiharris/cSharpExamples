using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace VisualCritter
{
	/// <summary>
	/// The Visual Critter
	/// Demonstrates basic Windows Forms
	/// Andy Harris, 01/01/02
	/// </summary>
	public class CritterForm : System.Windows.Forms.Form
	{
    //custom instance variables
    private string myName = "";
    
    private System.Windows.Forms.PictureBox picCritter;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.ComboBox cboMood;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnName;
    private System.Windows.Forms.RadioButton radRed;
    private System.Windows.Forms.RadioButton radGreen;
    private System.Windows.Forms.RadioButton radBlue;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.HScrollBar scrSize;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.PictureBox picHappy;
    private System.Windows.Forms.PictureBox picMad;
    private System.Windows.Forms.PictureBox picIndiff;
    private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CritterForm()
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CritterForm));
      this.picCritter = new System.Windows.Forms.PictureBox();
      this.lblName = new System.Windows.Forms.Label();
      this.cboMood = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnName = new System.Windows.Forms.Button();
      this.radRed = new System.Windows.Forms.RadioButton();
      this.radGreen = new System.Windows.Forms.RadioButton();
      this.radBlue = new System.Windows.Forms.RadioButton();
      this.label3 = new System.Windows.Forms.Label();
      this.scrSize = new System.Windows.Forms.HScrollBar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.picHappy = new System.Windows.Forms.PictureBox();
      this.picMad = new System.Windows.Forms.PictureBox();
      this.picIndiff = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // picCritter
      // 
      this.picCritter.Image = ((System.Drawing.Bitmap)(resources.GetObject("picCritter.Image")));
      this.picCritter.Location = new System.Drawing.Point(160, 40);
      this.picCritter.Name = "picCritter";
      this.picCritter.Size = new System.Drawing.Size(50, 50);
      this.picCritter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picCritter.TabIndex = 0;
      this.picCritter.TabStop = false;
      this.picCritter.Click += new System.EventHandler(this.picCritter_Click);
      // 
      // lblName
      // 
      this.lblName.Location = new System.Drawing.Point(160, 8);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(224, 24);
      this.lblName.TabIndex = 1;
      this.lblName.Text = "click me!";
      // 
      // cboMood
      // 
      this.cboMood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboMood.DropDownWidth = 104;
      this.cboMood.Items.AddRange(new object[] {
                                                 "indifferent",
                                                 "happy",
                                                 "mad"});
      this.cboMood.Location = new System.Drawing.Point(16, 40);
      this.cboMood.Name = "cboMood";
      this.cboMood.Size = new System.Drawing.Size(104, 21);
      this.cboMood.TabIndex = 2;
      this.cboMood.SelectedIndexChanged += new System.EventHandler(this.cboMood_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(16, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 16);
      this.label2.TabIndex = 3;
      this.label2.Text = "set my mood";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(24, 120);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(104, 20);
      this.txtName.TabIndex = 4;
      this.txtName.Text = "";
      // 
      // btnName
      // 
      this.btnName.Location = new System.Drawing.Point(24, 152);
      this.btnName.Name = "btnName";
      this.btnName.Size = new System.Drawing.Size(104, 16);
      this.btnName.TabIndex = 5;
      this.btnName.Text = "change my name";
      this.btnName.Click += new System.EventHandler(this.btnName_Click);
      // 
      // radRed
      // 
      this.radRed.Location = new System.Drawing.Point(24, 240);
      this.radRed.Name = "radRed";
      this.radRed.TabIndex = 6;
      this.radRed.Text = "red";
      this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
      // 
      // radGreen
      // 
      this.radGreen.Location = new System.Drawing.Point(24, 272);
      this.radGreen.Name = "radGreen";
      this.radGreen.TabIndex = 7;
      this.radGreen.Text = "green";
      this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
      // 
      // radBlue
      // 
      this.radBlue.Location = new System.Drawing.Point(24, 304);
      this.radBlue.Name = "radBlue";
      this.radBlue.Size = new System.Drawing.Size(104, 16);
      this.radBlue.TabIndex = 8;
      this.radBlue.Text = "blue";
      this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(24, 352);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 16);
      this.label3.TabIndex = 10;
      this.label3.Text = "change my size";
      // 
      // scrSize
      // 
      this.scrSize.Location = new System.Drawing.Point(16, 384);
      this.scrSize.Maximum = 300;
      this.scrSize.Minimum = 50;
      this.scrSize.Name = "scrSize";
      this.scrSize.Size = new System.Drawing.Size(112, 16);
      this.scrSize.TabIndex = 11;
      this.scrSize.Value = 50;
      this.scrSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrSize_Scroll);
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Location = new System.Drawing.Point(8, 344);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(136, 72);
      this.panel1.TabIndex = 12;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                         this.label1});
      this.panel2.Location = new System.Drawing.Point(8, 192);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(136, 136);
      this.panel2.TabIndex = 13;
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel3.Location = new System.Drawing.Point(8, 8);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(136, 64);
      this.panel3.TabIndex = 14;
      // 
      // panel4
      // 
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel4.Location = new System.Drawing.Point(8, 88);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(136, 88);
      this.panel4.TabIndex = 15;
      // 
      // picHappy
      // 
      this.picHappy.Image = ((System.Drawing.Bitmap)(resources.GetObject("picHappy.Image")));
      this.picHappy.Location = new System.Drawing.Point(160, 384);
      this.picHappy.Name = "picHappy";
      this.picHappy.Size = new System.Drawing.Size(48, 40);
      this.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picHappy.TabIndex = 16;
      this.picHappy.TabStop = false;
      this.picHappy.Visible = false;
      // 
      // picMad
      // 
      this.picMad.Image = ((System.Drawing.Bitmap)(resources.GetObject("picMad.Image")));
      this.picMad.Location = new System.Drawing.Point(288, 384);
      this.picMad.Name = "picMad";
      this.picMad.Size = new System.Drawing.Size(48, 40);
      this.picMad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picMad.TabIndex = 16;
      this.picMad.TabStop = false;
      this.picMad.Visible = false;
      // 
      // picIndiff
      // 
      this.picIndiff.Image = ((System.Drawing.Bitmap)(resources.GetObject("picIndiff.Image")));
      this.picIndiff.Location = new System.Drawing.Point(224, 384);
      this.picIndiff.Name = "picIndiff";
      this.picIndiff.Size = new System.Drawing.Size(48, 40);
      this.picIndiff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picIndiff.TabIndex = 16;
      this.picIndiff.TabStop = false;
      this.picIndiff.Visible = false;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(16, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "change my color";
      // 
      // CritterForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(400, 445);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.picIndiff,
                                                                  this.picMad,
                                                                  this.picHappy,
                                                                  this.scrSize,
                                                                  this.label3,
                                                                  this.radBlue,
                                                                  this.radGreen,
                                                                  this.radRed,
                                                                  this.btnName,
                                                                  this.txtName,
                                                                  this.label2,
                                                                  this.cboMood,
                                                                  this.lblName,
                                                                  this.picCritter,
                                                                  this.panel1,
                                                                  this.panel2,
                                                                  this.panel3,
                                                                  this.panel4});
      this.Name = "CritterForm";
      this.Text = "The Visual Critter";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CritterForm());
		}

    private void cboMood_SelectedIndexChanged(object sender, System.EventArgs e) {
      switch (cboMood.Text){
        case "happy":
          picCritter.Image = picHappy.Image;
          break;
        case "indifferent":
          picCritter.Image = picIndiff.Image;
          break;
        case "mad":
          picCritter.Image = picMad.Image;
          break;
        default:
          picCritter.Image = picIndiff.Image;
          break;
      } // end switch 
          
    }// end cboMood event

    private void picCritter_Click(object sender, System.EventArgs e) {
      if (myName == ""){
        lblName.Text = "Please give me a name!";
      } else {
        lblName.Text = "My name is " + myName + "!";
        MessageBox.Show("Hi, my name is " + myName);
      } // end if
    }

    private void btnName_Click(object sender, System.EventArgs e) {
      if (txtName.Text == ""){
        MessageBox.Show("Please enter a name in the text box and click the button again");
      } else {
        myName = txtName.Text;
        MessageBox.Show("OK, You changed my name.");
      } // end if

    }

    private void scrSize_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
      picCritter.Size = new Size(scrSize.Value, scrSize.Value);
    }

    private void radRed_CheckedChanged(object sender, System.EventArgs e) {
      picCritter.BackColor = Color.Red;
    }

    private void radGreen_CheckedChanged(object sender, System.EventArgs e) {
      picCritter.BackColor = Color.Green;
    }

    private void radBlue_CheckedChanged(object sender, System.EventArgs e) {
      picCritter.BackColor = Color.Blue;
    } 
	}
}
