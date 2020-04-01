using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace quizzer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class XmlMainForm : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Button btnTake;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnQuit;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

    private frmQuiz theQuiz;
    private frmEdit theEditor;

		public XmlMainForm()
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
      this.btnTake = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnTake
      // 
      this.btnTake.Location = new System.Drawing.Point(56, 48);
      this.btnTake.Name = "btnTake";
      this.btnTake.Size = new System.Drawing.Size(184, 40);
      this.btnTake.TabIndex = 0;
      this.btnTake.Text = "Take Quiz";
      this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(56, 112);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(184, 32);
      this.btnEdit.TabIndex = 1;
      this.btnEdit.Text = "Edit Quiz";
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Location = new System.Drawing.Point(56, 168);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(184, 40);
      this.btnQuit.TabIndex = 2;
      this.btnQuit.Text = "Quit";
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // XmlMainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnQuit,
                                                                  this.btnEdit,
                                                                  this.btnTake});
      this.Name = "XmlMainForm";
      this.Text = "XML Quiz Machine";
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new XmlMainForm());
		}

    private void btnTake_Click(object sender, System.EventArgs e) {
      theQuiz = new frmQuiz();
      theQuiz.Show();
    }

    private void btnEdit_Click(object sender, System.EventArgs e) {
      theEditor = new frmEdit();
      theEditor.Show();
    }

    private void btnQuit_Click(object sender, System.EventArgs e) {
      Application.Exit();
    } // end btnTake
    
	}
}
