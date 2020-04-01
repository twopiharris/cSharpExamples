using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Lander
{
	/// <summary>
	/// Basic Arcade Game
	/// Demonstrates simple animation and keyboard controls
	/// and use of timer.
	/// Andy Harris, 1/16/02
	/// </summary>
	
	public class theForm : System.Windows.Forms.Form
	{
    //my variables	
	private double x, y;      //will show new position of lander
    private double dx, dy;    //difference in x and y
    private int fuel = 100;   //how much fuel is left
    private int ships = 3;    //number of ships player has
    private int score = 0;    //the player's current score

    //created by designer
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.PictureBox picPlatform;
    private System.Windows.Forms.Panel pnlScore;
    private System.Windows.Forms.Label lblDx;
    private System.Windows.Forms.Label lblDy;
    private System.Windows.Forms.Label lblShips;
    private System.Windows.Forms.Label lblFuel;
    private System.Windows.Forms.PictureBox picLander;
    private System.Windows.Forms.ImageList myPics;
    private System.Windows.Forms.Label lblScore;
    private System.ComponentModel.IContainer components;

		public theForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//I added this call, to a method that starts up a round
			initGame();
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
      this.components = new System.ComponentModel.Container();
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(theForm));
      this.lblShips = new System.Windows.Forms.Label();
      this.lblScore = new System.Windows.Forms.Label();
      this.picPlatform = new System.Windows.Forms.PictureBox();
      this.lblDx = new System.Windows.Forms.Label();
      this.lblDy = new System.Windows.Forms.Label();
      this.myPics = new System.Windows.Forms.ImageList(this.components);
      this.lblFuel = new System.Windows.Forms.Label();
      this.picLander = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.pnlScore = new System.Windows.Forms.Panel();
      this.pnlScore.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblShips
      // 
      this.lblShips.ForeColor = System.Drawing.Color.White;
      this.lblShips.Location = new System.Drawing.Point(8, 74);
      this.lblShips.Name = "lblShips";
      this.lblShips.Size = new System.Drawing.Size(104, 16);
      this.lblShips.TabIndex = 2;
      this.lblShips.Text = "label1";
      // 
      // lblScore
      // 
      this.lblScore.ForeColor = System.Drawing.Color.White;
      this.lblScore.Location = new System.Drawing.Point(8, 96);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(104, 16);
      this.lblScore.TabIndex = 4;
      this.lblScore.Text = "label1";
      // 
      // picPlatform
      // 
      this.picPlatform.BackColor = System.Drawing.Color.Blue;
      this.picPlatform.Location = new System.Drawing.Point(240, 304);
      this.picPlatform.Name = "picPlatform";
      this.picPlatform.Size = new System.Drawing.Size(120, 16);
      this.picPlatform.TabIndex = 1;
      this.picPlatform.TabStop = false;
      // 
      // lblDx
      // 
      this.lblDx.ForeColor = System.Drawing.Color.White;
      this.lblDx.Location = new System.Drawing.Point(8, 8);
      this.lblDx.Name = "lblDx";
      this.lblDx.Size = new System.Drawing.Size(104, 16);
      this.lblDx.TabIndex = 0;
      this.lblDx.Text = "label1";
      // 
      // lblDy
      // 
      this.lblDy.ForeColor = System.Drawing.Color.White;
      this.lblDy.Location = new System.Drawing.Point(8, 30);
      this.lblDy.Name = "lblDy";
      this.lblDy.Size = new System.Drawing.Size(104, 16);
      this.lblDy.TabIndex = 1;
      this.lblDy.Text = "label1";
      // 
      // myPics
      // 
      this.myPics.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.myPics.ImageSize = new System.Drawing.Size(256, 256);
      this.myPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myPics.ImageStream")));
      this.myPics.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // lblFuel
      // 
      this.lblFuel.ForeColor = System.Drawing.Color.White;
      this.lblFuel.Location = new System.Drawing.Point(8, 52);
      this.lblFuel.Name = "lblFuel";
      this.lblFuel.Size = new System.Drawing.Size(104, 16);
      this.lblFuel.TabIndex = 3;
      this.lblFuel.Text = "label1";
      // 
      // picLander
      // 
      this.picLander.BackColor = System.Drawing.Color.Black;
      this.picLander.Image = ((System.Drawing.Bitmap)(resources.GetObject("picLander.Image")));
      this.picLander.Location = new System.Drawing.Point(272, 32);
      this.picLander.Name = "picLander";
      this.picLander.Size = new System.Drawing.Size(48, 48);
      this.picLander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picLander.TabIndex = 0;
      this.picLander.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // pnlScore
      // 
      this.pnlScore.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                           this.lblScore,
                                                                           this.lblFuel,
                                                                           this.lblShips,
                                                                           this.lblDy,
                                                                           this.lblDx});
      this.pnlScore.Location = new System.Drawing.Point(40, 8);
      this.pnlScore.Name = "pnlScore";
      this.pnlScore.Size = new System.Drawing.Size(120, 120);
      this.pnlScore.TabIndex = 2;
      // 
      // theForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(760, 517);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.picPlatform,
                                                                  this.picLander,
                                                                  this.pnlScore});
      this.Name = "theForm";
      this.Text = "Lunar Lander";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.theForm_KeyDown);
      this.pnlScore.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new theForm());
		}

    private void timer1_Tick(object sender, System.EventArgs e) {
      //code that should happen on every timer tick (10 times/sec)
    
      //account for gravity
      dy+= .5;
      
      //increment score for being alive
      score += 100;
      
      //show ordinary (no flames) lander
      picLander.Image = myPics.Images[0];
      
      moveShip();
      checkLanding();
      showStats();
    } // end timer tick



    private void theForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
      //executes whenever user presses a key
      
      //spend some fuel
      fuel--;
      
      //check to see if user is out of gas
      if (fuel < 0) {
        timer1.Enabled = false;
        MessageBox.Show("Out of Fuel!!");
        fuel += 20;
        killShip();
        initGame();
      } // end if
      
      //look for arrow keys
      switch (e.KeyData) {
        case Keys.Up:
          picLander.Image = myPics.Images[1];
          dy-= 2;
          break;
        case Keys.Left:
          picLander.Image = myPics.Images[2];
          dx++;
          break;
        case Keys.Right:
          picLander.Image = myPics.Images[3];
          dx--;
          break;
        case Keys.P:
          // temporary for screen shots
          timer1.Enabled = false;
          picLander.Image = myPics.Images[1];
          break;
        default:
          //do nothing
          break;
      } // end switch
    }  // end keyDown
    
    private void moveShip(){
      //change x and check for boundaries
      x += dx;
      if (x > this.Width - picLander.Width){
        x = 0;
      } // end if
      if (x < 0){
        x = Convert.ToDouble(this.Width - picLander.Width);
      } // end if    
      
      //change y and check for boundaries
      y += dy;
      if (y > this.Height - picLander.Height){
        y = 0;
      } // end if
      if (y < 0){
        y = Convert.ToDouble(this.Height - picLander.Height);
      } // end if
      
      //move picLander to new location
      picLander.Location = new Point(Convert.ToInt32(x),Convert.ToInt32(y));
    
    } // end moveShip

    private void checkLanding(){

      //make rectangles from the objects
      Rectangle rLander = picLander.Bounds;
      Rectangle rPlatform = picPlatform.Bounds;
      
      //look for an intersection
      if (rLander.IntersectsWith(rPlatform)){
        //it's a crash or a landing

        //turn off the timer for a moment
        timer1.Enabled = false;
        
        if (Math.Abs(dx) < 1){
          //horizontal speed OK
          if (Math.Abs(dy) < 3){
            //vertical speed OK
            if (Math.Abs(rLander.Bottom - rPlatform.Top) < 3){
              //landing on top of platform
              MessageBox.Show("Good Landing!");
              fuel += 30;
              score += 10000;
            } else {
              MessageBox.Show("You have to land on top.");
              killShip();
            } // end on top if
          } else {
            MessageBox.Show("Too much vertical velocity!");
            killShip();
          } // end vertical if
        } else {
          MessageBox.Show("too much horizontal velocity");
          killShip();
        } // end horiz if
        //reset the lander
        initGame();
      } // end if
    } // end checkLanding
    
    public void showStats(){
      //display the statistics
      lblDx.Text = "dx: " + dx;
      lblDy.Text = "dy: " + dy;
      lblFuel.Text = "fuel: " + fuel;
      lblShips.Text = "ships: " + ships;
      lblScore.Text = "score: " + score;
    } // end showStats

    public void killShip(){
      //kill off a ship, check for end of game
      DialogResult answer;
      ships--;
      if (ships <= 0){
        //game is over
        answer = MessageBox.Show("Play Again?","Game Over",MessageBoxButtons.YesNo);
        if (answer == DialogResult.Yes){
          ships = 3;
          fuel = 100;
          initGame();
        } else {
          Application.Exit();
        } // end if
      } // end 'no ships' if
    } // end killShip  
      
    public void initGame(){
      // re-initializes the game
      Random roller = new Random();
      int platX, platY;
      
      //find random dx, dy values for lander
      dx = Convert.ToDouble(roller.Next(5) - 2);
      dy = Convert.ToDouble(roller.Next(5) - 2);
      
      //place lander randomly on form
      x = Convert.ToDouble(roller.Next(this.Width));
      y = Convert.ToDouble(roller.Next(this.Height));

      //place platform randomly on form (but make sure it appears)
      platX = roller.Next(this.Width - picPlatform.Width);
      platY = roller.Next(this.Height- picPlatform.Height);
      picPlatform.Location = new Point(platX,platY);
      
      //turn on timer
      timer1.Enabled = true;

    } // end initGame
	}  // end class def
} // end namespace
