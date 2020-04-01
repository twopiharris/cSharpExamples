using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Crasher
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
    private int dx = 4;
    private System.Windows.Forms.PictureBox picTarget;
    private System.Windows.Forms.PictureBox picBall;
    private System.Windows.Forms.Timer timer1;
    private System.ComponentModel.IContainer components;

		public Form1()
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
      this.picTarget = new System.Windows.Forms.PictureBox();
      this.picBall = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // picTarget
      // 
      this.picTarget.Image = ((System.Drawing.Bitmap)(resources.GetObject("picTarget.Image")));
      this.picTarget.Location = new System.Drawing.Point(160, 120);
      this.picTarget.Name = "picTarget";
      this.picTarget.Size = new System.Drawing.Size(56, 56);
      this.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picTarget.TabIndex = 0;
      this.picTarget.TabStop = false;
      // 
      // picBall
      // 
      this.picBall.Image = ((System.Drawing.Bitmap)(resources.GetObject("picBall.Image")));
      this.picBall.Location = new System.Drawing.Point(24, 136);
      this.picBall.Name = "picBall";
      this.picBall.Size = new System.Drawing.Size(32, 32);
      this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picBall.TabIndex = 1;
      this.picBall.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(392, 341);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.picBall,
                                                                  this.picTarget});
      this.Name = "Form1";
      this.Text = "Crasher";
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

    private void timer1_Tick(object sender, System.EventArgs e) {
      int newX, newY;
      newX = picBall.Location.X + dx;
      newY = picBall.Location.Y;
      
      //check for borders
      if (newX > this.Width - picBall.Width){
        dx = - dx;
      } // end if
      
      if (newX < 0){
        dx = - dx;
      } // end if
      
      // look for collision
      if (picBall.Bounds.IntersectsWith(picTarget.Bounds)){
        this.BackColor = Color.Black;
      } else {
        this.BackColor = Color.White;
      } //end if
      
      picBall.Location = new Point(newX, newY);
    }
	}
}
