using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace Adventure
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
	  //classes for game and editor screens
    private Editor theEditor = new Editor();
    private Game theGame = new Game();
    private Dungeon theDungeon = new Dungeon();
    private string gameFile = "";
    
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnPlay;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.MenuItem menuItem1;
    private System.Windows.Forms.MenuItem menuItem2;
    private System.Windows.Forms.Label lblCurrent;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.OpenFileDialog fileOpener;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
      this.btnPlay = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.menuItem1 = new System.Windows.Forms.MenuItem();
      this.menuItem2 = new System.Windows.Forms.MenuItem();
      this.lblCurrent = new System.Windows.Forms.Label();
      this.btnLoad = new System.Windows.Forms.Button();
      this.fileOpener = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // btnPlay
      // 
      this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.btnPlay.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnPlay.Image")));
      this.btnPlay.Location = new System.Drawing.Point(64, 144);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(200, 40);
      this.btnPlay.TabIndex = 1;
      this.btnPlay.Text = "Play";
      this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.btnEdit.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnEdit.Image")));
      this.btnEdit.Location = new System.Drawing.Point(64, 192);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(200, 40);
      this.btnEdit.TabIndex = 2;
      this.btnEdit.Text = "Edit";
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.btnQuit.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnQuit.Image")));
      this.btnQuit.Location = new System.Drawing.Point(64, 240);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(200, 40);
      this.btnQuit.TabIndex = 3;
      this.btnQuit.Text = "Quit";
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(328, 320);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.label1.Image = ((System.Drawing.Bitmap)(resources.GetObject("label1.Image")));
      this.label1.Location = new System.Drawing.Point(56, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(208, 16);
      this.label1.TabIndex = 4;
      this.label1.Text = "Adventure Kit";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.menuItem1});
      // 
      // menuItem1
      // 
      this.menuItem1.Index = 0;
      this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.menuItem2});
      this.menuItem1.Text = "&File";
      // 
      // menuItem2
      // 
      this.menuItem2.Index = 0;
      this.menuItem2.Text = "&Open Game";
      // 
      // lblCurrent
      // 
      this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.lblCurrent.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblCurrent.Image")));
      this.lblCurrent.Location = new System.Drawing.Point(48, 64);
      this.lblCurrent.Name = "lblCurrent";
      this.lblCurrent.Size = new System.Drawing.Size(248, 24);
      this.lblCurrent.TabIndex = 5;
      this.lblCurrent.Text = "Game:";
      this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnLoad
      // 
      this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.btnLoad.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnLoad.Image")));
      this.btnLoad.Location = new System.Drawing.Point(64, 96);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(200, 40);
      this.btnLoad.TabIndex = 0;
      this.btnLoad.Text = "Load";
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // fileOpener
      // 
      this.fileOpener.Filter = "Adventure files |*.adv|All files|*.*";
      this.fileOpener.InitialDirectory = ".";
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.SaddleBrown;
      this.ClientSize = new System.Drawing.Size(328, 318);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnLoad,
                                                                  this.lblCurrent,
                                                                  this.label1,
                                                                  this.btnQuit,
                                                                  this.btnEdit,
                                                                  this.btnPlay,
                                                                  this.pictureBox1});
      this.Menu = this.mainMenu1;
      this.Name = "MainForm";
      this.Text = "Adventure Kit";
      this.TransparencyKey = System.Drawing.Color.LimeGreen;
      this.ResumeLayout(false);

    }
        #endregion
        [STAThread]
        public static void Main(){
      Application.Run(new MainForm());
    }

    private void btnPlay_Click(object sender, System.EventArgs e) {
      if (gameFile != ""){
        theGame = new Game();
        theGame.Show();
        theGame.OpenGame(theDungeon);
      } else {
        MessageBox.Show("Please load a game first");
      } // end if
    } // end btnPlay

    private void btnEdit_Click(object sender, System.EventArgs e) {
      theEditor = new Editor();
      theEditor.Show();
      if (gameFile != ""){
        theEditor.OpenGame(theDungeon);
      } // end if
    } // end btnEdit

    private void btnLoad_Click(object sender, System.EventArgs e) {

      //read the data from a binary file
      FileStream s;
      BinaryFormatter bf = new BinaryFormatter();
      if (fileOpener.ShowDialog() != DialogResult.Cancel){
        gameFile = fileOpener.FileName;
        s = new FileStream(fileOpener.FileName, FileMode.Open);
        theDungeon = (Dungeon) bf.Deserialize(s);
        s.Close();
        lblCurrent.Text = "Game: " + theDungeon.Name;
      } // end if
    } // end btnLoad

    private void btnQuit_Click(object sender, System.EventArgs e) {
      Application.Exit();
    }

 	} // end class def
} // end namespace
