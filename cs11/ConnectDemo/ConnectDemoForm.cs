using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ConnectDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ConnectDemoForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

    private SqlConnection myConnection = new SqlConnection();
    private SqlDataAdapter myAdapter = new SqlDataAdapter();
    private DataSet myDS = new DataSet();     

    private System.Windows.Forms.DataGrid dgSpy;
    
    public ConnectDemoForm()
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
      this.dgSpy = new System.Windows.Forms.DataGrid();
      ((System.ComponentModel.ISupportInitialize)(this.dgSpy)).BeginInit();
      this.SuspendLayout();
      // 
      // dgSpy
      // 
      this.dgSpy.DataMember = "";
      this.dgSpy.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dgSpy.Location = new System.Drawing.Point(32, 40);
      this.dgSpy.Name = "dgSpy";
      this.dgSpy.Size = new System.Drawing.Size(296, 184);
      this.dgSpy.TabIndex = 0;
      // 
      // ConnectDemoForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(376, 317);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.dgSpy});
      this.Name = "ConnectDemoForm";
      this.Text = "Connection Demo";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgSpy)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ConnectDemoForm());
		}

    private void ConnectDemoForm_Load(object sender, System.EventArgs e) {

      myConnection.ConnectionString = 
        "data source=ANDY-MPECR6VC86\\VSTE;initial catalog=spy;" +
        "integrated security=SSPI;persist security info=True;" +
        "workstation id=ANDY-MPECR6VC86;packet size=4096";

       myAdapter = new SqlDataAdapter("SELECT * FROM Agents", myConnection);
       myDS = new DataSet("agents");
       try {
         myAdapter.Fill(myDS, "agents");
       } catch (Exception exc){
         MessageBox.Show(exc.Message);
       } // end try

       dgSpy.SetDataBinding(myDS, "agents");
    }
	}
}
