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
	/// Summary description for EditAgentData.
	/// </summary>
	public class EditAgentData : System.Windows.Forms.Form
	{
    private System.Windows.Forms.ComboBox cboAgent;
    private System.Windows.Forms.TextBox txtCodeName;
    private System.Windows.Forms.ListBox lstAssign;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label lblLocation;
    private System.Windows.Forms.CheckedListBox clbSpec;
    private System.Windows.Forms.DataGrid dgAgents;
    private System.Windows.Forms.DataGrid dgAssignments;
    private System.Windows.Forms.DataGrid dgSpecialties;
    private System.Windows.Forms.DataGrid dgAgent_Specialty;
    private System.Windows.Forms.DataGrid dgTemp;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private System.Data.SqlClient.SqlConnection spyConnection;
    private System.Data.SqlClient.SqlDataAdapter adAgentSpec;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
    private System.Data.SqlClient.SqlDataAdapter adAgents;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
    private System.Data.SqlClient.SqlDataAdapter adAssignments;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
    private System.Data.SqlClient.SqlDataAdapter adSpecialties;
    private SpyMaster.spyDS dsSpy;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EditAgentData()
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
      this.cboAgent = new System.Windows.Forms.ComboBox();
      this.dsSpy = new SpyMaster.spyDS();
      this.txtCodeName = new System.Windows.Forms.TextBox();
      this.lblDescription = new System.Windows.Forms.Label();
      this.lstAssign = new System.Windows.Forms.ListBox();
      this.lblLocation = new System.Windows.Forms.Label();
      this.clbSpec = new System.Windows.Forms.CheckedListBox();
      this.dgAgents = new System.Windows.Forms.DataGrid();
      this.dgAssignments = new System.Windows.Forms.DataGrid();
      this.dgSpecialties = new System.Windows.Forms.DataGrid();
      this.dgAgent_Specialty = new System.Windows.Forms.DataGrid();
      this.dgTemp = new System.Windows.Forms.DataGrid();
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.spyConnection = new System.Data.SqlClient.SqlConnection();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
      this.adAgentSpec = new System.Data.SqlClient.SqlDataAdapter();
      this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
      this.adAgents = new System.Data.SqlClient.SqlDataAdapter();
      this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
      this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
      this.adAssignments = new System.Data.SqlClient.SqlDataAdapter();
      this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
      this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
      this.adSpecialties = new System.Data.SqlClient.SqlDataAdapter();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dsSpy)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAgents)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAssignments)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgSpecialties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAgent_Specialty)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgTemp)).BeginInit();
      this.SuspendLayout();
      // 
      // cboAgent
      // 
      this.cboAgent.DataSource = this.dsSpy;
      this.cboAgent.DisplayMember = "Agents.CodeName";
      this.cboAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboAgent.Location = new System.Drawing.Point(216, 0);
      this.cboAgent.Name = "cboAgent";
      this.cboAgent.Size = new System.Drawing.Size(232, 21);
      this.cboAgent.TabIndex = 0;
      this.cboAgent.SelectedIndexChanged += new System.EventHandler(this.cboAgent_SelectedIndexChanged);
      // 
      // dsSpy
      // 
      this.dsSpy.DataSetName = "SpyDs";
      this.dsSpy.Locale = new System.Globalization.CultureInfo("en-US");
      this.dsSpy.Namespace = "http://www.tempuri.org/spyDS.xsd";
      // 
      // txtCodeName
      // 
      this.txtCodeName.Location = new System.Drawing.Point(216, 32);
      this.txtCodeName.Name = "txtCodeName";
      this.txtCodeName.Size = new System.Drawing.Size(232, 20);
      this.txtCodeName.TabIndex = 1;
      this.txtCodeName.Text = "";
      // 
      // lblDescription
      // 
      this.lblDescription.Location = new System.Drawing.Point(216, 144);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(232, 24);
      this.lblDescription.TabIndex = 2;
      this.lblDescription.Text = "label1";
      // 
      // lstAssign
      // 
      this.lstAssign.Location = new System.Drawing.Point(216, 64);
      this.lstAssign.Name = "lstAssign";
      this.lstAssign.Size = new System.Drawing.Size(232, 69);
      this.lstAssign.TabIndex = 3;
      this.lstAssign.SelectedIndexChanged += new System.EventHandler(this.lstAssign_SelectedIndexChanged);
      // 
      // lblLocation
      // 
      this.lblLocation.Location = new System.Drawing.Point(216, 176);
      this.lblLocation.Name = "lblLocation";
      this.lblLocation.Size = new System.Drawing.Size(232, 24);
      this.lblLocation.TabIndex = 4;
      this.lblLocation.Text = "label1";
      // 
      // clbSpec
      // 
      this.clbSpec.CheckOnClick = true;
      this.clbSpec.Location = new System.Drawing.Point(216, 200);
      this.clbSpec.Name = "clbSpec";
      this.clbSpec.Size = new System.Drawing.Size(232, 79);
      this.clbSpec.TabIndex = 5;
      // 
      // dgAgents
      // 
      this.dgAgents.DataMember = "Agents";
      this.dgAgents.DataSource = this.dsSpy;
      this.dgAgents.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dgAgents.Location = new System.Drawing.Point(504, 24);
      this.dgAgents.Name = "dgAgents";
      this.dgAgents.Size = new System.Drawing.Size(240, 80);
      this.dgAgents.TabIndex = 6;
      this.dgAgents.Visible = false;
      // 
      // dgAssignments
      // 
      this.dgAssignments.DataMember = "Assignments";
      this.dgAssignments.DataSource = this.dsSpy;
      this.dgAssignments.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dgAssignments.Location = new System.Drawing.Point(504, 120);
      this.dgAssignments.Name = "dgAssignments";
      this.dgAssignments.Size = new System.Drawing.Size(240, 72);
      this.dgAssignments.TabIndex = 7;
      this.dgAssignments.Visible = false;
      // 
      // dgSpecialties
      // 
      this.dgSpecialties.DataMember = "Specialties";
      this.dgSpecialties.DataSource = this.dsSpy;
      this.dgSpecialties.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dgSpecialties.Location = new System.Drawing.Point(504, 208);
      this.dgSpecialties.Name = "dgSpecialties";
      this.dgSpecialties.Size = new System.Drawing.Size(240, 72);
      this.dgSpecialties.TabIndex = 8;
      this.dgSpecialties.Visible = false;
      // 
      // dgAgent_Specialty
      // 
      this.dgAgent_Specialty.DataMember = "Agent_Specialty";
      this.dgAgent_Specialty.DataSource = this.dsSpy;
      this.dgAgent_Specialty.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dgAgent_Specialty.Location = new System.Drawing.Point(504, 296);
      this.dgAgent_Specialty.Name = "dgAgent_Specialty";
      this.dgAgent_Specialty.Size = new System.Drawing.Size(240, 72);
      this.dgAgent_Specialty.TabIndex = 9;
      this.dgAgent_Specialty.Visible = false;
      // 
      // dgTemp
      // 
      this.dgTemp.DataMember = "";
      this.dgTemp.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dgTemp.Location = new System.Drawing.Point(504, 104);
      this.dgTemp.Name = "dgTemp";
      this.dgTemp.Size = new System.Drawing.Size(240, 152);
      this.dgTemp.TabIndex = 10;
      this.dgTemp.Visible = false;
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT Agent_SpecialtyID, AgentID, SpecialtyID FROM Agent_Specialty";
      this.sqlSelectCommand1.Connection = this.spyConnection;
      // 
      // spyConnection
      // 
      this.spyConnection.ConnectionString = "data source=ANDY-MPECR6VC86\\VSTE;initial catalog=spy;integrated security=SSPI;per" +
        "sist security info=True;workstation id=ANDY-MPECR6VC86;packet size=4096";
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = "INSERT INTO Agent_Specialty(Agent_SpecialtyID, AgentID, SpecialtyID) VALUES (@Age" +
        "nt_SpecialtyID, @AgentID, @SpecialtyID); SELECT Agent_SpecialtyID, AgentID, Spec" +
        "ialtyID FROM Agent_Specialty WHERE (Agent_SpecialtyID = @Agent_SpecialtyID)";
      this.sqlInsertCommand1.Connection = this.spyConnection;
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Agent_SpecialtyID", System.Data.SqlDbType.Int, 4, "Agent_SpecialtyID"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AgentID", System.Data.SqlDbType.Int, 4, "AgentID"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SpecialtyID", System.Data.SqlDbType.Int, 4, "SpecialtyID"));
      // 
      // sqlUpdateCommand1
      // 
      this.sqlUpdateCommand1.CommandText = @"UPDATE Agent_Specialty SET Agent_SpecialtyID = @Agent_SpecialtyID, AgentID = @AgentID, SpecialtyID = @SpecialtyID WHERE (Agent_SpecialtyID = @Original_Agent_SpecialtyID) AND (AgentID = @Original_AgentID) AND (SpecialtyID = @Original_SpecialtyID); SELECT Agent_SpecialtyID, AgentID, SpecialtyID FROM Agent_Specialty WHERE (Agent_SpecialtyID = @Agent_SpecialtyID)";
      this.sqlUpdateCommand1.Connection = this.spyConnection;
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Agent_SpecialtyID", System.Data.SqlDbType.Int, 4, "Agent_SpecialtyID"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AgentID", System.Data.SqlDbType.Int, 4, "AgentID"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SpecialtyID", System.Data.SqlDbType.Int, 4, "SpecialtyID"));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Agent_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Agent_SpecialtyID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AgentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AgentID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SpecialtyID", System.Data.DataRowVersion.Original, null));
      // 
      // sqlDeleteCommand1
      // 
      this.sqlDeleteCommand1.CommandText = "DELETE FROM Agent_Specialty WHERE (Agent_SpecialtyID = @Original_Agent_SpecialtyI" +
        "D) AND (AgentID = @Original_AgentID) AND (SpecialtyID = @Original_SpecialtyID)";
      this.sqlDeleteCommand1.Connection = this.spyConnection;
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Agent_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Agent_SpecialtyID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AgentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AgentID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SpecialtyID", System.Data.DataRowVersion.Original, null));
      // 
      // adAgentSpec
      // 
      this.adAgentSpec.DeleteCommand = this.sqlDeleteCommand1;
      this.adAgentSpec.InsertCommand = this.sqlInsertCommand1;
      this.adAgentSpec.SelectCommand = this.sqlSelectCommand1;
      this.adAgentSpec.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                          new System.Data.Common.DataTableMapping("Table", "Agent_Specialty", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                           new System.Data.Common.DataColumnMapping("Agent_SpecialtyID", "Agent_SpecialtyID"),
                                                                                                                                                                                                           new System.Data.Common.DataColumnMapping("AgentID", "AgentID"),
                                                                                                                                                                                                           new System.Data.Common.DataColumnMapping("SpecialtyID", "SpecialtyID")})});
      this.adAgentSpec.UpdateCommand = this.sqlUpdateCommand1;
      // 
      // sqlSelectCommand2
      // 
      this.sqlSelectCommand2.CommandText = "SELECT AgentID, CodeName, AssignmentID FROM Agents";
      this.sqlSelectCommand2.Connection = this.spyConnection;
      // 
      // sqlInsertCommand2
      // 
      this.sqlInsertCommand2.CommandText = "INSERT INTO Agents(AgentID, CodeName, AssignmentID) VALUES (@AgentID, @CodeName, " +
        "@AssignmentID); SELECT AgentID, CodeName, AssignmentID FROM Agents WHERE (AgentI" +
        "D = @AgentID)";
      this.sqlInsertCommand2.Connection = this.spyConnection;
      this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AgentID", System.Data.SqlDbType.Int, 4, "AgentID"));
      this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CodeName", System.Data.SqlDbType.VarChar, 20, "CodeName"));
      this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentID", System.Data.SqlDbType.Int, 4, "AssignmentID"));
      // 
      // sqlUpdateCommand2
      // 
      this.sqlUpdateCommand2.CommandText = @"UPDATE Agents SET AgentID = @AgentID, CodeName = @CodeName, AssignmentID = @AssignmentID WHERE (AgentID = @Original_AgentID) AND (AssignmentID = @Original_AssignmentID OR @Original_AssignmentID IS NULL AND AssignmentID IS NULL) AND (CodeName = @Original_CodeName OR @Original_CodeName IS NULL AND CodeName IS NULL); SELECT AgentID, CodeName, AssignmentID FROM Agents WHERE (AgentID = @AgentID)";
      this.sqlUpdateCommand2.Connection = this.spyConnection;
      this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AgentID", System.Data.SqlDbType.Int, 4, "AgentID"));
      this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CodeName", System.Data.SqlDbType.VarChar, 20, "CodeName"));
      this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentID", System.Data.SqlDbType.Int, 4, "AssignmentID"));
      this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AgentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AgentID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AssignmentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AssignmentID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CodeName", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodeName", System.Data.DataRowVersion.Original, null));
      // 
      // sqlDeleteCommand2
      // 
      this.sqlDeleteCommand2.CommandText = "DELETE FROM Agents WHERE (AgentID = @Original_AgentID) AND (AssignmentID = @Origi" +
        "nal_AssignmentID OR @Original_AssignmentID IS NULL AND AssignmentID IS NULL) AND" +
        " (CodeName = @Original_CodeName OR @Original_CodeName IS NULL AND CodeName IS NU" +
        "LL)";
      this.sqlDeleteCommand2.Connection = this.spyConnection;
      this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AgentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AgentID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AssignmentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AssignmentID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CodeName", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CodeName", System.Data.DataRowVersion.Original, null));
      // 
      // adAgents
      // 
      this.adAgents.DeleteCommand = this.sqlDeleteCommand2;
      this.adAgents.InsertCommand = this.sqlInsertCommand2;
      this.adAgents.SelectCommand = this.sqlSelectCommand2;
      this.adAgents.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                       new System.Data.Common.DataTableMapping("Table", "Agents", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                               new System.Data.Common.DataColumnMapping("AgentID", "AgentID"),
                                                                                                                                                                                               new System.Data.Common.DataColumnMapping("CodeName", "CodeName"),
                                                                                                                                                                                               new System.Data.Common.DataColumnMapping("AssignmentID", "AssignmentID")})});
      this.adAgents.UpdateCommand = this.sqlUpdateCommand2;
      // 
      // sqlSelectCommand3
      // 
      this.sqlSelectCommand3.CommandText = "SELECT AssignmentID, Name, Description, Location FROM Assignments";
      this.sqlSelectCommand3.Connection = this.spyConnection;
      // 
      // sqlInsertCommand3
      // 
      this.sqlInsertCommand3.CommandText = "INSERT INTO Assignments(AssignmentID, Name, Description, Location) VALUES (@Assig" +
        "nmentID, @Name, @Description, @Location); SELECT AssignmentID, Name, Description" +
        ", Location FROM Assignments WHERE (AssignmentID = @AssignmentID)";
      this.sqlInsertCommand3.Connection = this.spyConnection;
      this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentID", System.Data.SqlDbType.Int, 4, "AssignmentID"));
      this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 20, "Name"));
      this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"));
      this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 20, "Location"));
      // 
      // sqlUpdateCommand3
      // 
      this.sqlUpdateCommand3.CommandText = @"UPDATE Assignments SET AssignmentID = @AssignmentID, Name = @Name, Description = @Description, Location = @Location WHERE (AssignmentID = @Original_AssignmentID) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (Location = @Original_Location OR @Original_Location IS NULL AND Location IS NULL) AND (Name = @Original_Name OR @Original_Name IS NULL AND Name IS NULL); SELECT AssignmentID, Name, Description, Location FROM Assignments WHERE (AssignmentID = @AssignmentID)";
      this.sqlUpdateCommand3.Connection = this.spyConnection;
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentID", System.Data.SqlDbType.Int, 4, "AssignmentID"));
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 20, "Name"));
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"));
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 20, "Location"));
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AssignmentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AssignmentID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Location", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      // 
      // sqlDeleteCommand3
      // 
      this.sqlDeleteCommand3.CommandText = @"DELETE FROM Assignments WHERE (AssignmentID = @Original_AssignmentID) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (Location = @Original_Location OR @Original_Location IS NULL AND Location IS NULL) AND (Name = @Original_Name OR @Original_Name IS NULL AND Name IS NULL)";
      this.sqlDeleteCommand3.Connection = this.spyConnection;
      this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AssignmentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AssignmentID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Location", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Location", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
      // 
      // adAssignments
      // 
      this.adAssignments.DeleteCommand = this.sqlDeleteCommand3;
      this.adAssignments.InsertCommand = this.sqlInsertCommand3;
      this.adAssignments.SelectCommand = this.sqlSelectCommand3;
      this.adAssignments.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                            new System.Data.Common.DataTableMapping("Table", "Assignments", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("AssignmentID", "AssignmentID"),
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("Name", "Name"),
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("Description", "Description"),
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("Location", "Location")})});
      this.adAssignments.UpdateCommand = this.sqlUpdateCommand3;
      // 
      // sqlSelectCommand4
      // 
      this.sqlSelectCommand4.CommandText = "SELECT SpecialtyID, Specialtyname FROM Specialties";
      this.sqlSelectCommand4.Connection = this.spyConnection;
      // 
      // sqlInsertCommand4
      // 
      this.sqlInsertCommand4.CommandText = "INSERT INTO Specialties(SpecialtyID, Specialtyname) VALUES (@SpecialtyID, @Specia" +
        "ltyname); SELECT SpecialtyID, Specialtyname FROM Specialties WHERE (SpecialtyID " +
        "= @SpecialtyID)";
      this.sqlInsertCommand4.Connection = this.spyConnection;
      this.sqlInsertCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SpecialtyID", System.Data.SqlDbType.Int, 4, "SpecialtyID"));
      this.sqlInsertCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Specialtyname", System.Data.SqlDbType.VarChar, 20, "Specialtyname"));
      // 
      // sqlUpdateCommand4
      // 
      this.sqlUpdateCommand4.CommandText = @"UPDATE Specialties SET SpecialtyID = @SpecialtyID, Specialtyname = @Specialtyname WHERE (SpecialtyID = @Original_SpecialtyID) AND (Specialtyname = @Original_Specialtyname); SELECT SpecialtyID, Specialtyname FROM Specialties WHERE (SpecialtyID = @SpecialtyID)";
      this.sqlUpdateCommand4.Connection = this.spyConnection;
      this.sqlUpdateCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SpecialtyID", System.Data.SqlDbType.Int, 4, "SpecialtyID"));
      this.sqlUpdateCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Specialtyname", System.Data.SqlDbType.VarChar, 20, "Specialtyname"));
      this.sqlUpdateCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SpecialtyID", System.Data.DataRowVersion.Original, null));
      this.sqlUpdateCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Specialtyname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Specialtyname", System.Data.DataRowVersion.Original, null));
      // 
      // sqlDeleteCommand4
      // 
      this.sqlDeleteCommand4.CommandText = "DELETE FROM Specialties WHERE (SpecialtyID = @Original_SpecialtyID) AND (Specialt" +
        "yname = @Original_Specialtyname)";
      this.sqlDeleteCommand4.Connection = this.spyConnection;
      this.sqlDeleteCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SpecialtyID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SpecialtyID", System.Data.DataRowVersion.Original, null));
      this.sqlDeleteCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Specialtyname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Specialtyname", System.Data.DataRowVersion.Original, null));
      // 
      // adSpecialties
      // 
      this.adSpecialties.DeleteCommand = this.sqlDeleteCommand4;
      this.adSpecialties.InsertCommand = this.sqlInsertCommand4;
      this.adSpecialties.SelectCommand = this.sqlSelectCommand4;
      this.adSpecialties.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                            new System.Data.Common.DataTableMapping("Table", "Specialties", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("SpecialtyID", "SpecialtyID"),
                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("Specialtyname", "Specialtyname")})});
      this.adSpecialties.UpdateCommand = this.sqlUpdateCommand4;
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(152, 296);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(136, 24);
      this.btnUpdate.TabIndex = 11;
      this.btnUpdate.Text = "update";
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(24, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(168, 24);
      this.label1.TabIndex = 12;
      this.label1.Text = "choose agent";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(24, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(168, 24);
      this.label2.TabIndex = 13;
      this.label2.Text = "change agent name";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(24, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(168, 24);
      this.label3.TabIndex = 14;
      this.label3.Text = "choose assignment";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(24, 144);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(168, 24);
      this.label4.TabIndex = 15;
      this.label4.Text = "assignment description";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(24, 176);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(168, 24);
      this.label5.TabIndex = 16;
      this.label5.Text = "assignment location";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(24, 208);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(168, 24);
      this.label6.TabIndex = 17;
      this.label6.Text = "choose specialties";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // EditAgentData
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(536, 381);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.label6,
                                                                  this.label5,
                                                                  this.label4,
                                                                  this.label3,
                                                                  this.label2,
                                                                  this.label1,
                                                                  this.btnUpdate,
                                                                  this.dgTemp,
                                                                  this.dgAgent_Specialty,
                                                                  this.dgSpecialties,
                                                                  this.dgAssignments,
                                                                  this.dgAgents,
                                                                  this.clbSpec,
                                                                  this.lblLocation,
                                                                  this.lstAssign,
                                                                  this.lblDescription,
                                                                  this.txtCodeName,
                                                                  this.cboAgent});
      this.Name = "EditAgentData";
      this.Text = "Edit Agent Data";
      this.Load += new System.EventHandler(this.EditAgentData_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dsSpy)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAgents)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAssignments)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgSpecialties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAgent_Specialty)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgTemp)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

    private void EditAgentData_Load(object sender, System.EventArgs e) {
      //fill all the data adapters
      adAgentSpec.Fill(dsSpy, "Agent_Specialty");
      adAgents.Fill(dsSpy, "Agents");
      adSpecialties.Fill(dsSpy, "Specialties");
      adAssignments.Fill(dsSpy, "Assignments");
      updateForm();
    }
    
    private void updateForm(){
      fillAssignments();
      fillSpecialties();
    } // end updateForm
    
    private void fillAssignments(){
      string query = "";
      int agentID = cboAgent.SelectedIndex;
      DataSet dsTemp = new DataSet();
      DataRow tempRow;
      
      //fill assignments list box
      foreach (DataRow myRow in dsSpy.Assignments.Rows){
        lstAssign.Items.Add(myRow["Name"]);
      } // end foreach 
      
      //select appropriate assignment
      //begin by putting current agent row in dsTemp
      query = "SELECT * from Agents WHERE AgentID = " + agentID;
      adAgents.SelectCommand.CommandText = query;
      dsTemp.Clear();
      adAgents.Fill(dsTemp, "results");
      dgTemp.SetDataBinding(dsTemp, "results");
      //result is one row, grab AssignmentID
      tempRow = dsTemp.Tables["results"].Rows[0];
      int assignID = Convert.ToInt32(tempRow["AssignmentID"]);
      lstAssign.SelectedIndex = assignID;
      
      //fill up the assignment labels, too.
      getAssignInfo(assignID);
      
    } // end fillAssignments
    
    private void fillSpecialties(){
      //fill clbSpec with specialties

      string query = "";
      int agentID = cboAgent.SelectedIndex;
      DataSet dsTemp = new DataSet();
      DataRow tempRow;

      clbSpec.Items.Clear();
      foreach (DataRow myRow in dsSpy.Specialties.Rows){
        clbSpec.Items.Add(myRow["Specialtyname"]);
      } // end foreach     
      
      //find all Agent_Spec rows for current agent
      query = "SELECT * FROM Agent_Specialty WHERE ";
      query += "AgentID = " + agentID;
      
      dsTemp = new DataSet();
      adAgentSpec.SelectCommand.CommandText = query;
      adAgentSpec.Fill(dsTemp, "results");
      dgTemp.SetDataBinding(dsTemp, "results");
      
      //preset all items in clbSpec to unchecked
      for(int i = 0; i < clbSpec.Items.Count; i++){
        clbSpec.SetItemChecked(i, false);
      } // end for loop
      
      //check current spy's skills in clbSpec
      foreach (DataRow myRow in dsTemp.Tables["results"].Rows){
        int specID = Convert.ToInt32(myRow["SpecialtyID"]);
        clbSpec.SetItemChecked(specID, true);
      } // end foreach
      
    } // end fillSpecialties

    private void resetAgents(){
      DataSet dsTemp = new DataSet();
      //DataRow tempRow;
      string query;
      //update the records
      try {
        query = "SELECT * FROM Agents";
        adAgents.SelectCommand.CommandText = query;
        adAgents.Fill(dsSpy, "Agents");
        dgAgents.SetDataBinding(dsSpy, "Agents");
      
        adAgents.Fill(dsTemp, "results");
        dgTemp.SetDataBinding(dsTemp, "results");
      } catch (Exception exc){
        MessageBox.Show(exc.Message);
      } // end try
    }

    private void getAssignInfo(int assignID){
      //use assignID to figure out description, location
      //find only the current spy's assignment
      DataSet dsTemp;
      DataRow tempRow;
      string query;
      
      query = "SELECT * FROM Assignments WHERE AssignmentID = ";
      query += Convert.ToString(assignID);
      adAssignments.SelectCommand.CommandText = query;
      dsTemp = new DataSet();
      adAssignments.Fill(dsTemp, "results");
      dgTemp.SetDataBinding(dsTemp, "results");
      //get a row
      tempRow = dsTemp.Tables["results"].Rows[0];
      lblDescription.Text = tempRow["Description"].ToString();
      lblLocation.Text = tempRow["Location"].ToString();
    } // end getAssignInfo      
    
   
    private void cboAgent_SelectedIndexChanged(object sender, System.EventArgs e) {
      updateForm();
    }

    private void lstAssign_SelectedIndexChanged(object sender, System.EventArgs e) {
      getAssignInfo(lstAssign.SelectedIndex);
    }

    private void btnUpdate_Click(object sender, System.EventArgs e) {
      updateAgent();
      updateSpecialties();
    } // end btnUpdate

    private void updateAgent(){
      //updates the agent table

      DataRow agentRow;
      int agentID = cboAgent.SelectedIndex;
      int assignID = lstAssign.SelectedIndex;
      
      agentRow = dsSpy.Agents.Rows[agentID];

      //Change code name if new name is in text field
      if (txtCodeName.Text != ""){
        agentRow["CodeName"] = txtCodeName.Text;
        txtCodeName.Text = "";
      } // end if

      //change assignment based on lstAssign
      agentRow["AssignmentID"] = assignID;
      
      //update the agent in the main database
      adAgents.Update(dsSpy, "Agents");
      lstAssign.SelectedIndex = assignID;

    } // end updateAgent

    private void updateSpecialties(){
      //find all specialties associated with this agent
      try {
        string query;
        DataSet dsTemp = new DataSet();
        DataRow tempRow;
        int agentID = cboAgent.SelectedIndex;
       
        //find all current rows for this agent
        query = "SELECT * FROM Agent_Specialty ";
        query += "WHERE AgentID = ";
        query += agentID.ToString();
        
        //delete rows from database
        adAgentSpec.SelectCommand.CommandText = query;
        adAgentSpec.Fill(dsSpy, "Agent_Specialty");
        foreach (DataRow myRow in dsSpy.Agent_Specialty.Rows){
          myRow.Delete();
        } // end foreach
        //adAgentSpec.Update(dsSpy, "Agent_Specialty");
  
        //find the largest id
        query = "SELECT MAX(Agent_SpecialtyID) FROM Agent_Specialty";
        adAgentSpec.SelectCommand.CommandText = query;
        dsTemp = new DataSet();
        adAgentSpec.Fill(dsTemp, "results");
        tempRow = dsTemp.Tables["results"].Rows[0];
        int largestID = Convert.ToInt32(tempRow[0]);
        int newID = largestID + 1;
      
        //add rows 
        foreach (int specID in clbSpec.CheckedIndices){
        
          dsSpy.Agent_Specialty.AddAgent_SpecialtyRow(
            newID, agentID, specID);
          newID++;
        } // end foreach
        dsSpy.AcceptChanges();
        adAgentSpec.Update(dsSpy, "Agent_Specialty");
        dgTemp.SetDataBinding(dsSpy, "Agent_Specialty");
      } catch (Exception exc){
        MessageBox.Show(exc.Message);
      } // end try
      
    } // end updateSpecialties();
	} // end class def
} // end namespace
