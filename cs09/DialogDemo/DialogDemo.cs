using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace DialogDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class DialogDemo : System.Windows.Forms.Form
	{
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.MenuItem mnuFile;
    private System.Windows.Forms.MenuItem mnuSaveAs;
    private System.Windows.Forms.MenuItem mnuEdit;
    private System.Windows.Forms.MenuItem mnuOpen;
    private System.Windows.Forms.MenuItem mnuExit;
    private System.Windows.Forms.MenuItem mnuFont;
    private System.Windows.Forms.MenuItem mnuForeground;
    private System.Windows.Forms.MenuItem mnuBackground;
    private System.Windows.Forms.TextBox txtEdit;
    private System.Windows.Forms.OpenFileDialog fileGetter;
    private System.Windows.Forms.SaveFileDialog fileSaver;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DialogDemo()
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
      this.fileGetter = new System.Windows.Forms.OpenFileDialog();
      this.fileSaver = new System.Windows.Forms.SaveFileDialog();
      this.fontDialog1 = new System.Windows.Forms.FontDialog();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.mnuFile = new System.Windows.Forms.MenuItem();
      this.mnuSaveAs = new System.Windows.Forms.MenuItem();
      this.mnuOpen = new System.Windows.Forms.MenuItem();
      this.mnuExit = new System.Windows.Forms.MenuItem();
      this.mnuEdit = new System.Windows.Forms.MenuItem();
      this.mnuFont = new System.Windows.Forms.MenuItem();
      this.mnuForeground = new System.Windows.Forms.MenuItem();
      this.mnuBackground = new System.Windows.Forms.MenuItem();
      this.txtEdit = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // fileGetter
      // 
      this.fileGetter.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
      this.fileGetter.InitialDirectory = ".";
      this.fileGetter.FileOk += new System.ComponentModel.CancelEventHandler(this.fileGetter_FileOk);
      // 
      // fileSaver
      // 
      this.fileSaver.DefaultExt = "txt";
      this.fileSaver.FileName = "practice.txt";
      this.fileSaver.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
      this.fileSaver.InitialDirectory = ".";
      this.fileSaver.FileOk += new System.ComponentModel.CancelEventHandler(this.fileSaver_FileOk);
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuFile,
                                                                              this.mnuEdit});
      // 
      // mnuFile
      // 
      this.mnuFile.Index = 0;
      this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.mnuSaveAs,
                                                                            this.mnuOpen,
                                                                            this.mnuExit});
      this.mnuFile.Text = "&File";
      // 
      // mnuSaveAs
      // 
      this.mnuSaveAs.Index = 0;
      this.mnuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
      this.mnuSaveAs.Text = "save &as...";
      this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
      // 
      // mnuOpen
      // 
      this.mnuOpen.Index = 1;
      this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
      this.mnuOpen.Text = "&open";
      this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
      // 
      // mnuExit
      // 
      this.mnuExit.Index = 2;
      this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
      this.mnuExit.Text = "e&xit";
      this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
      // 
      // mnuEdit
      // 
      this.mnuEdit.Index = 1;
      this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.mnuFont,
                                                                            this.mnuForeground,
                                                                            this.mnuBackground});
      this.mnuEdit.Text = "&Edit";
      // 
      // mnuFont
      // 
      this.mnuFont.Index = 0;
      this.mnuFont.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
      this.mnuFont.Text = "font";
      this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
      // 
      // mnuForeground
      // 
      this.mnuForeground.Index = 1;
      this.mnuForeground.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
      this.mnuForeground.Text = "foreground";
      this.mnuForeground.Click += new System.EventHandler(this.mnuForeground_Click);
      // 
      // mnuBackground
      // 
      this.mnuBackground.Index = 2;
      this.mnuBackground.Shortcut = System.Windows.Forms.Shortcut.CtrlB;
      this.mnuBackground.Text = "background";
      this.mnuBackground.Click += new System.EventHandler(this.mnuBackground_Click);
      // 
      // txtEdit
      // 
      this.txtEdit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.txtEdit.Location = new System.Drawing.Point(16, 8);
      this.txtEdit.Multiline = true;
      this.txtEdit.Name = "txtEdit";
      this.txtEdit.Size = new System.Drawing.Size(248, 232);
      this.txtEdit.TabIndex = 0;
      this.txtEdit.Text = "This is my sample text";
      // 
      // DialogDemo
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 276);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.txtEdit});
      this.Menu = this.mainMenu1;
      this.Name = "DialogDemo";
      this.Text = "Dialog Demo";
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new DialogDemo());
		}

    private void mnuExit_Click(object sender, System.EventArgs e) {
      Application.Exit();
    }

    private void mnuSaveAs_Click(object sender, System.EventArgs e) {
      fileSaver.ShowDialog();
    }

    private void fileSaver_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
      StreamWriter sw = new StreamWriter(fileSaver.FileName);
      sw.Write(txtEdit.Text);
      sw.Close();
    }

    private void mnuOpen_Click(object sender, System.EventArgs e) {
      fileGetter.ShowDialog();
    }

    private void fileGetter_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
      StreamReader sr = new StreamReader(fileGetter.FileName);
      txtEdit.Text = sr.ReadToEnd();
      sr.Close();
    }

    private void mnuFont_Click(object sender, System.EventArgs e) {
      if (fontDialog1.ShowDialog() != DialogResult.Cancel){
        txtEdit.Font = fontDialog1.Font;
      } // end if
    } // end mnuFont

    private void mnuForeground_Click(object sender, System.EventArgs e) {
      if (colorDialog1.ShowDialog() != DialogResult.Cancel){
        txtEdit.ForeColor = colorDialog1.Color;
      } // end if
    }

    private void mnuBackground_Click(object sender, System.EventArgs e) {
      if (colorDialog1.ShowDialog() != DialogResult.Cancel){
        txtEdit.BackColor = colorDialog1.Color;
      } // end if
    } // end 

	}
}
