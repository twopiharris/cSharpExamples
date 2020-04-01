using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Access_Xml
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class AccessXmlForm : System.Windows.Forms.Form
	{
    private System.Windows.Forms.DataGrid theDG;
    private System.Data.OleDb.OleDbDataAdapter myOleAdapter;
    private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
    private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
    private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
    private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
    private System.Data.OleDb.OleDbConnection myOleConnection;
    private Access_Xml.theData theData1;
    private Access_Xml.theData myDS;
    private System.Windows.Forms.Button btnXml;
    private System.Windows.Forms.TextBox txtXML;
    private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AccessXmlForm()
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
      this.theDG = new System.Windows.Forms.DataGrid();
      this.myDS = new Access_Xml.theData();
      this.myOleAdapter = new System.Data.OleDb.OleDbDataAdapter();
      this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
      this.myOleConnection = new System.Data.OleDb.OleDbConnection();
      this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
      this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
      this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
      this.btnXml = new System.Windows.Forms.Button();
      this.txtXML = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.theDG)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.myDS)).BeginInit();
      this.SuspendLayout();
      // 
      // theDG
      // 
      this.theDG.DataMember = "Contacts";
      this.theDG.DataSource = this.myDS;
      this.theDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.theDG.Location = new System.Drawing.Point(24, 8);
      this.theDG.Name = "theDG";
      this.theDG.Size = new System.Drawing.Size(344, 152);
      this.theDG.TabIndex = 0;
      // 
      // myDS
      // 
      this.myDS.DataSetName = "theData";
      this.myDS.Locale = new System.Globalization.CultureInfo("en-US");
      this.myDS.Namespace = "http://www.tempuri.org/theData.xsd";
      // 
      // myOleAdapter
      // 
      this.myOleAdapter.DeleteCommand = this.oleDbDeleteCommand1;
      this.myOleAdapter.InsertCommand = this.oleDbInsertCommand1;
      this.myOleAdapter.SelectCommand = this.oleDbSelectCommand1;
      this.myOleAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                           new System.Data.Common.DataTableMapping("Table", "Contacts", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                     new System.Data.Common.DataColumnMapping("Name", "Name"),
                                                                                                                                                                                                     new System.Data.Common.DataColumnMapping("Address", "Address"),
                                                                                                                                                                                                     new System.Data.Common.DataColumnMapping("Phone", "Phone")})});
      this.myOleAdapter.UpdateCommand = this.oleDbUpdateCommand1;
      // 
      // oleDbDeleteCommand1
      // 
      this.oleDbDeleteCommand1.CommandText = "DELETE FROM Contacts WHERE (id = ?) AND (Address = ? OR ? IS NULL AND Address IS " +
        "NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (Phone = ? OR ? IS NULL A" +
        "ND Phone IS NULL)";
      this.oleDbDeleteCommand1.Connection = this.myOleConnection;
      this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
      this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
      this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
      this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
      this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
      // 
      // myOleConnection
      // 
      this.myOleConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\csab\cs11\addBook.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
      // 
      // oleDbInsertCommand1
      // 
      this.oleDbInsertCommand1.CommandText = "INSERT INTO Contacts(Name, Address, Phone) VALUES (?, ?, ?)";
      this.oleDbInsertCommand1.Connection = this.myOleConnection;
      this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
      this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
      this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"));
      // 
      // oleDbSelectCommand1
      // 
      this.oleDbSelectCommand1.CommandText = "SELECT Name, Address, Phone, id FROM Contacts";
      this.oleDbSelectCommand1.Connection = this.myOleConnection;
      // 
      // oleDbUpdateCommand1
      // 
      this.oleDbUpdateCommand1.CommandText = "UPDATE Contacts SET Name = ?, Address = ?, Phone = ?, id = ? WHERE (id = ?) AND (" +
        "Address = ? OR ? IS NULL AND Address IS NULL) AND (Name = ? OR ? IS NULL AND Nam" +
        "e IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)";
      this.oleDbUpdateCommand1.Connection = this.myOleConnection;
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Current, null));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
      this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
      // 
      // btnXml
      // 
      this.btnXml.Location = new System.Drawing.Point(32, 168);
      this.btnXml.Name = "btnXml";
      this.btnXml.Size = new System.Drawing.Size(120, 24);
      this.btnXml.TabIndex = 1;
      this.btnXml.Text = "view as XML";
      this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
      // 
      // txtXML
      // 
      this.txtXML.Location = new System.Drawing.Point(32, 200);
      this.txtXML.Multiline = true;
      this.txtXML.Name = "txtXML";
      this.txtXML.Size = new System.Drawing.Size(328, 128);
      this.txtXML.TabIndex = 2;
      this.txtXML.Text = "txtXML";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(192, 168);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(160, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "load quiz data";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // AccessXmlForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(408, 341);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.button1,
                                                                  this.txtXML,
                                                                  this.btnXml,
                                                                  this.theDG});
      this.Name = "AccessXmlForm";
      this.Text = "Access and XML Demo";
      this.Load += new System.EventHandler(this.AccessXmlForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.theDG)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.myDS)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new AccessXmlForm());
		}

    private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e) {
    
    }

    private void AccessXmlForm_Load(object sender, System.EventArgs e) {
      
      myOleAdapter.Fill(myDS);
    }

    private void btnXml_Click(object sender, System.EventArgs e) {
      txtXML.Text = myDS.GetXml();
    }

    private void button1_Click(object sender, System.EventArgs e) {
      DataSet quizData = new DataSet();
      
      quizData.ReadXml("sampleTest.xml",XmlReadMode.Auto);
      theDG.SetDataBinding(quizData, "problem");
      txtXML.Text = quizData.GetXml();
      
    }
	}
}
