using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AutoSpin
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmAuto : System.Windows.Forms.Form
	{
    private int counter;
    private System.Windows.Forms.PictureBox picGlobe;
    private System.Windows.Forms.ImageList myPics;
    private System.Windows.Forms.Timer timer1;
    private System.ComponentModel.IContainer components;

		public frmAuto()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuto));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picGlobe = new System.Windows.Forms.PictureBox();
            this.myPics = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGlobe)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picGlobe
            // 
            this.picGlobe.Image = ((System.Drawing.Image)(resources.GetObject("picGlobe.Image")));
            this.picGlobe.Location = new System.Drawing.Point(144, 48);
            this.picGlobe.Name = "picGlobe";
            this.picGlobe.Size = new System.Drawing.Size(152, 144);
            this.picGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlobe.TabIndex = 0;
            this.picGlobe.TabStop = false;
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
            // frmAuto
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 373);
            this.Controls.Add(this.picGlobe);
            this.Name = "frmAuto";
            this.Text = "Automatic Spinning";
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
			Application.Run(new frmAuto());
		}

    private void timer1_Tick(object sender, System.EventArgs e) {
      counter++;
      if (counter >= 10){
        counter = 0;
      } // end if
      picGlobe.Image = myPics.Images[counter];
    }
	}
}
