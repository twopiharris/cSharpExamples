using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SpyMaster
{
	/// <summary>
	/// Summary description for EditSpecialties.
	/// </summary>
	public class EditSpecialties : System.Windows.Forms.Form
	{
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private System.Data.SqlClient.SqlConnection specConnection;
    private System.Data.SqlClient.SqlDataAdapter specAdapter;
    private SpyMaster.spies spyDS;
    private System.Windows.Forms.DataGrid specDG;
    private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EditSpecialties()
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
      this.specConnection = new System.Data.SqlClient.SqlConnection();
      this.specAdapter = new System.Data.SqlClient.SqlDataAdapter();
      this.spyDS = new SpyMaster.spies();
      this.specDG = new System.Windows.Forms.DataGrid();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.spyDS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.specDG)).BeginInit();
      this.SuspendLayout();
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT SpecialtyID, Specialtyname FROM Specialties";
      this.sqlSelectCommand1.Connection = this.specConnection;
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = "INSERT INTO Specialties(SpecialtyID, Specialtyname) VALUES (@SpecialtyID, @Specia" +
        "ltyname); SELECT SpecialtyID, Specialtyname FROM Specialties WHERE (SpecialtyID " +
        "= @SpecialtyID)";
      this.sqlInsertCommand1.Connection = this.specConnection;
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SpecialtyID", System.Data.SqlDbType.Int, 4, "SpecialtyID"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Specialtyname", System.Data.SqlDbType.VarChar, 20, "Specialtyname"));
      // 
      // sqlUpdateCommand1
      // 
      this.sqlUpdateCommand1.CommandText = @"UPDATE Specialties SET SpecialtyID = @SpecialtyID, Specialtyname = @Specialtyname WHERE (SpecialtyID = @Original_SpecialtyID) AND (Specialtyname = @Original_Specialtyname); SELECT SpecialtyID, Specialtyname FROM Specialties WHERE (SpecialtyID = @SpecialtyID)";
      this.sqlUpdateCommand1.Connection = this.specConnection;
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SpecialtyID", System.Data.SqlDbType.Int, 4, "SpecialtyID"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Specialtyname", System.Data.SqlDbType.VarChar, 20, "Specialtyname"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SpecialtyID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Specialtyname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Specialtyname", System.Data.DataRowVersion.Original, null));
      // 
      // sqlDeleteCommand1
      // 
      this.sqlDeleteCommand1.CommandText = "DELETE FROM Specialties WHERE (SpecialtyID = @Original_SpecialtyID) AND (Specialt" +
        "yname = @Original_Specialtyname)";
      this.sqlDeleteCommand1.Connection = this.specConnection;
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SpecialtyID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Specialtyname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Specialtyname", System.Data.DataRowVersion.Original, null));
      // 
      // specConnection
      // 
      this.specConnection.ConnectionString = "data source=ANDY-MPECR6VC86\\VSTE;initial catalog=spy;integrated security=SSPI;per" +
        "sist security info=True;workstation id=ANDY-MPECR6VC86;packet size=4096";
      // 
      // specAdapter
      // 
      this.specAdapter.DeleteCommand = this.sqlDeleteCommand1;
      this.specAdapter.InsertCommand = this.sqlInsertCommand1;
      this.specAdapter.SelectCommand = this.sqlSelectCommand1;
      this.specAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                          new System.Data.Common.DataTableMapping("Table", "Specialties", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                       new System.Data.Common.DataColumnMapping("SpecialtyID", "SpecialtyID"),
                                                                                                                                                                                                       new System.Data.Common.DataColumnMapping("Specialtyname", "Specialtyname")})});
      this.specAdapter.UpdateCommand = this.sqlUpdateCommand1;
      // 
      // spyDS
      // 
      this.spyDS.DataSetName = "spies";
      this.spyDS.Locale = new System.Globalization.CultureInfo("en-US");
      this.spyDS.Namespace = "http://www.tempuri.org/spies.xsd";
      // 
      // specDG
      // 
      this.specDG.DataMember = "Specialties";
      this.specDG.DataSource = this.spyDS;
      this.specDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.specDG.Location = new System.Drawing.Point(16, 24);
      this.specDG.Name = "specDG";
      this.specDG.Size = new System.Drawing.Size(336, 216);
      this.specDG.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(112, 264);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(136, 24);
      this.button1.TabIndex = 1;
      this.button1.Text = "update";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // EditSpecialties
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(376, 317);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.button1,
                                                                  this.specDG});
      this.Name = "EditSpecialties";
      this.Text = "EditSpecialties";
      this.Load += new System.EventHandler(this.EditSpecialties_Load);
      ((System.ComponentModel.ISupportInitialize)(this.spyDS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.specDG)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

    private void button1_Click(object sender, System.EventArgs e) {
      specAdapter.Update(spyDS);
    }

    private void EditSpecialties_Load(object sender, System.EventArgs e) {
      specAdapter.Fill(spyDS);
    }
	}
}
