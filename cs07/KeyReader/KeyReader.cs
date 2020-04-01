using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace KeyReader
{
	/// <summary>
	/// Summary description for KeyReader.
	/// </summary>
	public class KeyReader : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Label lblPress;
    private System.Windows.Forms.Label lblDown;
    private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyReader()
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
            this.lblPress = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPress
            // 
            this.lblPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(8, 190);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(408, 48);
            this.lblPress.TabIndex = 0;
            this.lblPress.Text = "Press:";
            this.lblPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDown
            // 
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.Location = new System.Drawing.Point(8, 254);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(408, 48);
            this.lblDown.TabIndex = 0;
            this.lblDown.Text = "Down:";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please type several keys to see how the KeyPress and KeyDown events respond. ";
            // 
            // KeyReader
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(424, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblPress);
            this.KeyPreview = true;
            this.Name = "KeyReader";
            this.Text = "KeyReader";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyReader_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyReader_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyReader_KeyUp);
            this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new KeyReader());
		}

    private void KeyReader_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
      lblPress.Text =  "Press: " + Convert.ToString(e.KeyChar);
    }

    private void KeyReader_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
      lblDown.Text = "Down: " + Convert.ToString(e.KeyCode);
      if (e.KeyCode == Keys.ShiftKey){
        MessageBox.Show("That is one shifty character");
      } // end if
    } // end KeyDown

        private void KeyReader_KeyUp(object sender, KeyEventArgs e)
        {
            lblDown.Text = "Down: ";
        }
    }
}
