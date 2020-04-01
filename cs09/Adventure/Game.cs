using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Adventure
{
	/// <summary>
	/// Adventure Game Engine
	/// Uses Games written in Game Editor
	/// 3/11/02, Andy Harris
	/// </summary>
	public class Game : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblNorth;
    private System.Windows.Forms.Label lblWest;
    private System.Windows.Forms.Label lblEast;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label lblSouth;

    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.MenuItem mnuFile;
    private System.Windows.Forms.MenuItem mnuExit;

    private int currentRoom = 1;
    private System.Windows.Forms.MenuItem mnuEdit;
    public Dungeon theDungeon = new Dungeon();
    
		public Game()
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Game));
      this.lblName = new System.Windows.Forms.Label();
      this.lblNorth = new System.Windows.Forms.Label();
      this.lblWest = new System.Windows.Forms.Label();
      this.lblEast = new System.Windows.Forms.Label();
      this.lblSouth = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.mnuFile = new System.Windows.Forms.MenuItem();
      this.mnuEdit = new System.Windows.Forms.MenuItem();
      this.mnuExit = new System.Windows.Forms.MenuItem();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.BackColor = System.Drawing.Color.SaddleBrown;
      this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.lblName.ForeColor = System.Drawing.Color.White;
      this.lblName.Location = new System.Drawing.Point(88, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(264, 40);
      this.lblName.TabIndex = 5;
      this.lblName.Text = "lblName";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblNorth
      // 
      this.lblNorth.ForeColor = System.Drawing.Color.White;
      this.lblNorth.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblNorth.Image")));
      this.lblNorth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblNorth.Location = new System.Drawing.Point(152, 48);
      this.lblNorth.Name = "lblNorth";
      this.lblNorth.Size = new System.Drawing.Size(152, 40);
      this.lblNorth.TabIndex = 6;
      this.lblNorth.Text = "lblNorth";
      this.lblNorth.Click += new System.EventHandler(this.lblNorth_Click);
      // 
      // lblWest
      // 
      this.lblWest.ForeColor = System.Drawing.Color.White;
      this.lblWest.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblWest.Image")));
      this.lblWest.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.lblWest.Location = new System.Drawing.Point(24, 160);
      this.lblWest.Name = "lblWest";
      this.lblWest.Size = new System.Drawing.Size(56, 80);
      this.lblWest.TabIndex = 7;
      this.lblWest.Text = "lblWest";
      this.lblWest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.lblWest.Click += new System.EventHandler(this.lblWest_Click);
      // 
      // lblEast
      // 
      this.lblEast.ForeColor = System.Drawing.Color.White;
      this.lblEast.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblEast.Image")));
      this.lblEast.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.lblEast.Location = new System.Drawing.Point(352, 160);
      this.lblEast.Name = "lblEast";
      this.lblEast.Size = new System.Drawing.Size(72, 80);
      this.lblEast.TabIndex = 8;
      this.lblEast.Text = "lblEast";
      this.lblEast.Click += new System.EventHandler(this.lblEast_Click);
      // 
      // lblSouth
      // 
      this.lblSouth.ForeColor = System.Drawing.Color.White;
      this.lblSouth.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblSouth.Image")));
      this.lblSouth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblSouth.Location = new System.Drawing.Point(160, 360);
      this.lblSouth.Name = "lblSouth";
      this.lblSouth.Size = new System.Drawing.Size(136, 40);
      this.lblSouth.TabIndex = 9;
      this.lblSouth.Text = "lblSouth";
      this.lblSouth.Click += new System.EventHandler(this.lblSouth_Click);
      // 
      // lblDescription
      // 
      this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.lblDescription.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblDescription.Image")));
      this.lblDescription.Location = new System.Drawing.Point(96, 104);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(240, 256);
      this.lblDescription.TabIndex = 10;
      this.lblDescription.Text = "lblDescription";
      this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
                                                                            this.mnuEdit,
                                                                            this.mnuExit});
      this.mnuFile.Text = "&File";
      // 
      // mnuEdit
      // 
      this.mnuEdit.Index = 0;
      this.mnuEdit.Text = "&edit game";
      this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
      // 
      // mnuExit
      // 
      this.mnuExit.Index = 1;
      this.mnuExit.Text = "e&xit game";
      this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
      // 
      // Game
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.SaddleBrown;
      this.ClientSize = new System.Drawing.Size(448, 450);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.lblDescription,
                                                                  this.lblSouth,
                                                                  this.lblEast,
                                                                  this.lblWest,
                                                                  this.lblNorth,
                                                                  this.lblName});
      this.Menu = this.mainMenu1;
      this.Name = "Game";
      this.Text = "Adventure Game";
      this.Load += new System.EventHandler(this.Game_Load);
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Game());
		}
		
		private void setupRooms(){
      //used to set up a 'default' game.
      //Also used to test before editor was finished
      
      theDungeon.Rooms[0] = new Room(
        "Game Over",
        "You have lost",
        0, 0, 0, 0);
		     
      theDungeon.Rooms[1] = new Room(
        "Start",
        "Go North",
        2, 0, 0, 0);
		     
      theDungeon.Rooms[2] = new Room(
        "Room 2",
        "Go East",
        0, 3, 1, 0);
		     
      theDungeon.Rooms[3] = new Room(
        "Room 3",
        "Go South",
        0, 0, 4, 2);
		     
      theDungeon.Rooms[4] = new Room(
        "You Win!",
        "You have won!",
        3, 0, 0, 0);
      
    } // end setupRooms
		
		private  void showRoom(int roomNum){
		  // show a room on the form
		  
		  int nextRoom;
		  
		  currentRoom = roomNum;
		  lblName.Text = theDungeon.Rooms[roomNum].Name;
		  lblDescription.Text = theDungeon.Rooms[roomNum].Description;

      nextRoom = theDungeon.Rooms[roomNum].North;
      lblNorth.Text = theDungeon.Rooms[nextRoom].Name;

      nextRoom = theDungeon.Rooms[roomNum].East;
      lblEast.Text = theDungeon.Rooms[nextRoom].Name;

      nextRoom = theDungeon.Rooms[roomNum].South;
      lblSouth.Text = theDungeon.Rooms[nextRoom].Name;
  
      nextRoom = theDungeon.Rooms[roomNum].West;
      lblWest.Text = theDungeon.Rooms[nextRoom].Name;

    } // end showRoom

    //label events
    private void lblNorth_Click(object sender, System.EventArgs e) {
      showRoom(theDungeon.Rooms[currentRoom].North);
    }

    private void lblEast_Click(object sender, System.EventArgs e) {
      showRoom(theDungeon.Rooms[currentRoom].East);
    }

    private void lblSouth_Click(object sender, System.EventArgs e) {
      showRoom(theDungeon.Rooms[currentRoom].South);
    }

    private void lblWest_Click(object sender, System.EventArgs e) {
      showRoom(theDungeon.Rooms[currentRoom].West);
    }

    public void OpenGame(string fileName){
      //read the data from a binary file
      FileStream s;
      BinaryFormatter bf = new BinaryFormatter();
      //if (fileOpener.ShowDialog() != DialogResult.Cancel){
      s = new FileStream(fileName, FileMode.Open);
      theDungeon = (Dungeon) bf.Deserialize(s);
      currentRoom = 1;
      showRoom(currentRoom);
      s.Close();
      //} // end if
    
    } // end openGame
    
    public void OpenGame(Dungeon passedDungeon){
      theDungeon = passedDungeon;
      currentRoom = 1;
      showRoom(currentRoom);
    } // end OpenGame
    
    private void mnuExit_Click(object sender, System.EventArgs e) {
      this.Dispose();
    } // end mnuExit

    private void Game_Load(object sender, System.EventArgs e) {
      setupRooms();
      showRoom(1);
      //myEditor = new Editor();
    } // end load

    private void mnuEdit_Click(object sender, System.EventArgs e) {
      this.Dispose();
      Editor theEditor = new Editor();
      theEditor.Show();
      theEditor.OpenGame(theDungeon);
    } // end game_load
   
  } // end class def
} // end namespace
