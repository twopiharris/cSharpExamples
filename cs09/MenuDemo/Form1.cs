using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MenuDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
    private System.Windows.Forms.MainMenu mnuMain;
    private System.Windows.Forms.MenuItem mnuFile;
    private System.Windows.Forms.MenuItem mnuCount;
    private System.Windows.Forms.MenuItem mnuEnglish;
    private System.Windows.Forms.MenuItem muEng1;
    private System.Windows.Forms.MenuItem mnuEng2;
    private System.Windows.Forms.MenuItem mnuEng3;
    private System.Windows.Forms.MenuItem mnuJapan;
    private System.Windows.Forms.MenuItem mnuJapan1;
    private System.Windows.Forms.MenuItem mnuJapan2;
    private System.Windows.Forms.MenuItem mnuJapan3;
    private System.Windows.Forms.MenuItem mnuFrench;
    private System.Windows.Forms.MenuItem mnuFr1;
    private System.Windows.Forms.MenuItem mnuFr2;
    private System.Windows.Forms.MenuItem mnuFr3;
    private System.Windows.Forms.MenuItem mnuExit;
    private System.Windows.Forms.Label lblNumber;
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
      this.mnuMain = new System.Windows.Forms.MainMenu();
      this.mnuFile = new System.Windows.Forms.MenuItem();
      this.mnuExit = new System.Windows.Forms.MenuItem();
      this.mnuCount = new System.Windows.Forms.MenuItem();
      this.mnuEnglish = new System.Windows.Forms.MenuItem();
      this.muEng1 = new System.Windows.Forms.MenuItem();
      this.mnuEng2 = new System.Windows.Forms.MenuItem();
      this.mnuEng3 = new System.Windows.Forms.MenuItem();
      this.mnuJapan = new System.Windows.Forms.MenuItem();
      this.mnuJapan1 = new System.Windows.Forms.MenuItem();
      this.mnuJapan2 = new System.Windows.Forms.MenuItem();
      this.mnuJapan3 = new System.Windows.Forms.MenuItem();
      this.mnuFrench = new System.Windows.Forms.MenuItem();
      this.mnuFr1 = new System.Windows.Forms.MenuItem();
      this.mnuFr2 = new System.Windows.Forms.MenuItem();
      this.mnuFr3 = new System.Windows.Forms.MenuItem();
      this.lblNumber = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // mnuMain
      // 
      this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.mnuFile,
                                                                            this.mnuCount});
      // 
      // mnuFile
      // 
      this.mnuFile.Index = 0;
      this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.mnuExit});
      this.mnuFile.Text = "&File";
      // 
      // mnuExit
      // 
      this.mnuExit.Index = 0;
      this.mnuExit.Text = "E&xit";
      this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
      // 
      // mnuCount
      // 
      this.mnuCount.Index = 1;
      this.mnuCount.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                             this.mnuEnglish,
                                                                             this.mnuJapan,
                                                                             this.mnuFrench});
      this.mnuCount.Text = "&Count";
      // 
      // mnuEnglish
      // 
      this.mnuEnglish.Index = 0;
      this.mnuEnglish.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                               this.muEng1,
                                                                               this.mnuEng2,
                                                                               this.mnuEng3});
      this.mnuEnglish.Text = "&English";
      // 
      // muEng1
      // 
      this.muEng1.Index = 0;
      this.muEng1.Text = "1";
      this.muEng1.Click += new System.EventHandler(this.muEng1_Click);
      // 
      // mnuEng2
      // 
      this.mnuEng2.Index = 1;
      this.mnuEng2.Text = "2";
      this.mnuEng2.Click += new System.EventHandler(this.mnuEng2_Click);
      // 
      // mnuEng3
      // 
      this.mnuEng3.Index = 2;
      this.mnuEng3.Text = "3";
      this.mnuEng3.Click += new System.EventHandler(this.mnuEng3_Click);
      // 
      // mnuJapan
      // 
      this.mnuJapan.Index = 1;
      this.mnuJapan.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                             this.mnuJapan1,
                                                                             this.mnuJapan2,
                                                                             this.mnuJapan3});
      this.mnuJapan.Text = "&Japanese";
      // 
      // mnuJapan1
      // 
      this.mnuJapan1.Index = 0;
      this.mnuJapan1.Text = "1";
      this.mnuJapan1.Click += new System.EventHandler(this.mnuJapan1_Click);
      // 
      // mnuJapan2
      // 
      this.mnuJapan2.Index = 1;
      this.mnuJapan2.Text = "2";
      this.mnuJapan2.Click += new System.EventHandler(this.mnuJapan2_Click);
      // 
      // mnuJapan3
      // 
      this.mnuJapan3.Index = 2;
      this.mnuJapan3.Text = "3";
      this.mnuJapan3.Click += new System.EventHandler(this.mnuJapan3_Click);
      // 
      // mnuFrench
      // 
      this.mnuFrench.Index = 2;
      this.mnuFrench.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuFr1,
                                                                              this.mnuFr2,
                                                                              this.mnuFr3});
      this.mnuFrench.Text = "&French";
      // 
      // mnuFr1
      // 
      this.mnuFr1.Index = 0;
      this.mnuFr1.Text = "1";
      this.mnuFr1.Click += new System.EventHandler(this.mnuFr1_Click);
      // 
      // mnuFr2
      // 
      this.mnuFr2.Index = 1;
      this.mnuFr2.Text = "2";
      this.mnuFr2.Click += new System.EventHandler(this.mnuFr2_Click);
      // 
      // mnuFr3
      // 
      this.mnuFr3.Index = 2;
      this.mnuFr3.Text = "3";
      this.mnuFr3.Click += new System.EventHandler(this.mnuFr3_Click);
      // 
      // lblNumber
      // 
      this.lblNumber.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.lblNumber.Location = new System.Drawing.Point(32, 48);
      this.lblNumber.Name = "lblNumber";
      this.lblNumber.Size = new System.Drawing.Size(232, 80);
      this.lblNumber.TabIndex = 0;
      this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 274);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.lblNumber});
      this.Menu = this.mnuMain;
      this.Name = "Form1";
      this.Text = "Menu Demo";
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


    private void muEng1_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "one";
    }

    private void mnuEng2_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "two";
    }

    private void mnuEng3_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "three";
    }

    private void mnuJapan1_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "ichi";
    }

    private void mnuJapan2_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "ni";
    }

    private void mnuJapan3_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "san";
    }

    private void mnuFr1_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "un";
    }

    private void mnuFr2_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "deux";
    }

    private void mnuFr3_Click(object sender, System.EventArgs e) {
      lblNumber.Text = "trois";
    }

    private void mnuExit_Click(object sender, System.EventArgs e) {
      Application.Exit();
    } // end setupMenu

	}
}
