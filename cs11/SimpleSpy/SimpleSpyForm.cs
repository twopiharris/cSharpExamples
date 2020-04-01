using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SimpleSpy
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SimpleSpyForm : System.Windows.Forms.Form
	{
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private System.Data.SqlClient.SqlConnection myConnection;
    private System.Data.SqlClient.SqlDataAdapter myAdapter;
    private SimpleSpy.theData myDS;
    private System.Windows.Forms.DataGrid spyDG;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SimpleSpyForm()
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
      this.myDS = new SimpleSpy.theData();
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.myConnection = new System.Data.SqlClient.SqlConnection();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
      this.myAdapter = new System.Data.SqlClient.SqlDataAdapter();
      this.spyDG = new System.Windows.Forms.DataGrid();
      ((System.ComponentModel.ISupportInitialize)(this.myDS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spyDG)).BeginInit();
      this.SuspendLayout();
      // 
      // myDS
      // 
      this.myDS.DataSetName = "theData";
      this.myDS.Locale = new System.Globalization.CultureInfo("en-US");
      this.myDS.Namespace = "http://www.tempuri.org/theData.xsd";
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
      // spyDG
      // 
      this.spyDG.DataMember = "Agents";
      this.spyDG.DataSource = this.myDS;
      this.spyDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.spyDG.Location = new System.Drawing.Point(24, 16);
      this.spyDG.Name = "spyDG";
      this.spyDG.Size = new System.Drawing.Size(360, 160);
      this.spyDG.TabIndex = 0;
      // 
      // SimpleSpyForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(400, 317);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.spyDG});
      this.Name = "SimpleSpyForm";
      this.Text = "Simple Spy Database";
      this.Load += new System.EventHandler(this.SimpleSpyForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.myDS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spyDG)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SimpleSpyForm());
		}

    private void SimpleSpyForm_Load(object sender, System.EventArgs e) {
      try {
        myAdapter.Fill(myDS);
      } catch (Exception exc){
        MessageBox.Show("Something broke");
      } // end try
    } // end form load
	}
}
