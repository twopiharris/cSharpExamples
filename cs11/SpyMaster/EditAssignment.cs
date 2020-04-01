using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SpyMaster
{
	/// <summary>
	/// Summary description for EditAssignment.
	/// </summary>
	public class EditAssignment : System.Windows.Forms.Form
	{
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private SpyMaster.spies spyDS;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.DataGrid assignDG;
    private System.Data.SqlClient.SqlConnection AssignConnection;
    private System.Data.SqlClient.SqlDataAdapter AssignAdapter;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EditAssignment()
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
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
      this.AssignConnection = new System.Data.SqlClient.SqlConnection();
      this.AssignAdapter = new System.Data.SqlClient.SqlDataAdapter();
      this.spyDS = new SpyMaster.spies();
      this.assignDG = new System.Windows.Forms.DataGrid();
      this.btnUpdate = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.spyDS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.assignDG)).BeginInit();
      this.SuspendLayout();
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT * FROM Assignments";
      this.sqlSelectCommand1.Connection = this.AssignConnection;
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = "INSERT INTO Assignments(AssignmentID, Name, Description, Location) VALUES (@Assig" +
        "nmentID, @Name, @Description, @Location); SELECT AssignmentID, Name, Description" +
        ", Location FROM Assignments WHERE (AssignmentID = @AssignmentID)";
      this.sqlInsertCommand1.Connection = this.AssignConnection;
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentID", System.Data.SqlDbType.Int, 4, "AssignmentID"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 20, "Name"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 20, "Location"));
      // 
      // sqlUpdateCommand1
      // 
      this.sqlUpdateCommand1.CommandText = @"UPDATE Assignments SET AssignmentID = @AssignmentID, Name = @Name, Description = @Description, Location = @Location WHERE (AssignmentID = @Original_AssignmentID) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (Location = @Original_Location OR @Original_Location IS NULL AND Location IS NULL) AND (Name = @Original_Name OR @Original_Name IS NULL AND Name IS NULL); SELECT AssignmentID, Name, Description, Location FROM Assignments WHERE (AssignmentID = @AssignmentID)";
      this.sqlUpdateCommand1.Connection = this.AssignConnection;
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentID", System.Data.SqlDbType.Int, 4, "AssignmentID"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 20, "Name"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 20, "Location"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AssignmentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AssignmentID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Location", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      // 
      // sqlDeleteCommand1
      // 
      this.sqlDeleteCommand1.CommandText = @"DELETE FROM Assignments WHERE (AssignmentID = @Original_AssignmentID) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (Location = @Original_Location OR @Original_Location IS NULL AND Location IS NULL) AND (Name = @Original_Name OR @Original_Name IS NULL AND Name IS NULL)";
      this.sqlDeleteCommand1.Connection = this.AssignConnection;
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AssignmentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AssignmentID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Location", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      // 
      // AssignConnection
      // 
      this.AssignConnection.ConnectionString = "data source=ANDY-MPECR6VC86\\VSTE;initial catalog=spy;integrated security=SSPI;per" +
        "sist security info=True;workstation id=ANDY-MPECR6VC86;packet size=4096";
      // 
      // AssignAdapter
      // 
      this.AssignAdapter.DeleteCommand = this.sqlDeleteCommand1;
      this.AssignAdapter.InsertCommand = this.sqlInsertCommand1;
      this.AssignAdapter.SelectCommand = this.sqlSelectCommand1;
      this.AssignAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                            new System.Data.Common.DataTableMapping("Table", "Assignments", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("AssignmentID", "AssignmentID"),
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("Name", "Name"),
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("Description", "Description"),
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("Location", "Location")})});
      this.AssignAdapter.UpdateCommand = this.sqlUpdateCommand1;
      // 
      // spyDS
      // 
      this.spyDS.DataSetName = "spies";
      this.spyDS.Locale = new System.Globalization.CultureInfo("en-US");
      this.spyDS.Namespace = "http://www.tempuri.org/spies.xsd";
      // 
      // assignDG
      // 
      this.assignDG.DataMember = "Assignments";
      this.assignDG.DataSource = this.spyDS;
      this.assignDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.assignDG.Location = new System.Drawing.Point(48, 24);
      this.assignDG.Name = "assignDG";
      this.assignDG.Size = new System.Drawing.Size(352, 200);
      this.assignDG.TabIndex = 0;
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(144, 240);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(152, 24);
      this.btnUpdate.TabIndex = 1;
      this.btnUpdate.Text = "update";
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // EditAssignment
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(432, 273);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnUpdate,
                                                                  this.assignDG});
      this.Name = "EditAssignment";
      this.Text = "EditAssignment";
      this.Load += new System.EventHandler(this.EditAssignment_Load);
      ((System.ComponentModel.ISupportInitialize)(this.spyDS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.assignDG)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

    private void EditAssignment_Load(object sender, System.EventArgs e) {
      AssignAdapter.Fill(spyDS);
    }

    private void btnUpdate_Click(object sender, System.EventArgs e) {
      AssignAdapter.Update(spyDS);
    }
	}
}
