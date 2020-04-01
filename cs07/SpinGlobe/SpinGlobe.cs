using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SpinGlobe
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmGlobe : System.Windows.Forms.Form
	{
    
    private int counter = 0;
    
    private System.Windows.Forms.PictureBox picGlobe;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.ImageList myPics;
    private System.ComponentModel.IContainer components;

		public frmGlobe()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlobe));
            this.picGlobe = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.myPics = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).BeginInit();
            this.SuspendLayout();
            // 
            // picGlobe
            // 
            this.picGlobe.BackColor = System.Drawing.Color.Transparent;
            this.picGlobe.Image = ((System.Drawing.Image)(resources.GetObject("picGlobe.Image")));
            this.picGlobe.Location = new System.Drawing.Point(216, 56);
            this.picGlobe.Name = "picGlobe";
            this.picGlobe.Size = new System.Drawing.Size(128, 136);
            this.picGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlobe.TabIndex = 0;
            this.picGlobe.TabStop = false;
            this.picGlobe.Click += new System.EventHandler(this.picGlobe_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(200, 224);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 32);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // myPics
            // 
            this.myPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myPics.ImageStream")));
            this.myPics.TransparentColor = System.Drawing.Color.Transparent;
            this.myPics.Images.SetKeyName(0, "");
            this.myPics.Images.SetKeyName(1, "");
            this.myPics.Images.SetKeyName(2, "");
            this.myPics.Images.SetKeyName(3, "");
            this.myPics.Images.SetKeyName(4, "");
            this.myPics.Images.SetKeyName(5, "");
            this.myPics.Images.SetKeyName(6, "");
            this.myPics.Images.SetKeyName(7, "");
            this.myPics.Images.SetKeyName(8, "");
            this.myPics.Images.SetKeyName(9, "");
            // 
            // frmGlobe
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 357);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picGlobe);
            this.Name = "frmGlobe";
            this.Text = "Spin the Globe!";
            this.Load += new System.EventHandler(this.frmGlobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).EndInit();
            this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmGlobe());
		}

    private void picGlobe_Click(object sender, System.EventArgs e) {

    }

    private void frmGlobe_Load(object sender, System.EventArgs e) {
      counter = 0;
    }

    private void btnNext_Click(object sender, System.EventArgs e) {
      counter++;
      if (counter >= 10){
        counter = 0;
      } // end if
      picGlobe.Image = myPics.Images[counter];
    } // end btnNext_Click
	} // end class def
} // end namespace
