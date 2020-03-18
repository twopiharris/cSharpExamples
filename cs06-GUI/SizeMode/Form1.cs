using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SizeMode
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.White;
      this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(24, 24);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(136, 128);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackColor = System.Drawing.Color.White;
      this.pictureBox2.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(280, 24);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(136, 128);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 0;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
      // 
      // pictureBox3
      // 
      this.pictureBox3.BackColor = System.Drawing.Color.White;
      this.pictureBox3.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(32, 232);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(136, 128);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox3.TabIndex = 0;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
      // 
      // pictureBox4
      // 
      this.pictureBox4.BackColor = System.Drawing.Color.White;
      this.pictureBox4.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox4.Image")));
      this.pictureBox4.Location = new System.Drawing.Point(264, 216);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(256, 256);
      this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox4.TabIndex = 0;
      this.pictureBox4.TabStop = false;
      this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(72, 160);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "Normal";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(328, 160);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "StretchImage";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(88, 200);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 16);
      this.label3.TabIndex = 3;
      this.label3.Text = "Center";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(352, 200);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 16);
      this.label4.TabIndex = 4;
      this.label4.Text = "AutoSize";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Location = new System.Drawing.Point(8, 8);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(208, 176);
      this.panel1.TabIndex = 5;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2.Location = new System.Drawing.Point(8, 192);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(208, 184);
      this.panel2.TabIndex = 6;
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel3.Location = new System.Drawing.Point(256, 192);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(272, 296);
      this.panel3.TabIndex = 7;
      // 
      // panel4
      // 
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel4.Location = new System.Drawing.Point(256, 8);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(200, 176);
      this.panel4.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(472, 389);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.pictureBox4,
                                                                  this.label4,
                                                                  this.label3,
                                                                  this.label2,
                                                                  this.label1,
                                                                  this.pictureBox3,
                                                                  this.pictureBox2,
                                                                  this.pictureBox1,
                                                                  this.panel1,
                                                                  this.panel2,
                                                                  this.panel3,
                                                                  this.panel4});
      this.Name = "Form1";
      this.Text = "SizeMode Demo";
      this.Load += new System.EventHandler(this.Form1_Load);
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

    private void pictureBox2_Click(object sender, System.EventArgs e) {

    }

    private void Form1_Load(object sender, System.EventArgs e) {

    }

    private void pictureBox1_Click(object sender, System.EventArgs e) {

    }

    private void pictureBox3_Click(object sender, System.EventArgs e) {

    }

    private void pictureBox4_Click(object sender, System.EventArgs e) {

    }
	}
}
