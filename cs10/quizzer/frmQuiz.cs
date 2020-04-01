using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace quizzer
{
	/// <summary>
	/// Summary description for frmQuiz.
	/// </summary>
	public class frmQuiz : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Label lblQuestion;
    private System.Windows.Forms.RadioButton optA;
    private System.Windows.Forms.RadioButton optB;
    private System.Windows.Forms.RadioButton optC;
    private System.Windows.Forms.RadioButton optD;
    private System.Windows.Forms.Label lblNum;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.MenuItem mnuFile;
    private System.Windows.Forms.MenuItem menuItem3;
    private System.Windows.Forms.MenuItem mnuGradeQuiz;
    private System.Windows.Forms.OpenFileDialog opener;
    private System.Windows.Forms.MenuItem mnuOpen;
    private System.Windows.Forms.Button btnPrev;
    private System.Windows.Forms.Button btnNext;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
 
    private XmlDocument doc;
    private XmlNode theTest;
    private int qNum = 0;
    private int numQuestions = 0;
    private string[] response;
    
		public frmQuiz()
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
      this.lblQuestion = new System.Windows.Forms.Label();
      this.optA = new System.Windows.Forms.RadioButton();
      this.optB = new System.Windows.Forms.RadioButton();
      this.optC = new System.Windows.Forms.RadioButton();
      this.optD = new System.Windows.Forms.RadioButton();
      this.btnPrev = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.lblNum = new System.Windows.Forms.Label();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.mnuFile = new System.Windows.Forms.MenuItem();
      this.mnuOpen = new System.Windows.Forms.MenuItem();
      this.menuItem3 = new System.Windows.Forms.MenuItem();
      this.mnuGradeQuiz = new System.Windows.Forms.MenuItem();
      this.opener = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // lblQuestion
      // 
      this.lblQuestion.Location = new System.Drawing.Point(40, 8);
      this.lblQuestion.Name = "lblQuestion";
      this.lblQuestion.Size = new System.Drawing.Size(384, 40);
      this.lblQuestion.TabIndex = 0;
      this.lblQuestion.Text = "lblQuestion";
      // 
      // optA
      // 
      this.optA.Location = new System.Drawing.Point(56, 64);
      this.optA.Name = "optA";
      this.optA.Size = new System.Drawing.Size(376, 16);
      this.optA.TabIndex = 1;
      this.optA.Text = "optA";
      // 
      // optB
      // 
      this.optB.Location = new System.Drawing.Point(56, 104);
      this.optB.Name = "optB";
      this.optB.Size = new System.Drawing.Size(376, 16);
      this.optB.TabIndex = 2;
      this.optB.Text = "optB";
      // 
      // optC
      // 
      this.optC.Location = new System.Drawing.Point(56, 144);
      this.optC.Name = "optC";
      this.optC.Size = new System.Drawing.Size(376, 16);
      this.optC.TabIndex = 3;
      this.optC.Text = "optC";
      // 
      // optD
      // 
      this.optD.Location = new System.Drawing.Point(56, 184);
      this.optD.Name = "optD";
      this.optD.Size = new System.Drawing.Size(376, 16);
      this.optD.TabIndex = 4;
      this.optD.Text = "optD";
      // 
      // btnPrev
      // 
      this.btnPrev.Location = new System.Drawing.Point(136, 216);
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(80, 24);
      this.btnPrev.TabIndex = 5;
      this.btnPrev.Text = "prev";
      this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
      // 
      // btnNext
      // 
      this.btnNext.Location = new System.Drawing.Point(320, 216);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(72, 24);
      this.btnNext.TabIndex = 6;
      this.btnNext.Text = "next";
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // lblNum
      // 
      this.lblNum.Location = new System.Drawing.Point(248, 224);
      this.lblNum.Name = "lblNum";
      this.lblNum.Size = new System.Drawing.Size(32, 24);
      this.lblNum.TabIndex = 7;
      this.lblNum.Text = "lblNum";
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
                                                                            this.mnuOpen,
                                                                            this.menuItem3,
                                                                            this.mnuGradeQuiz});
      this.mnuFile.Text = "&File";
      // 
      // mnuOpen
      // 
      this.mnuOpen.Index = 0;
      this.mnuOpen.Text = "&Open Quiz";
      this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
      // 
      // menuItem3
      // 
      this.menuItem3.Index = 1;
      this.menuItem3.Text = "E&xit Quiz";
      this.menuItem3.Click += new System.EventHandler(this.mnuExit_Click);
      // 
      // mnuGradeQuiz
      // 
      this.mnuGradeQuiz.Index = 2;
      this.mnuGradeQuiz.Text = "Grade Quiz";
      this.mnuGradeQuiz.Click += new System.EventHandler(this.mnuGradeQuiz_Click);
      // 
      // opener
      // 
      this.opener.DefaultExt = "qml";
      this.opener.Filter = "quiz files (*.qml)|*.qml";
      // 
      // frmQuiz
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(504, 277);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.lblNum,
                                                                  this.btnNext,
                                                                  this.btnPrev,
                                                                  this.optD,
                                                                  this.optC,
                                                                  this.optB,
                                                                  this.optA,
                                                                  this.lblQuestion});
      this.Menu = this.mainMenu1;
      this.Name = "frmQuiz";
      this.Text = "frmQuiz";
      this.Load += new System.EventHandler(this.frmQuiz_Load);
      this.ResumeLayout(false);

    }
		#endregion

    private void frmQuiz_Load(object sender, System.EventArgs e) {
      doc = new XmlDocument();
      doc.Load("sampleTest.qml");    
      resetQuiz();
    } // end Load

    private void mnuOpen_Click(object sender, System.EventArgs e) {
      if (opener.ShowDialog() != DialogResult.Cancel){
        doc.Load(opener.FileName);
        resetQuiz();
      } // end if
    } // end mnuOpen
    
    private void resetQuiz(){
      theTest = doc.ChildNodes[1];
      numQuestions = theTest.ChildNodes.Count;
      response = new String[numQuestions];
      for (int i = 0; i < numQuestions; i++){
        response[i] = "X";
      } // end for loop
      qNum = 0;
      showQuestion(0);
    } // end resetQuiz    

    private void btnNext_Click(object sender, System.EventArgs e) {
      getResponse();
      qNum++;
      if (qNum >= numQuestions){
        qNum = theTest.ChildNodes.Count -1;
        if (MessageBox.Show("Last Question. Grade Quiz?", 
            "Last Question",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes){
          gradeTest();
        } // end if
      } else {
        showQuestion(qNum);
      } // end if 

    } // end btnNext

    private void btnPrev_Click(object sender, System.EventArgs e) {
      getResponse();
      qNum--;
      if (qNum < 0){
        MessageBox.Show("First Question");
        qNum = 0;
      } else {
        showQuestion(qNum);
      } // end if    
    } // end btnPrev

    private void getResponse(){
      //queries the buttons for user input, copies to response array
      if (optA.Checked){
        response[qNum] = "A";
      } else if (optB.Checked){
        response[qNum] = "B";
      } else if (optC.Checked){
        response[qNum] = "C";
      } else if (optD.Checked){
        response[qNum] = "D";
      } else {
        response[qNum] = "X";
      } // end if
    } // end get response

    private void showQuestion(int qNum){
      theTest = doc.ChildNodes[1];
      XmlNode theProblem = theTest.ChildNodes[qNum];
      lblQuestion.Text = theProblem["question"].InnerText;
      optA.Text = theProblem["answerA"].InnerText;
      optB.Text = theProblem["answerB"].InnerText;
      optC.Text = theProblem["answerC"].InnerText;
      optD.Text = theProblem["answerD"].InnerText;

      lblNum.Text = Convert.ToString(qNum);
      
      //clear up the checkBoxes
      optA.Checked = false;
      optB.Checked = false;
      optC.Checked = false;
      optD.Checked = false;
      
      //indicate response if there is one
      if (response[qNum] == "A"){
        optA.Checked = true;
      } else if (response[qNum] == "B"){
        optB.Checked = true;
      } else if (response[qNum] == "C"){
        optC.Checked = true;
      } else if (response[qNum] == "D"){
        optD.Checked = true;
      } else {
        //MessageBox.Show("There's a problem!");
      } // end if
        
    } // end showQuestion

    private void gradeTest(){
      int score = 0;
      //int perc = 0;
      for (int i = 0; i < numQuestions; i++){
        XmlNode theProblem = theTest.ChildNodes[i];
        string correct = theProblem["correct"].InnerText;
        if (response[i] == correct){
          score ++;
        } // end if
      } // end for loop
      MessageBox.Show("Score: " + score + " of " + numQuestions);
    } // end gradeTest

    private void mnuExit_Click(object sender, System.EventArgs e) {
      this.Close();
    } // end mnuExit

    private void mnuGradeQuiz_Click(object sender, System.EventArgs e) {
      gradeTest();
    } // end gradeTest
	}
}
