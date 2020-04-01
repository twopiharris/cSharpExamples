using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SpyMaster
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SpyMasterForm : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Button btnViewAgents;
    private System.Windows.Forms.Button btnEditAgents;
    private System.Windows.Forms.Button btnEditOp;
    private System.Windows.Forms.Button btnEditSpec;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SpyMasterForm()
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
      this.btnViewAgents = new System.Windows.Forms.Button();
      this.btnEditAgents = new System.Windows.Forms.Button();
      this.btnEditOp = new System.Windows.Forms.Button();
      this.btnEditSpec = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnViewAgents
      // 
      this.btnViewAgents.Location = new System.Drawing.Point(48, 48);
      this.btnViewAgents.Name = "btnViewAgents";
      this.btnViewAgents.Size = new System.Drawing.Size(240, 32);
      this.btnViewAgents.TabIndex = 0;
      this.btnViewAgents.Text = "view agents";
      this.btnViewAgents.Click += new System.EventHandler(this.btnViewAgents_Click);
      // 
      // btnEditAgents
      // 
      this.btnEditAgents.Location = new System.Drawing.Point(48, 96);
      this.btnEditAgents.Name = "btnEditAgents";
      this.btnEditAgents.Size = new System.Drawing.Size(240, 32);
      this.btnEditAgents.TabIndex = 1;
      this.btnEditAgents.Text = "edit agents";
      this.btnEditAgents.Click += new System.EventHandler(this.btnEditAgents_Click);
      // 
      // btnEditOp
      // 
      this.btnEditOp.Location = new System.Drawing.Point(48, 144);
      this.btnEditOp.Name = "btnEditOp";
      this.btnEditOp.Size = new System.Drawing.Size(240, 32);
      this.btnEditOp.TabIndex = 2;
      this.btnEditOp.Text = "edit assignments";
      this.btnEditOp.Click += new System.EventHandler(this.btnEditOp_Click);
      // 
      // btnEditSpec
      // 
      this.btnEditSpec.Location = new System.Drawing.Point(48, 192);
      this.btnEditSpec.Name = "btnEditSpec";
      this.btnEditSpec.Size = new System.Drawing.Size(240, 32);
      this.btnEditSpec.TabIndex = 3;
      this.btnEditSpec.Text = "edit specialties";
      this.btnEditSpec.Click += new System.EventHandler(this.btnEditSpec_Click);
      // 
      // SpyMasterForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(336, 333);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnEditSpec,
                                                                  this.btnEditOp,
                                                                  this.btnEditAgents,
                                                                  this.btnViewAgents});
      this.Name = "SpyMasterForm";
      this.Text = "The Spy Master";
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SpyMasterForm());
		}

    private void btnViewAgents_Click(object sender, System.EventArgs e) {
      ViewAgents va = new ViewAgents();
      va.Show();
    }

    private void btnEditAgents_Click(object sender, System.EventArgs e) {
      EditAgentData ead = new EditAgentData();
      ead.Show();
    }

    private void btnEditOp_Click(object sender, System.EventArgs e) {
      EditAssignment ea = new EditAssignment();
      ea.Show();
    }

    private void btnEditSpec_Click(object sender, System.EventArgs e) {
      EditSpecialties es = new EditSpecialties();
      es.Show();
    }
	}
}
