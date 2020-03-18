using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sizer
{
	/// <summary>
	/// Demonstrates scroll bars and picture boxes
	/// Andy Harris, 01/01/02
	/// </summary>
	public class Sizer : System.Windows.Forms.Form
	{
    private System.Windows.Forms.PictureBox picCritter;
    private System.Windows.Forms.HScrollBar scrSize;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
    
    public static void Main(){
      Application.Run(new Sizer());
    } // end main

		public Sizer()
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
				if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sizer));
            this.picCritter = new System.Windows.Forms.PictureBox();
            this.scrSize = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picCritter)).BeginInit();
            this.SuspendLayout();
            // 
            // picCritter
            // 
            this.picCritter.BackColor = System.Drawing.Color.White;
            this.picCritter.Image = ((System.Drawing.Image)(resources.GetObject("picCritter.Image")));
            this.picCritter.Location = new System.Drawing.Point(8, 8);
            this.picCritter.Name = "picCritter";
            this.picCritter.Size = new System.Drawing.Size(51, 59);
            this.picCritter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCritter.TabIndex = 0;
            this.picCritter.TabStop = false;
            // 
            // scrSize
            // 
            this.scrSize.Location = new System.Drawing.Point(16, 248);
            this.scrSize.Maximum = 200;
            this.scrSize.Minimum = 50;
            this.scrSize.Name = "scrSize";
            this.scrSize.Size = new System.Drawing.Size(256, 16);
            this.scrSize.TabIndex = 1;
            this.scrSize.Value = 50;
            this.scrSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrSize_Scroll);
            // 
            // Sizer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.scrSize);
            this.Controls.Add(this.picCritter);
            this.Name = "Sizer";
            this.Text = "Sizer";
            ((System.ComponentModel.ISupportInitialize)(this.picCritter)).EndInit();
            this.ResumeLayout(false);

    }
		#endregion

    private void scrSize_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
      picCritter.Size = new Size(scrSize.Value, scrSize.Value);
    }
	}
	}
