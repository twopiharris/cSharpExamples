using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace xmlViewer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class xmlViewerForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblCurName;
    private System.Windows.Forms.Label lblCurValue;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListBox lstChildren;
    private System.Windows.Forms.Button btnNextSib;
    private System.Windows.Forms.Button btnParent;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblInnerXml;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblInnerText;
    private System.Windows.Forms.Button btnRoot;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.OpenFileDialog opener;
    private System.Windows.Forms.Button btnOpen;
    
    private XmlNode theNode;
    private XmlDocument doc;


		public xmlViewerForm()
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
      this.btnNextSib = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblCurName = new System.Windows.Forms.Label();
      this.lblCurValue = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lstChildren = new System.Windows.Forms.ListBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnParent = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.lblInnerXml = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lblInnerText = new System.Windows.Forms.Label();
      this.btnRoot = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnOpen = new System.Windows.Forms.Button();
      this.opener = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // btnNextSib
      // 
      this.btnNextSib.Location = new System.Drawing.Point(192, 400);
      this.btnNextSib.Name = "btnNextSib";
      this.btnNextSib.Size = new System.Drawing.Size(184, 24);
      this.btnNextSib.TabIndex = 1;
      this.btnNextSib.Text = "next sibling";
      this.btnNextSib.Click += new System.EventHandler(this.btnNextSib_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(160, 64);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 24);
      this.label1.TabIndex = 2;
      this.label1.Text = "Current Node";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(144, 104);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 24);
      this.label2.TabIndex = 3;
      this.label2.Text = "Current Value";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblCurName
      // 
      this.lblCurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.lblCurName.Location = new System.Drawing.Point(232, 64);
      this.lblCurName.Name = "lblCurName";
      this.lblCurName.Size = new System.Drawing.Size(192, 24);
      this.lblCurName.TabIndex = 4;
      this.lblCurName.Text = "lblCurName";
      this.lblCurName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblCurValue
      // 
      this.lblCurValue.Location = new System.Drawing.Point(240, 104);
      this.lblCurValue.Name = "lblCurValue";
      this.lblCurValue.Size = new System.Drawing.Size(192, 24);
      this.lblCurValue.TabIndex = 5;
      this.lblCurValue.Text = "lblCurValue";
      this.lblCurValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(24, 328);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 24);
      this.label3.TabIndex = 6;
      this.label3.Text = "children";
      // 
      // lstChildren
      // 
      this.lstChildren.Location = new System.Drawing.Point(96, 304);
      this.lstChildren.Name = "lstChildren";
      this.lstChildren.Size = new System.Drawing.Size(384, 82);
      this.lstChildren.TabIndex = 7;
      this.lstChildren.DoubleClick += new System.EventHandler(this.lstChildren_DoubleClick);
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(144, 24);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(72, 24);
      this.label4.TabIndex = 8;
      this.label4.Text = "parent";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnParent
      // 
      this.btnParent.Location = new System.Drawing.Point(232, 24);
      this.btnParent.Name = "btnParent";
      this.btnParent.Size = new System.Drawing.Size(192, 24);
      this.btnParent.TabIndex = 10;
      this.btnParent.Text = "btnParent";
      this.btnParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.label5.Location = new System.Drawing.Point(104, 144);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 24);
      this.label5.TabIndex = 11;
      this.label5.Text = "Inner XML";
      // 
      // lblInnerXml
      // 
      this.lblInnerXml.Location = new System.Drawing.Point(40, 168);
      this.lblInnerXml.Name = "lblInnerXml";
      this.lblInnerXml.Size = new System.Drawing.Size(208, 112);
      this.lblInnerXml.TabIndex = 12;
      this.lblInnerXml.Text = "lblInnerXml";
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.label6.Location = new System.Drawing.Point(392, 144);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 16);
      this.label6.TabIndex = 13;
      this.label6.Text = "Inner text";
      // 
      // lblInnerText
      // 
      this.lblInnerText.Location = new System.Drawing.Point(328, 168);
      this.lblInnerText.Name = "lblInnerText";
      this.lblInnerText.Size = new System.Drawing.Size(200, 112);
      this.lblInnerText.TabIndex = 14;
      this.lblInnerText.Text = "lblInnerText";
      // 
      // btnRoot
      // 
      this.btnRoot.Location = new System.Drawing.Point(16, 8);
      this.btnRoot.Name = "btnRoot";
      this.btnRoot.Size = new System.Drawing.Size(56, 24);
      this.btnRoot.TabIndex = 15;
      this.btnRoot.Text = "root";
      this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Location = new System.Drawing.Point(16, 136);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(240, 160);
      this.panel1.TabIndex = 16;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2.Location = new System.Drawing.Point(304, 136);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(240, 160);
      this.panel2.TabIndex = 17;
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(496, 16);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(88, 32);
      this.btnOpen.TabIndex = 18;
      this.btnOpen.Text = "open document";
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // opener
      // 
      this.opener.DefaultExt = "*.xml";
      this.opener.Filter = "xml files (*.xml)|*.xml";
      this.opener.InitialDirectory = ".";
      // 
      // xmlViewerForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(592, 437);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnOpen,
                                                                  this.btnRoot,
                                                                  this.lblInnerText,
                                                                  this.label6,
                                                                  this.lblInnerXml,
                                                                  this.label5,
                                                                  this.btnParent,
                                                                  this.label4,
                                                                  this.lstChildren,
                                                                  this.label3,
                                                                  this.lblCurValue,
                                                                  this.lblCurName,
                                                                  this.label2,
                                                                  this.label1,
                                                                  this.btnNextSib,
                                                                  this.panel1,
                                                                  this.panel2});
      this.Name = "xmlViewerForm";
      this.Text = "XMLViewer";
      this.Load += new System.EventHandler(this.xmlReader_Load);
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new xmlViewerForm());
		}

    private void xmlReader_Load(object sender, System.EventArgs e) {
      doc = new XmlDocument();
      doc.Load("c#Test.xml");
      theNode = doc.FirstChild;
      displayNode();
    } // end form load
    
    private void displayNode(){
      XmlNode childNode;

      //handle all the straight text properties
      lblCurName.Text = theNode.Name;
      lblCurValue.Text = theNode.Value;
      lblInnerXml.Text = theNode.InnerXml;
      lblInnerText.Text = theNode.InnerText;

      //handle the parent button
      btnParent.Text = theNode.ParentNode.Name;
      //enable btnParent only when appropriate
      if (theNode.ParentNode.NodeType == XmlNodeType.Element){
        btnParent.Enabled = true;
      } else {
        btnParent.Enabled = false;
      } // end if
      
      //populate the list box with children
      lstChildren.Items.Clear();
      if (theNode.HasChildNodes){
        childNode = theNode.FirstChild;
        while (childNode != null){
          lstChildren.Items.Add(childNode.Name + " - " + childNode.InnerText);
          childNode = childNode.NextSibling;
        } // end while  
      } // end if statement
      
      //enable nextSibling only when appropriate
      if (theNode.NextSibling == null){
        btnNextSib.Enabled = false;
      } else {
        btnNextSib.Enabled = true;
      } // end if
      
    } // end displayNode  

    private void btnNextSib_Click(object sender, System.EventArgs e) {
      theNode = theNode.NextSibling;
      displayNode();
    } // end btnNextSib

    private void btnParent_Click(object sender, System.EventArgs e) {
      theNode = theNode.ParentNode;
      displayNode();
    } // end btnParent

    private void btnRoot_Click(object sender, System.EventArgs e) {
      theNode = doc.FirstChild;
      displayNode();
    } // end btnRoot
 
    private void lstChildren_DoubleClick(object sender, System.EventArgs e) {
      if (lstChildren.Items.Count > 0){
        theNode = theNode.ChildNodes[lstChildren.SelectedIndex];
        displayNode();
      } // end if
    } // end lstChildren

    private void btnOpen_Click(object sender, System.EventArgs e) {
      if (opener.ShowDialog() != DialogResult.Cancel){
        doc.Load(opener.FileName);
        theNode = doc.FirstChild;
      } // end if
    }  // end btnOpen

	}
}
