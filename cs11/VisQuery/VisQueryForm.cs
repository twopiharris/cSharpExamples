using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace VisQuery
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class VisQueryForm : System.Windows.Forms.Form
	{
    private string theQuery;

    private System.Windows.Forms.DataGrid dgSpies;
    private System.Windows.Forms.CheckBox chkAgentID;
    private System.Windows.Forms.CheckBox chkCodeName;
    private System.Windows.Forms.CheckBox chkSpecialty;
    private System.Windows.Forms.CheckBox chkAssignment;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lstField;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMatch;
    private System.Windows.Forms.Label lblQuery;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private System.Data.SqlClient.SqlConnection myConnection;
    private System.Data.SqlClient.SqlDataAdapter myAdapter;
    private VisQuery.theData myDS;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public VisQueryForm()
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
      this.dgSpies = new System.Windows.Forms.DataGrid();
      this.myDS = new VisQuery.theData();
      this.chkAgentID = new System.Windows.Forms.CheckBox();
      this.chkCodeName = new System.Windows.Forms.CheckBox();
      this.chkSpecialty = new System.Windows.Forms.CheckBox();
      this.chkAssignment = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lstField = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMatch = new System.Windows.Forms.TextBox();
      this.lblQuery = new System.Windows.Forms.Label();
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.myConnection = new System.Data.SqlClient.SqlConnection();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
      this.myAdapter = new System.Data.SqlClient.SqlDataAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.dgSpies)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.myDS)).BeginInit();
      this.SuspendLayout();
      // 
      // dgSpies
      // 
      this.dgSpies.DataMember = "Agents";
      this.dgSpies.DataSource = this.myDS;
      this.dgSpies.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dgSpies.Location = new System.Drawing.Point(48, 16);
      this.dgSpies.Name = "dgSpies";
      this.dgSpies.Size = new System.Drawing.Size(392, 144);
      this.dgSpies.TabIndex = 0;
      // 
      // myDS
      // 
      this.myDS.DataSetName = "theData";
      this.myDS.Locale = new System.Globalization.CultureInfo("en-US");
      this.myDS.Namespace = "http://www.tempuri.org/theData.xsd";
      // 
      // chkAgentID
      // 
      this.chkAgentID.Location = new System.Drawing.Point(40, 200);
      this.chkAgentID.Name = "chkAgentID";
      this.chkAgentID.Size = new System.Drawing.Size(112, 24);
      this.chkAgentID.TabIndex = 1;
      this.chkAgentID.Text = "AgentID";
      this.chkAgentID.CheckedChanged += new System.EventHandler(this.buildQuery);
      // 
      // chkCodeName
      // 
      this.chkCodeName.Location = new System.Drawing.Point(40, 224);
      this.chkCodeName.Name = "chkCodeName";
      this.chkCodeName.Size = new System.Drawing.Size(112, 24);
      this.chkCodeName.TabIndex = 2;
      this.chkCodeName.Text = "CodeName";
      this.chkCodeName.CheckedChanged += new System.EventHandler(this.buildQuery);
      // 
      // chkSpecialty
      // 
      this.chkSpecialty.Location = new System.Drawing.Point(40, 248);
      this.chkSpecialty.Name = "chkSpecialty";
      this.chkSpecialty.Size = new System.Drawing.Size(112, 24);
      this.chkSpecialty.TabIndex = 3;
      this.chkSpecialty.Text = "Specialty";
      this.chkSpecialty.CheckedChanged += new System.EventHandler(this.buildQuery);
      // 
      // chkAssignment
      // 
      this.chkAssignment.Location = new System.Drawing.Point(40, 272);
      this.chkAssignment.Name = "chkAssignment";
      this.chkAssignment.Size = new System.Drawing.Size(112, 32);
      this.chkAssignment.TabIndex = 4;
      this.chkAssignment.Text = "Assignment";
      this.chkAssignment.CheckedChanged += new System.EventHandler(this.buildQuery);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.label1.Location = new System.Drawing.Point(32, 168);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 32);
      this.label1.TabIndex = 5;
      this.label1.Text = "SELECT";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.label2.Location = new System.Drawing.Point(208, 168);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 32);
      this.label2.TabIndex = 6;
      this.label2.Text = "WHERE";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lstField
      // 
      this.lstField.Items.AddRange(new object[] {
                                                  "<ALL>",
                                                  "AgentID",
                                                  "CodeName",
                                                  "Specialty",
                                                  "Assignment"});
      this.lstField.Location = new System.Drawing.Point(200, 216);
      this.lstField.Name = "lstField";
      this.lstField.Size = new System.Drawing.Size(72, 69);
      this.lstField.TabIndex = 7;
      this.lstField.SelectedIndexChanged += new System.EventHandler(this.buildQuery);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.label3.Location = new System.Drawing.Point(280, 232);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 32);
      this.label3.TabIndex = 8;
      this.label3.Text = "=";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtMatch
      // 
      this.txtMatch.Location = new System.Drawing.Point(328, 240);
      this.txtMatch.Name = "txtMatch";
      this.txtMatch.Size = new System.Drawing.Size(136, 20);
      this.txtMatch.TabIndex = 9;
      this.txtMatch.Text = "";
      this.txtMatch.TextChanged += new System.EventHandler(this.buildQuery);
      // 
      // lblQuery
      // 
      this.lblQuery.Location = new System.Drawing.Point(24, 328);
      this.lblQuery.Name = "lblQuery";
      this.lblQuery.Size = new System.Drawing.Size(424, 40);
      this.lblQuery.TabIndex = 10;
      this.lblQuery.Text = "SELECT * FROM Agents";
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT AgentID, CodeName, Specialty, Assignment FROM Agents";
      this.sqlSelectCommand1.Connection = this.myConnection;
      // 
      // myConnection
      // 
      this.myConnection.ConnectionString = "data source=ANDY-MPECR6VC86\\VSTE;initial catalog=simpleSpy;integrated security=SS" +
        "PI;persist security info=False;workstation id=ANDY-MPECR6VC86;packet size=4096";
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = "INSERT INTO Agents(AgentID, CodeName, Specialty, Assignment) VALUES (@AgentID, @C" +
        "odeName, @Specialty, @Assignment); SELECT AgentID, CodeName, Specialty, Assignme" +
        "nt FROM Agents WHERE (AgentID = @AgentID)";
      this.sqlInsertCommand1.Connection = this.myConnection;
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AgentID", System.Data.SqlDbType.Int, 4, "AgentID"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CodeName", System.Data.SqlDbType.VarChar, 20, "CodeName"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Specialty", System.Data.SqlDbType.VarChar, 20, "Specialty"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Assignment", System.Data.SqlDbType.VarChar, 20, "Assignment"));
      // 
      // sqlUpdateCommand1
      // 
      this.sqlUpdateCommand1.CommandText = @"UPDATE Agents SET AgentID = @AgentID, CodeName = @CodeName, Specialty = @Specialty, Assignment = @Assignment WHERE (AgentID = @Original_AgentID) AND (Assignment = @Original_Assignment OR @Original_Assignment IS NULL AND Assignment IS NULL) AND (CodeName = @Original_CodeName OR @Original_CodeName IS NULL AND CodeName IS NULL) AND (Specialty = @Original_Specialty OR @Original_Specialty IS NULL AND Specialty IS NULL); SELECT AgentID, CodeName, Specialty, Assignment FROM Agents WHERE (AgentID = @AgentID)";
      this.sqlUpdateCommand1.Connection = this.myConnection;
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AgentID", System.Data.SqlDbType.Int, 4, "AgentID"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CodeName", System.Data.SqlDbType.VarChar, 20, "CodeName"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Specialty", System.Data.SqlDbType.VarChar, 20, "Specialty"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Assignment", System.Data.SqlDbType.VarChar, 20, "Assignment"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AgentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AgentID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Assignment", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Assignment", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CodeName", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodeName", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Specialty", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Specialty", System.Data.DataRowVersion.Original, null));
      // 
      // sqlDeleteCommand1
      // 
      this.sqlDeleteCommand1.CommandText = @"DELETE FROM Agents WHERE (AgentID = @Original_AgentID) AND (Assignment = @Original_Assignment OR @Original_Assignment IS NULL AND Assignment IS NULL) AND (CodeName = @Original_CodeName OR @Original_CodeName IS NULL AND CodeName IS NULL) AND (Specialty = @Original_Specialty OR @Original_Specialty IS NULL AND Specialty IS NULL)";
      this.sqlDeleteCommand1.Connection = this.myConnection;
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AgentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AgentID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Assignment", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Assignment", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CodeName", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodeName", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Specialty", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Specialty", System.Data.DataRowVersion.Original, null));
      // 
      // myAdapter
      // 
      this.myAdapter.DeleteCommand = this.sqlDeleteCommand1;
      this.myAdapter.InsertCommand = this.sqlInsertCommand1;
      this.myAdapter.SelectCommand = this.sqlSelectCommand1;
      this.myAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                        new System.Data.Common.DataTableMapping("Table", "Agents", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("AgentID", "AgentID"),
                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("CodeName", "CodeName"),
                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Specialty", "Specialty"),
                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Assignment", "Assignment")})});
      this.myAdapter.UpdateCommand = this.sqlUpdateCommand1;
      // 
      // VisQueryForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(488, 381);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.lblQuery,
                                                                  this.txtMatch,
                                                                  this.label3,
                                                                  this.lstField,
                                                                  this.label2,
                                                                  this.label1,
                                                                  this.chkAssignment,
                                                                  this.chkSpecialty,
                                                                  this.chkCodeName,
                                                                  this.chkAgentID,
                                                                  this.dgSpies});
      this.Name = "VisQueryForm";
      this.Text = "Visual Query Example";
      this.Load += new System.EventHandler(this.VisQueryForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgSpies)).EndInit();
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
			Application.Run(new VisQueryForm());
		}

    private void VisQueryForm_Load(object sender, System.EventArgs e) {
      myAdapter.Fill(myDS, "Agents");
      lstField.SelectedIndex = 0;
    } // end form load
   
    private void buildQuery(object sender, System.EventArgs e) {
      getSelect();
      getWhere();
      lblQuery.Text = theQuery;
      runQuery();
    } // end buildQuery
   
    private void getSelect(){
      //create the SELECT part of the query from check boxes
      theQuery = "SELECT ";
      bool none = true;
      
      if (chkAgentID.Checked){
        theQuery += "AgentID, ";
        none = false;
      }  // end if
      if (chkCodeName.Checked){
        theQuery += "CodeName, ";
        none = false;
      } // end if
      if (chkSpecialty.Checked){
        theQuery += "Specialty, ";
        none = false;
      } // end if
      if (chkAssignment.Checked){
        theQuery += "Assignment, ";
        none = false;
      } // end if
      if (none){
        theQuery += "*, ";
      } // end if
      
      //remove the last comma
      theQuery = theQuery.Substring(0, theQuery.Length -2);

      theQuery += " FROM Agents";

    } // end getSelect


   private void getWhere(){
      //Create WHERE clause of query from list box
      if (lstField.SelectedIndex != 0){
        theQuery += " WHERE ";
        theQuery += lstField.Text;
        if (lstField.Text != "AgentID"){
          theQuery += " = '";
          theQuery += txtMatch.Text;
          theQuery += "'";
        } else {
          theQuery += " = ";
          try {
            int temp = Convert.ToInt32(txtMatch.Text);
            theQuery += Convert.ToString(temp);
          } catch (Exception exc) {
            theQuery += "0";
          } // end try            

        } // end agentID if
      } // end something selected if

    } // end getWhere

    private void runQuery(){
      //runs the current query
      DataSet qDS = new DataSet("results");
      myAdapter.SelectCommand.CommandText = lblQuery.Text;
      myAdapter.Fill(qDS, "results");
      dgSpies.SetDataBinding(qDS, "results");
    }

    private void btnExecute_Click(object sender, System.EventArgs e) {
      runQuery();
    } // end runQuery
	}
}
