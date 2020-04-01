using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mover
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class theForm : System.Windows.Forms.Form
	{
	  private int dx = 2;
	  private int dy = 0;
    private System.Windows.Forms.PictureBox picArrow;
    private System.Windows.Forms.ImageList myPics;
    private System.Windows.Forms.Timer timer1;
    private System.ComponentModel.IContainer components;

		public theForm()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theForm));
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.myPics = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // picArrow
            // 
            this.picArrow.Image = ((System.Drawing.Image)(resources.GetObject("picArrow.Image")));
            this.picArrow.Location = new System.Drawing.Point(24, 64);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(96, 96);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 0;
            this.picArrow.TabStop = false;
            // 
            // myPics
            // 
            this.myPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myPics.ImageStream")));
            this.myPics.TransparentColor = System.Drawing.Color.Transparent;
            this.myPics.Images.SetKeyName(0, "");
            this.myPics.Images.SetKeyName(1, "");
            this.myPics.Images.SetKeyName(2, "");
            this.myPics.Images.SetKeyName(3, "");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // theForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 389);
            this.Controls.Add(this.picArrow);
            this.KeyPreview = true;
            this.Name = "theForm";
            this.Text = "Press arrow keys ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.theForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new theForm());
		}

    private void theForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
      switch (e.KeyCode){
        case Keys.Right:
          picArrow.Image = myPics.Images[0];
          dx = 2;
          dy = 0;
          break;
        case Keys.Down:
          picArrow.Image = myPics.Images[1];
          dx = 0;
          dy = 2;
          break;
        case Keys.Left:
          picArrow.Image = myPics.Images[2];
          dx = -2;
          dy = 0;
          break;
        case Keys.Up:
          picArrow.Image = myPics.Images[3];
          dx = 0;
          dy = -2;
          break;
      } // end switch
    }

    private void timer1_Tick(object sender, System.EventArgs e) {
      int newX, newY;

      //change X value 
      newX = picArrow.Location.X + dx;

      //check right boundary
      if (newX > this.Width){
        newX = 0;
      } // end if

      //check left boundary
      if (newX < 0){
        newX = this.Width - picArrow.Width;
      } // end if

      //change Y value
      newY = picArrow.Location.Y + dy;

      //check top
      if (newY < 0){
        newY = this.Height - picArrow.Height;
      } // end if

      //check bottom
      if (newY > this.Height){
        newY = 0;
      } // end if

      //create new point, assign to picArrow
      Point newLoc = new Point(newX, newY);
      picArrow.Location = newLoc;
    } // end timer tick

	}
}
