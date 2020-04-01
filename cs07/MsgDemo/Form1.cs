using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MsgDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Button btnYesNo;
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
      this.btnYesNo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnYesNo
      // 
      this.btnYesNo.Location = new System.Drawing.Point(64, 120);
      this.btnYesNo.Name = "btnYesNo";
      this.btnYesNo.Size = new System.Drawing.Size(136, 24);
      this.btnYesNo.TabIndex = 0;
      this.btnYesNo.Text = "Place an Order";
      this.btnYesNo.Click += new System.EventHandler(this.btnYesNo_Click);
      // 
      // Form1
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnYesNo});
      this.Name = "Form1";
      this.Text = "MsgDemo";
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

    private void btnYesNo_Click(object sender, System.EventArgs e) {
      DialogResult reply;
      reply = MessageBox.Show(
        "Do you want fries with that?", 
        "Yes or No Demo", 
        MessageBoxButtons.YesNo, 
        MessageBoxIcon.Question);
      if (reply == DialogResult.Yes){
        MessageBox.Show("Here's your fries");
      } else {
        MessageBox.Show("No fries");
      } // end if
    } // end btnYesNo
	}
}
