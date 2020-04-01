using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QueryDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class QueryDemoForm : System.Windows.Forms.Form
	{
    private System.Windows.Forms.TextBox txtQuery;
    private System.Windows.Forms.Button btnQuery;
    private System.Windows.Forms.DataGrid dgSpies;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private System.Data.SqlClient.SqlConnection myConnection;
    private System.Data.SqlClient.SqlDataAdapter myAdapter;
    private QueryDemo.theData myDS;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public QueryDemoForm()
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
          myConnection.Close();
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
      this.myDS = new QueryDemo.theData();
      this.txtQuery = new System.Windows.Forms.TextBox();
      this.btnQuery = new System.Windows.Forms.Button();
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
      this.dgSpies.Location = new System.Drawing.Point(16, 16);
      this.dgSpies.Name = "dgSpies";
      this.dgSpies.Size = new System.Drawing.Size(368, 160);
      this.dgSpies.TabIndex = 0;
      // 
      // myDS
      // 
      this.myDS.DataSetName = "theData";
      this.myDS.Locale = new System.Globalization.CultureInfo("en-US");
      this.myDS.Namespace = "http://www.tempuri.org/theData.xsd";
      // 
      // txtQuery
      // 
      this.txtQuery.Location = new System.Drawing.Point(16, 192);
      this.txtQuery.Name = "txtQuery";
      this.txtQuery.Size = new System.Drawing.Size(360, 20);
      this.txtQuery.TabIndex = 1;
      this.txtQuery.Text = "SELECT * FROM Agents";
      // 
      // btnQuery
      // 
      this.btnQuery.Location = new System.Drawing.Point(136, 232);
      this.btnQuery.Name = "btnQuery";
      this.btnQuery.Size = new System.Drawing.Size(136, 24);
      this.btnQuery.TabIndex = 2;
      this.btnQuery.Text = "run query";
      this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
      // QueryDemoForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(408, 317);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnQuery,
                                                                  this.txtQuery,
                                                                  this.dgSpies});
      this.Name = "QueryDemoForm";
      this.Text = "Query Demo";
      this.Load += new System.EventHandler(this.QueryDemoForm_Load);
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
			Application.Run(new QueryDemoForm());
		}

    private void QueryDemoForm_Load(object sender, System.EventArgs e) {
      myAdapter.Fill(myDS);
    } // end form load

    private void btnQuery_Click(object sender, System.EventArgs e) {
     
      DataSet qDS = new DataSet("results");
      myAdapter.SelectCommand.CommandText = txtQuery.Text;
      try {
        myAdapter.Fill(qDS, "results");
        dgSpies.SetDataBinding(qDS, "results");
      } catch (Exception exc){
        MessageBox.Show("Something went wrong");
        myAdapter.SelectCommand.CommandText = "Select * from Agents";
        myAdapter.Fill(qDS, "results");
        dgSpies.SetDataBinding(qDS, "results");
      } // end try
    } // end btnQuery
	}
}
