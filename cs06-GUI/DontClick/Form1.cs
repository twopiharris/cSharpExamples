using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DontClick
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Button btnDont;
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(32, 24);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(232, 96);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Don\'t Click the button!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnDont
            // 
            this.btnDont.Location = new System.Drawing.Point(72, 152);
            this.btnDont.Name = "btnDont";
            this.btnDont.Size = new System.Drawing.Size(144, 48);
            this.btnDont.TabIndex = 1;
            this.btnDont.Text = "Don\'t Click Me!!";
            this.btnDont.Click += new System.EventHandler(this.btnDont_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnDont);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Don\'t Click";
            this.Click += new System.EventHandler(this.Form1_Click);
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

    private void btnDont_Click(object sender, System.EventArgs e) {
      lblMessage.Text = "Ouch!!!";
    }

        private void Form1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Click on the button!";
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "You clicked on the label.";
        }
    }
}
