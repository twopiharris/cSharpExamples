using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace FileIO
{
	/// <summary>
	/// Demonstrate basic text-based file IO
	/// 3/11/02  Andy Harris
	/// </summary>
	public class FileIODemo : System.Windows.Forms.Form
	{
    private System.Windows.Forms.TextBox txtEdit;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.Button btnSave;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FileIODemo()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
      this.txtEdit = new System.Windows.Forms.TextBox();
      this.btnLoad = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtEdit
      // 
      this.txtEdit.Location = new System.Drawing.Point(32, 24);
      this.txtEdit.Multiline = true;
      this.txtEdit.Name = "txtEdit";
      this.txtEdit.Size = new System.Drawing.Size(272, 216);
      this.txtEdit.TabIndex = 0;
      this.txtEdit.Text = "Here is some sample text.  It isn\'t fancy, but it\'s a start.";
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(48, 272);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(88, 32);
      this.btnLoad.TabIndex = 1;
      this.btnLoad.Text = "load";
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(192, 272);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(88, 32);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "save";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // FileIODemo
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(352, 341);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnSave,
                                                                  this.btnLoad,
                                                                  this.txtEdit});
      this.Name = "FileIODemo";
      this.Text = "Simple File IO";
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FileIODemo());
		}

    private void btnSave_Click(object sender, System.EventArgs e) {
      StreamWriter sw = new StreamWriter("practice.txt");
      sw.Write(txtEdit.Text);
      sw.Close();
    } // end btnSave 

    private void btnLoad_Click(object sender, System.EventArgs e) {
      StreamReader sr = new StreamReader("practice.txt");
      txtEdit.Text = sr.ReadToEnd(); 
      sr.Close();   
    } // end btnLoad
	} // end class def
} // end namespace
