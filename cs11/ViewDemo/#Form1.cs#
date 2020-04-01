using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ViewDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ViewDemoForm : System.Windows.Forms.Form
	{
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlConnection myConnection;
    private System.Data.SqlClient.SqlDataAdapter myAdapter;
    private ViewDemo.theData myDS;
    private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

    //private SqlConnection theConnection = new SqlConnection("server=localhost; uid=sa; pwd= ;database=spy");

		public ViewDemoForm()
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
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.myConnection = new System.Data.SqlClient.SqlConnection();
      this.myAdapter = new System.Data.SqlClient.SqlDataAdapter();
      this.myDS = new ViewDemo.theData();
      this.dataGrid1 = new System.Windows.Forms.DataGrid();
      ((System.ComponentModel.ISupportInitialize)(this.myDS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      this.SuspendLayout();
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT CodeName, Name, Description, Location FROM Agent_Assignment";
      this.sqlSelectCommand1.Connection = this.myConnection;
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = "INSERT INTO Agent_Assignment(CodeName, Name, Description, Location) VALUES (@Code" +
        "Name, @Name, @Description, @Location); SELECT CodeName, Name, Description, Locat" +
        "ion FROM Agent_Assignment";
      this.sqlInsertCommand1.Connection = this.myConnection;
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CodeName", System.Data.SqlDbType.VarChar, 20, "CodeName"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 20, "Name"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"));
      this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 20, "Location"));
      // 
      // myConnection
      // 
      this.myConnection.ConnectionString = "data source=ANDY-MPECR6VC86\\VSTE;initial catalog=spy;integrated security=SSPI;per" +
        "sist security info=True;workstation id=ANDY-MPECR6VC86;packet size=4096";
      // 
      // myAdapter
      // 
      this.myAdapter.InsertCommand = this.sqlInsertCommand1;
      this.myAdapter.SelectCommand = this.sqlSelectCommand1;
      this.myAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                        new System.Data.Common.DataTableMapping("Table", "Agent_Assignment", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("CodeName", "CodeName"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("Name", "Name"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("Description", "Description"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("Location", "Location")})});
      // 
      // myDS
      // 
      this.myDS.DataSetName = "theData";
      this.myDS.Locale = new System.Globalization.CultureInfo("en-US");
      this.myDS.Namespace = "http://www.tempuri.org/theData.xsd";
      // 
      // dataGrid1
      // 
      this.dataGrid1.DataMember = "Agent_Assignment";
      this.dataGrid1.DataSource = this.myDS;
      this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGrid1.Location = new System.Drawing.Point(32, 24);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(344, 152);
      this.dataGrid1.TabIndex = 0;
      // 
      // ViewDemoForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(424, 273);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.dataGrid1});
      this.Name = "ViewDemoForm";
      this.Text = "View Demo";
      this.Load += new System.EventHandler(this.ViewDemoForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.myDS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ViewDemoForm());
		}

    private void ViewDemoForm_Load(object sender, System.EventArgs e) {
      myAdapter.Fill(myDS);
    }
	}
}
