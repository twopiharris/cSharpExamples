using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace quizzer
{
	/// <summary>
	/// Summary description for frmEdit.
	/// </summary>
	public class frmEdit : System.Windows.Forms.Form
	{
    private System.Windows.Forms.TextBox txtQuestion;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.TextBox txtC;
    private System.Windows.Forms.TextBox txtD;
    private System.Windows.Forms.Button btnPrev;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.RadioButton optA;
    private System.Windows.Forms.RadioButton optB;
    private System.Windows.Forms.RadioButton optC;
    private System.Windows.Forms.RadioButton optD;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.MenuItem menuItem1;
    private System.Windows.Forms.Label lblNum;
    private System.Windows.Forms.MenuItem mnuSaveAs;
    private System.Windows.Forms.SaveFileDialog saver;
    private System.Windows.Forms.OpenFileDialog opener;
    private System.Windows.Forms.MenuItem mnuTest;
    private System.Windows.Forms.MenuItem mnuAddQuestion;
    private System.Windows.Forms.MenuItem mnuNewTest;
    private System.Windows.Forms.MenuItem mnuOpen;

    private XmlDocument doc;
    private XmlNode theTest;
    private int qNum = 0;
    private int numQuestions = 0;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmEdit()
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
      this.txtQuestion = new System.Windows.Forms.TextBox();
      this.txtA = new System.Windows.Forms.TextBox();
      this.txtB = new System.Windows.Forms.TextBox();
      this.txtC = new System.Windows.Forms.TextBox();
      this.txtD = new System.Windows.Forms.TextBox();
      this.btnPrev = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.optA = new System.Windows.Forms.RadioButton();
      this.optB = new System.Windows.Forms.RadioButton();
      this.optC = new System.Windows.Forms.RadioButton();
      this.optD = new System.Windows.Forms.RadioButton();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.menuItem1 = new System.Windows.Forms.MenuItem();
      this.mnuOpen = new System.Windows.Forms.MenuItem();
      this.mnuSaveAs = new System.Windows.Forms.MenuItem();
      this.mnuTest = new System.Windows.Forms.MenuItem();
      this.mnuAddQuestion = new System.Windows.Forms.MenuItem();
      this.mnuNewTest = new System.Windows.Forms.MenuItem();
      this.lblNum = new System.Windows.Forms.Label();
      this.saver = new System.Windows.Forms.SaveFileDialog();
      this.opener = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // txtQuestion
      // 
      this.txtQuestion.Location = new System.Drawing.Point(32, 16);
      this.txtQuestion.Name = "txtQuestion";
      this.txtQuestion.Size = new System.Drawing.Size(392, 20);
      this.txtQuestion.TabIndex = 0;
      this.txtQuestion.Text = "textBox1";
      // 
      // txtA
      // 
      this.txtA.Location = new System.Drawing.Point(32, 72);
      this.txtA.Name = "txtA";
      this.txtA.Size = new System.Drawing.Size(392, 20);
      this.txtA.TabIndex = 2;
      this.txtA.Text = "textBox2";
      // 
      // txtB
      // 
      this.txtB.Location = new System.Drawing.Point(32, 112);
      this.txtB.Name = "txtB";
      this.txtB.Size = new System.Drawing.Size(392, 20);
      this.txtB.TabIndex = 4;
      this.txtB.Text = "textBox3";
      // 
      // txtC
      // 
      this.txtC.Location = new System.Drawing.Point(32, 152);
      this.txtC.Name = "txtC";
      this.txtC.Size = new System.Drawing.Size(392, 20);
      this.txtC.TabIndex = 6;
      this.txtC.Text = "textBox4";
      // 
      // txtD
      // 
      this.txtD.Location = new System.Drawing.Point(32, 192);
      this.txtD.Name = "txtD";
      this.txtD.Size = new System.Drawing.Size(392, 20);
      this.txtD.TabIndex = 8;
      this.txtD.Text = "textBox5";
      // 
      // btnPrev
      // 
      this.btnPrev.Location = new System.Drawing.Point(104, 232);
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(64, 24);
      this.btnPrev.TabIndex = 9;
      this.btnPrev.Text = "prev";
      this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
      // 
      // btnNext
      // 
      this.btnNext.Location = new System.Drawing.Point(296, 232);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(64, 24);
      this.btnNext.TabIndex = 10;
      this.btnNext.Text = "next";
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // optA
      // 
      this.optA.Location = new System.Drawing.Point(16, 72);
      this.optA.Name = "optA";
      this.optA.Size = new System.Drawing.Size(16, 16);
      this.optA.TabIndex = 11;
      this.optA.Tag = "A";
      this.optA.Text = "radioButton1";
      // 
      // optB
      // 
      this.optB.Location = new System.Drawing.Point(16, 112);
      this.optB.Name = "optB";
      this.optB.Size = new System.Drawing.Size(16, 16);
      this.optB.TabIndex = 12;
      this.optB.Tag = "B";
      this.optB.Text = "radioButton2";
      // 
      // optC
      // 
      this.optC.Location = new System.Drawing.Point(16, 152);
      this.optC.Name = "optC";
      this.optC.Size = new System.Drawing.Size(16, 16);
      this.optC.TabIndex = 13;
      this.optC.Tag = "C";
      this.optC.Text = "radioButton3";
      // 
      // optD
      // 
      this.optD.Location = new System.Drawing.Point(16, 192);
      this.optD.Name = "optD";
      this.optD.Size = new System.Drawing.Size(16, 16);
      this.optD.TabIndex = 14;
      this.optD.Tag = "D";
      this.optD.Text = "radioButton4";
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.menuItem1,
                                                                              this.mnuTest});
      // 
      // menuItem1
      // 
      this.menuItem1.Index = 0;
      this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuOpen,
                                                                              this.mnuSaveAs});
      this.menuItem1.Text = "&File";
      // 
      // mnuOpen
      // 
      this.mnuOpen.Index = 0;
      this.mnuOpen.Text = "&Open";
      this.mnuOpen.Click += new System.EventHandler(this.menuOpen_Click);
      // 
      // mnuSaveAs
      // 
      this.mnuSaveAs.Index = 1;
      this.mnuSaveAs.Text = "Save &As...";
      this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
      // 
      // mnuTest
      // 
      this.mnuTest.Index = 1;
      this.mnuTest.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                            this.mnuAddQuestion,
                                                                            this.mnuNewTest});
      this.mnuTest.Text = "&Test";
      // 
      // mnuAddQuestion
      // 
      this.mnuAddQuestion.Index = 0;
      this.mnuAddQuestion.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
      this.mnuAddQuestion.Text = "Add Question";
      this.mnuAddQuestion.Click += new System.EventHandler(this.mnuAddQuestion_Click);
      // 
      // mnuNewTest
      // 
      this.mnuNewTest.Index = 1;
      this.mnuNewTest.Text = "New Test";
      this.mnuNewTest.Click += new System.EventHandler(this.mnuNewTest_Click);
      // 
      // lblNum
      // 
      this.lblNum.Location = new System.Drawing.Point(200, 232);
      this.lblNum.Name = "lblNum";
      this.lblNum.Size = new System.Drawing.Size(56, 24);
      this.lblNum.TabIndex = 15;
      this.lblNum.Text = "label1";
      // 
      // saver
      // 
      this.saver.Filter = "quiz files (*.qml)|*.qml";
      // 
      // opener
      // 
      this.opener.Filter = "quiz files(*.qml)|*.qml";
      // 
      // frmEdit
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(496, 277);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.lblNum,
                                                                  this.optD,
                                                                  this.optC,
                                                                  this.optB,
                                                                  this.optA,
                                                                  this.btnNext,
                                                                  this.btnPrev,
                                                                  this.txtD,
                                                                  this.txtC,
                                                                  this.txtB,
                                                                  this.txtA,
                                                                  this.txtQuestion});
      this.Menu = this.mainMenu1;
      this.Name = "frmEdit";
      this.Text = "frmEdit";
      this.Load += new System.EventHandler(this.frmEdit_Load);
      this.ResumeLayout(false);

    }
		#endregion

    private void frmEdit_Load(object sender, System.EventArgs e) {
      //load up a sample test.
      doc = new XmlDocument();
      doc.Load("sampleTest.qml");    
      
      resetQuiz();

    } // end frmEdit_Load
    
    private void resetQuiz(){
      theTest = doc.ChildNodes[1];
      numQuestions = theTest.ChildNodes.Count;
      qNum = 0;
      showQuestion(0);
    } // end resetQuiz
    
    private void showQuestion(int qNum){
      XmlNode theProblem = theTest.ChildNodes[qNum];
      txtQuestion.Text = theProblem["question"].InnerText;
      txtA.Text = theProblem["answerA"].InnerText;
      txtB.Text = theProblem["answerB"].InnerText;
      txtC.Text = theProblem["answerC"].InnerText;
      txtD.Text = theProblem["answerD"].InnerText;
      lblNum.Text = Convert.ToString(qNum);
      
      //uncheck all the option buttons
      optA.Checked = false;
      optB.Checked = false;
      optC.Checked = false;
      optD.Checked = false;
      
      //Check the appropriate option button
      switch (theProblem["correct"].InnerText){
        case "A":
          optA.Checked = true;
          break;
        case "B":
          optB.Checked = true;
          break;
        case "C":
          optC.Checked = true;
          break;
        case "D":
          optD.Checked = true;
          break;
        default:
          // do nothing
          break;
      } // end switch
    } // end showQuestion
  
   private void updateQuestion(int qNum){
     // updates the current question's XML
     XmlNode theProblem = theTest.ChildNodes[qNum];
     theProblem["question"].InnerText = txtQuestion.Text;
     theProblem["answerA"].InnerText = txtA.Text;
     theProblem["answerB"].InnerText = txtB.Text;
     theProblem["answerC"].InnerText = txtC.Text;
     theProblem["answerD"].InnerText = txtD.Text;
     
     //store the correct answer based on the option buttons
     if (optA.Checked){
       theProblem["correct"].InnerText = "A";
     } else if (optB.Checked){
       theProblem["correct"].InnerText = "B";
     } else if (optC.Checked){
       theProblem["correct"].InnerText = "C";
     } else if (optD.Checked){
       theProblem["correct"].InnerText = "D";
     } else {
       theProblem["correct"].InnerText = "X";
     } // end if  
   } // end updateQuestion

    private void btnNext_Click(object sender, System.EventArgs e) {

      if (noResponse()){
        MessageBox.Show("You must select one of the answers");
      } else {
        updateQuestion(qNum);
        qNum++;
        if (qNum >= numQuestions){
          qNum = numQuestions -1;
          if (MessageBox.Show("Last question. Add new question?", 
              "last question",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes){
            mnuAddQuestion_Click(sender, e);
          } // end 'add question' if
        } else {
          showQuestion(qNum);
        } // end 'last question' if
      } // end 'answer empty' if
    
    }  // end btnNext

    private void btnPrev_Click(object sender, System.EventArgs e) {
      if (noResponse()){
        MessageBox.Show("You must select one of the answers");
      } else {
        updateQuestion(qNum);
        qNum--;
        if (qNum < 0){
          qNum = 0;
          MessageBox.Show("First question");
        } else {
          showQuestion(qNum);
        } // end 'first question' if
      } // end answerEmpty if

    } // end btnPrev

    private bool noResponse(){
      //checks to see if all the check boxes are empty
      bool responseEmpty = true;
      if (optA.Checked){
        responseEmpty = false;
      } // end if
      if (optB.Checked){
        responseEmpty = false;
      } // end if
      if (optC.Checked){
        responseEmpty = false;
      } // end if
      if (optD.Checked){
        responseEmpty = false;
      } // end if
      return responseEmpty;
    }// end noResponse

    private void mnuSaveAs_Click(object sender, System.EventArgs e) {
      if (saver.ShowDialog() != DialogResult.Cancel){
        doc.Save(saver.FileName);
      } // end if
    }

    private void mnuAddQuestion_Click(object sender, System.EventArgs e) {
      numQuestions++;
      qNum = numQuestions -1;

      //create the new Node
      XmlNode newProblem = theTest.ChildNodes[0].Clone();
      theTest.AppendChild(newProblem);

      showQuestion(qNum);
      
      //clear the screen
      txtQuestion.Text = "";
      txtA.Text = "";
      txtB.Text = "";
      txtC.Text = "";
      txtD.Text = "";
      optA.Checked = false;
      optB.Checked = false;
      optC.Checked = false;
      optD.Checked = false;

    } // end mnuSaveAs

    private void menuOpen_Click(object sender, System.EventArgs e) {
      if (opener.ShowDialog() != DialogResult.Cancel){
        doc.Load(opener.FileName);
        theTest = doc.ChildNodes[1];
        resetQuiz();
      } // end if
    } // end mnuOpen

    private void mnuNewTest_Click(object sender, System.EventArgs e) {
      doc = new XmlDocument();
      theTest = doc.CreateNode(XmlNodeType.Element, "test", null);

      //create the first line:
      //<?xml version="1.0" encoding="utf-8"?>

      XmlNode header = doc.CreateXmlDeclaration("1.0", "utf-8", null);      
      
      XmlNode theProblem = doc.CreateElement("problem");
      XmlNode theQuestion = doc.CreateElement("question");
      XmlNode theAnswerA = doc.CreateElement("answerA");
      XmlNode theAnswerB = doc.CreateElement("answerB");
      XmlNode theAnswerC = doc.CreateElement("answerC");
      XmlNode theAnswerD = doc.CreateElement("answerD");
      XmlNode theCorrect = doc.CreateElement("correct");
      
      //construct the new node structure
      doc.AppendChild(header);
      doc.AppendChild(theTest);
      theTest.AppendChild(theProblem);
      theProblem.AppendChild(theQuestion);
      theProblem.AppendChild(theAnswerA);
      theProblem.AppendChild(theAnswerB);
      theProblem.AppendChild(theAnswerC);
      theProblem.AppendChild(theAnswerD);
      theProblem.AppendChild(theCorrect);
      
      //populate values of nodes
      theQuestion.InnerText = "question";
      theAnswerA.InnerText = "a";
      theAnswerB.InnerText = "b";
      theAnswerC.InnerText = "c";
      theAnswerD.InnerText = "d";
      theCorrect.InnerText = "X";
      
      doc.Save("practice.qml");
      
      qNum = 0;
      showQuestion(0);
      
    } // end mnuNewTest
    
	} // end class def
} // end namespace
