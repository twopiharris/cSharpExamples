using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SpyMaster
{
	/// <summary>
	/// Summary description for ViewAgents.
	/// </summary>
	public class ViewAgents : System.Windows.Forms.Form
	{
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Windows.Forms.Label lblCodeName;
    private System.Windows.Forms.Label lblAssignment;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblLocation;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ListBox lstSpec;
    private System.Data.SqlClient.SqlConnection spyConnection;
    private System.Data.SqlClient.SqlDataAdapter aaAdapter;
    private SpyMaster.AADataSet theAADataSet;
    private System.Windows.Forms.ComboBox cboAA;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
    private System.Data.SqlClient.SqlDataAdapter asAdapter;
    private SpyMaster.asDataSet theASDataSet;
    private System.Windows.Forms.Label lblAgentID;
    private System.Windows.Forms.Label label5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ViewAgents()
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
      this.spyConnection = new System.Data.SqlClient.SqlConnection();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.aaAdapter = new System.Data.SqlClient.SqlDataAdapter();
      this.lblCodeName = new System.Windows.Forms.Label();
      this.theAADataSet = new SpyMaster.AADataSet();
      this.lblAssignment = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblLocation = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lstSpec = new System.Windows.Forms.ListBox();
      this.cboAA = new System.Windows.Forms.ComboBox();
      this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
      this.asAdapter = new System.Data.SqlClient.SqlDataAdapter();
      this.theASDataSet = new SpyMaster.asDataSet();
      this.lblAgentID = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.theAADataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.theASDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT CodeName, Name, Description, Location FROM Agent_Assignment";
      this.sqlSelectCommand1.Connection = this.spyConnection;
      // 
      // spyConnection
      // 
      this.spyConnection.ConnectionString = "data source=ANDY-MPECR6VC86\\VSTE;initial catalog=spy;integrated security=SSPI;per" +
        "sist security info=True;workstation id=ANDY-MPECR6VC86;packet size=4096";
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = "INSERT INTO Agent_Assignment(CodeName, Name, Description, Location) VALUES (@Code" +
        "Name, @Name, @Description, @Location); SELECT CodeName, Name, Description, Locat" +
        "ion FROM Agent_Assignment";
      this.sqlInsertCommand1.Connection = this.spyConnection;
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CodeName", System.Data.SqlDbType.VarChar, 20, "CodeName"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 20, "Name"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 20, "Location"));
      // 
      // aaAdapter
      // 
      this.aaAdapter.InsertCommand = this.sqlInsertCommand1;
      this.aaAdapter.SelectCommand = this.sqlSelectCommand1;
      this.aaAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                        new System.Data.Common.DataTableMapping("Table", "Agent_Assignment", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("CodeName", "CodeName"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("Name", "Name"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("Description", "Description"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("Location", "Location")})});
      // 
      // lblCodeName
      // 
      this.lblCodeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theAADataSet, "Agent_Assignment.CodeName"));
      this.lblCodeName.Location = new System.Drawing.Point(128, 96);
      this.lblCodeName.Name = "lblCodeName";
      this.lblCodeName.Size = new System.Drawing.Size(240, 16);
      this.lblCodeName.TabIndex = 1;
      this.lblCodeName.Text = "lblCodeName";
      // 
      // theAADataSet
      // 
      this.theAADataSet.DataSetName = "AADataSet";
      this.theAADataSet.Locale = new System.Globalization.CultureInfo("en-US");
      this.theAADataSet.Namespace = "http://www.tempuri.org/AADataSet.xsd";
      // 
      // lblAssignment
      // 
      this.lblAssignment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theAADataSet, "Agent_Assignment.Name"));
      this.lblAssignment.Location = new System.Drawing.Point(128, 136);
      this.lblAssignment.Name = "lblAssignment";
      this.lblAssignment.Size = new System.Drawing.Size(240, 16);
      this.lblAssignment.TabIndex = 2;
      this.lblAssignment.Text = "lblAssignment";
      // 
      // lblDescription
      // 
      this.lblDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theAADataSet, "Agent_Assignment.Description"));
      this.lblDescription.Location = new System.Drawing.Point(128, 176);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(240, 16);
      this.lblDescription.TabIndex = 3;
      this.lblDescription.Text = "lblDescription";
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(16, 96);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(88, 24);
      this.label6.TabIndex = 5;
      this.label6.Text = "Code Name";
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(16, 136);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(88, 24);
      this.label7.TabIndex = 6;
      this.label7.Text = "Assignment";
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(16, 176);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(88, 24);
      this.label8.TabIndex = 7;
      this.label8.Text = "Description";
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(16, 216);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(88, 24);
      this.label9.TabIndex = 8;
      this.label9.Text = "Location";
      // 
      // lblLocation
      // 
      this.lblLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theAADataSet, "Agent_Assignment.Location"));
      this.lblLocation.Location = new System.Drawing.Point(128, 216);
      this.lblLocation.Name = "lblLocation";
      this.lblLocation.Size = new System.Drawing.Size(240, 16);
      this.lblLocation.TabIndex = 9;
      this.lblLocation.Text = "lblLocation";
      // 
      // label11
      // 
      this.label11.Location = new System.Drawing.Point(16, 256);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(80, 16);
      this.label11.TabIndex = 10;
      this.label11.Text = "Specialties";
      // 
      // lstSpec
      // 
      this.lstSpec.Location = new System.Drawing.Point(128, 256);
      this.lstSpec.Name = "lstSpec";
      this.lstSpec.Size = new System.Drawing.Size(224, 69);
      this.lstSpec.TabIndex = 11;
      // 
      // cboAA
      // 
      this.cboAA.DataSource = this.theAADataSet;
      this.cboAA.DisplayMember = "Agent_Assignment.CodeName";
      this.cboAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboAA.Location = new System.Drawing.Point(128, 16);
      this.cboAA.Name = "cboAA";
      this.cboAA.Size = new System.Drawing.Size(240, 21);
      this.cboAA.TabIndex = 12;
      this.cboAA.SelectedIndexChanged += new System.EventHandler(this.cboAA_SelectedIndexChanged);
      // 
      // sqlSelectCommand2
      // 
      this.sqlSelectCommand2.CommandText = "SELECT CodeName, Specialtyname FROM Agent_Spec";
      this.sqlSelectCommand2.Connection = this.spyConnection;
      // 
      // sqlInsertCommand2
      // 
      this.sqlInsertCommand2.CommandText = "INSERT INTO Agent_Spec(CodeName, Specialtyname) VALUES (@CodeName, @Specialtyname" +
        "); SELECT CodeName, Specialtyname FROM Agent_Spec";
      this.sqlInsertCommand2.Connection = this.spyConnection;
      this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CodeName", System.Data.SqlDbType.VarChar, 20, "CodeName"));
      this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Specialtyname", System.Data.SqlDbType.VarChar, 20, "Specialtyname"));
      // 
      // asAdapter
      // 
      this.asAdapter.InsertCommand = this.sqlInsertCommand2;
      this.asAdapter.SelectCommand = this.sqlSelectCommand2;
      this.asAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                        new System.Data.Common.DataTableMapping("Table", "Agent_Spec", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                    new System.Data.Common.DataColumnMapping("CodeName", "CodeName"),
                                                                                                                                                                                                    new System.Data.Common.DataColumnMapping("Specialtyname", "Specialtyname")})});
      // 
      // theASDataSet
      // 
      this.theASDataSet.DataSetName = "asDataSet";
      this.theASDataSet.Locale = new System.Globalization.CultureInfo("en-US");
      this.theASDataSet.Namespace = "http://www.tempuri.org/asDataSet.xsd";
      // 
      // lblAgentID
      // 
      this.lblAgentID.Location = new System.Drawing.Point(128, 56);
      this.lblAgentID.Name = "lblAgentID";
      this.lblAgentID.Size = new System.Drawing.Size(240, 16);
      this.lblAgentID.TabIndex = 0;
      this.lblAgentID.Text = "lblAgentID";
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(16, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(88, 24);
      this.label5.TabIndex = 4;
      this.label5.Text = "AgentID";
      // 
      // ViewAgents
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(448, 341);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.cboAA,
                                                                  this.lstSpec,
                                                                  this.label11,
                                                                  this.lblLocation,
                                                                  this.label9,
                                                                  this.label8,
                                                                  this.label7,
                                                                  this.label6,
                                                                  this.label5,
                                                                  this.lblDescription,
                                                                  this.lblAssignment,
                                                                  this.lblCodeName,
                                                                  this.lblAgentID});
      this.Name = "ViewAgents";
      this.Text = "ViewAgents";
      this.Load += new System.EventHandler(this.ViewAgents_Load);
      ((System.ComponentModel.ISupportInitialize)(this.theAADataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.theASDataSet)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

    private void ViewAgents_Load(object sender, System.EventArgs e) {
      try {
        aaAdapter.Fill(theAADataSet);
      } catch (Exception exc){
        MessageBox.Show(exc.Message);
      } // end try
      showSpecialties();
    }

    private void cboAA_SelectedIndexChanged(object sender, System.EventArgs e) {
      lblAgentID.Text = cboAA.SelectedIndex.ToString();
      showSpecialties();
    }

    private void showSpecialties(){
      //populate the specialties list box
      lstSpec.Items.Clear();

      //reset the agent-specialty query      
      theASDataSet.Agent_Spec.Clear();
      asAdapter.SelectCommand.CommandText = 
        "SELECT Specialtyname FROM Agent_Spec " +
        "WHERE CodeName = '" +
        lblCodeName.Text + "'";
      asAdapter.Fill(theASDataSet);

      //copy each element to list box
      foreach (DataRow myRow in theASDataSet.Agent_Spec.Rows){
        lstSpec.Items.Add(myRow["Specialtyname"]);
      } // end foreach
    } // end showSpecialties

	}
}
