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
	/// Adventure Editor
	/// Allows you to edit a simple adventure game
	/// and store it as a binary file.
	/// By Andy Harris, 3/11/02
	/// </summary>
	public class Editor : System.Windows.Forms.Form
	{
    private Dungeon theDungeon = new Dungeon();
    private int roomNum = 1;
	  
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.ComboBox cboNorth;
    private System.Windows.Forms.ComboBox cboWest;
    private System.Windows.Forms.ComboBox cboEast;
    private System.Windows.Forms.ComboBox cboSouth;
    private System.Windows.Forms.Button btnPrev;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblRoomNum;
    private System.Windows.Forms.OpenFileDialog fileOpener;
    private System.Windows.Forms.SaveFileDialog fileSaver;
    private System.Windows.Forms.MenuItem mnuFile;
    private System.Windows.Forms.MenuItem mnuExit;
    private System.Windows.Forms.MenuItem mnuSaveAs;
    private System.Windows.Forms.MenuItem mnuOpen;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.MenuItem mnuNewGame;
    private System.Windows.Forms.MenuItem mnuPlay;
    private System.Windows.Forms.TextBox txtGameName;
    private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Editor()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		} // end constructor

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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Editor));
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.cboNorth = new System.Windows.Forms.ComboBox();
      this.cboWest = new System.Windows.Forms.ComboBox();
      this.cboEast = new System.Windows.Forms.ComboBox();
      this.cboSouth = new System.Windows.Forms.ComboBox();
      this.btnPrev = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.mnuFile = new System.Windows.Forms.MenuItem();
      this.mnuNewGame = new System.Windows.Forms.MenuItem();
      this.mnuOpen = new System.Windows.Forms.MenuItem();
      this.mnuSaveAs = new System.Windows.Forms.MenuItem();
      this.mnuPlay = new System.Windows.Forms.MenuItem();
      this.mnuExit = new System.Windows.Forms.MenuItem();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblRoomNum = new System.Windows.Forms.Label();
      this.fileOpener = new System.Windows.Forms.OpenFileDialog();
      this.fileSaver = new System.Windows.Forms.SaveFileDialog();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.txtGameName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtDescription
      // 
      this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.txtDescription.Location = new System.Drawing.Point(184, 80);
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(216, 208);
      this.txtDescription.TabIndex = 0;
      this.txtDescription.Text = "";
      // 
      // cboNorth
      // 
      this.cboNorth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboNorth.Location = new System.Drawing.Point(184, 56);
      this.cboNorth.Name = "cboNorth";
      this.cboNorth.Size = new System.Drawing.Size(216, 21);
      this.cboNorth.TabIndex = 1;
      // 
      // cboWest
      // 
      this.cboWest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboWest.Location = new System.Drawing.Point(24, 168);
      this.cboWest.Name = "cboWest";
      this.cboWest.Size = new System.Drawing.Size(152, 21);
      this.cboWest.TabIndex = 2;
      // 
      // cboEast
      // 
      this.cboEast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboEast.Location = new System.Drawing.Point(408, 176);
      this.cboEast.Name = "cboEast";
      this.cboEast.Size = new System.Drawing.Size(144, 21);
      this.cboEast.TabIndex = 3;
      // 
      // cboSouth
      // 
      this.cboSouth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboSouth.Location = new System.Drawing.Point(184, 304);
      this.cboSouth.Name = "cboSouth";
      this.cboSouth.Size = new System.Drawing.Size(216, 21);
      this.cboSouth.TabIndex = 4;
      // 
      // btnPrev
      // 
      this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.btnPrev.Location = new System.Drawing.Point(88, 368);
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(88, 24);
      this.btnPrev.TabIndex = 5;
      this.btnPrev.Text = "Prev";
      this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
      // 
      // btnNext
      // 
      this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.btnNext.Location = new System.Drawing.Point(320, 368);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(104, 24);
      this.btnNext.TabIndex = 6;
      this.btnNext.Text = "Next";
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuFile});
      // 
      // mnuFile
      // 
      this.mnuFile.Index = 0;
      this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.mnuNewGame,
                                                                            this.mnuOpen,
                                                                            this.mnuSaveAs,
                                                                            this.mnuPlay,
                                                                            this.mnuExit});
      this.mnuFile.Text = "&File";
      // 
      // mnuNewGame
      // 
      this.mnuNewGame.Index = 0;
      this.mnuNewGame.Text = "&new game";
      this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
      // 
      // mnuOpen
      // 
      this.mnuOpen.Index = 1;
      this.mnuOpen.Text = "&open game...";
      this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
      // 
      // mnuSaveAs
      // 
      this.mnuSaveAs.Index = 2;
      this.mnuSaveAs.Text = "save game &as...";
      this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
      // 
      // mnuPlay
      // 
      this.mnuPlay.Index = 3;
      this.mnuPlay.Text = "&play game";
      this.mnuPlay.Click += new System.EventHandler(this.mnuPlay_Click);
      // 
      // mnuExit
      // 
      this.mnuExit.Index = 4;
      this.mnuExit.Text = "e&xit editor";
      this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(184, 24);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(216, 20);
      this.txtName.TabIndex = 7;
      this.txtName.Text = "";
      // 
      // lblRoomNum
      // 
      this.lblRoomNum.ForeColor = System.Drawing.Color.White;
      this.lblRoomNum.Location = new System.Drawing.Point(448, 16);
      this.lblRoomNum.Name = "lblRoomNum";
      this.lblRoomNum.Size = new System.Drawing.Size(104, 24);
      this.lblRoomNum.TabIndex = 8;
      this.lblRoomNum.Text = "room ";
      // 
      // fileOpener
      // 
      this.fileOpener.DefaultExt = "adv";
      this.fileOpener.Filter = "Adventure games |*. adv|All files | *.*";
      this.fileOpener.InitialDirectory = ".";
      // 
      // fileSaver
      // 
      this.fileSaver.FileName = "practice.adv";
      this.fileSaver.Filter = "Adventure games |*. adv|All files |*.*";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(8, 16);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(552, 360);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 9;
      this.pictureBox1.TabStop = false;
      // 
      // txtGameName
      // 
      this.txtGameName.Location = new System.Drawing.Point(24, 88);
      this.txtGameName.Name = "txtGameName";
      this.txtGameName.Size = new System.Drawing.Size(144, 20);
      this.txtGameName.TabIndex = 10;
      this.txtGameName.Text = "practice";
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.label1.Image = ((System.Drawing.Bitmap)(resources.GetObject("label1.Image")));
      this.label1.Location = new System.Drawing.Point(24, 56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(144, 24);
      this.label1.TabIndex = 11;
      this.label1.Text = "Game Name:";
      // 
      // Editor
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.SaddleBrown;
      this.ClientSize = new System.Drawing.Size(568, 410);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.label1,
                                                                  this.txtGameName,
                                                                  this.lblRoomNum,
                                                                  this.txtName,
                                                                  this.btnNext,
                                                                  this.btnPrev,
                                                                  this.cboSouth,
                                                                  this.cboEast,
                                                                  this.cboWest,
                                                                  this.cboNorth,
                                                                  this.txtDescription,
                                                                  this.pictureBox1});
      this.Menu = this.mainMenu1;
      this.Name = "Editor";
      this.Text = "Dungeon Editor";
      this.Load += new System.EventHandler(this.Editor_Load);
      this.ResumeLayout(false);

    }
		#endregion

    private void Editor_Load(object sender, System.EventArgs e) {
      setupRooms();
      setupCombos();
    } // end editorLoad
    
    private void setupRooms(){
      //initialize rooms
      int i; 
      for (i = 0; i < theDungeon.NumRooms; i++){
        theDungeon.Rooms[i] = new Room(
          "room " + Convert.ToString(i),
          "",
          0,0,0,0);
      } // end for loop
    } // end setupRooms
    
    private void setupCombos(){
      //ensures the combo boxes are up-to-date
      int i;
      
      //clear the combos, if necessary
      cboNorth.Items.Clear();
      cboEast.Items.Clear();
      cboSouth.Items.Clear();
      cboWest.Items.Clear();
      
      //repopulate the combos
      for (i = 0; i < theDungeon.NumRooms; i++){
        cboNorth.Items.Add(theDungeon.Rooms[i].Name);
        cboEast.Items.Add(theDungeon.Rooms[i].Name);
        cboSouth.Items.Add(theDungeon.Rooms[i].Name);
        cboWest.Items.Add(theDungeon.Rooms[i].Name);
      } // end for loop  
      
      //preselect room zero
      cboNorth.SelectedIndex = 0;
      cboEast.SelectedIndex = 0;
      cboSouth.SelectedIndex = 0;
      cboWest.SelectedIndex = 0;
      
    } //end setupCombos

    private void storeRoom(){
      //stores the current room to the database
      theDungeon.Rooms[roomNum].Name = txtName.Text;
      theDungeon.Rooms[roomNum].Description = txtDescription.Text;
      theDungeon.Rooms[roomNum].North = cboNorth.SelectedIndex;
      theDungeon.Rooms[roomNum].East = cboEast.SelectedIndex;
      theDungeon.Rooms[roomNum].South = cboSouth.SelectedIndex;
      theDungeon.Rooms[roomNum].West = cboWest.SelectedIndex;
    } // end storeRoom
    
    private void showRoom(){
      //displays a room in editor

      setupCombos();
      txtName.Text = theDungeon.Rooms[roomNum].Name;
      txtDescription.Text = theDungeon.Rooms[roomNum].Description;
      cboNorth.SelectedIndex = theDungeon.Rooms[roomNum].North;
      cboEast.SelectedIndex = theDungeon.Rooms[roomNum].East;
      cboSouth.SelectedIndex = theDungeon.Rooms[roomNum].South;
      cboWest.SelectedIndex = theDungeon.Rooms[roomNum].West;
      lblRoomNum.Text = "room " + Convert.ToString(roomNum);
    } // end showRoom

    private void btnPrev_Click(object sender, System.EventArgs e) {
      storeRoom();
      roomNum--;
      if (roomNum < 0){
        roomNum = 0;
      } // end if
      showRoom();
    } // end btn prev

    private void btnNext_Click(object sender, System.EventArgs e) {
      storeRoom();
      roomNum++;
      if (roomNum >= theDungeon.NumRooms){
        roomNum = theDungeon.NumRooms - 1;
      } // end if
      showRoom();
    } // end btnNext click

    private void mnuSaveAs_Click(object sender, System.EventArgs e) {
      //get the game's name
      theDungeon.Name = txtGameName.Text;
      //store the current room
      storeRoom();
      //write the data out to a binary file
      FileStream s;
      BinaryFormatter bf = new BinaryFormatter();
      if (fileSaver.ShowDialog() != DialogResult.Cancel){
        s = new FileStream(fileSaver.FileName, FileMode.Create);
        bf.Serialize(s, theDungeon);
        s.Close();
      } // end if    
    } // end mnuSave

    private void mnuOpen_Click(object sender, System.EventArgs e) {
      //read the data from a binary file
      FileStream s;
      BinaryFormatter bf = new BinaryFormatter();
      if (fileOpener.ShowDialog() != DialogResult.Cancel){
        s = new FileStream(fileOpener.FileName, FileMode.Open);
        theDungeon = (Dungeon) bf.Deserialize(s);
        roomNum = 1;
        showRoom();
        s.Close();
      } // end if
    } // end mnuOpen
    
    public void OpenGame(Dungeon passedDungeon){
      theDungeon = passedDungeon;
      roomNum = 0;
      showRoom();
      txtGameName.Text = theDungeon.Name;
    } // end Open_game
    
    private void mnuExit_Click(object sender, System.EventArgs e) {
      this.Dispose();
    } // end mnuExit

    private void mnuNewGame_Click(object sender, System.EventArgs e) {
      setupRooms();
      roomNum = 0;
      showRoom();
      txtGameName.Text = "";
    } // end mnuNewGame

    private void mnuPlay_Click(object sender, System.EventArgs e) {
      Game theGame = new Game();
      this.Dispose();
      theGame.Show();
      theGame.OpenGame(theDungeon);
    } // end mnuPlay

	} // end class def
} // end namespace
