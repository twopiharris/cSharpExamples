using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerDemo {
  /// <summary>
  /// Summary description for Form1.
  /// </summary>
  public class SerDemo : System.Windows.Forms.Form {
		
    public Contact thePerson = new Contact();
    
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnLoad;
		
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public SerDemo() {
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
    protected override void Dispose( bool disposing ) {
      if( disposing ) {
        if (components != null) {
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
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnLoad = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "name";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(16, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 24);
      this.label2.TabIndex = 1;
      this.label2.Text = "address";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(16, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(88, 24);
      this.label3.TabIndex = 2;
      this.label3.Text = "phone";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(112, 16);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(128, 20);
      this.txtName.TabIndex = 3;
      this.txtName.Text = "";
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(112, 40);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(128, 20);
      this.txtAddress.TabIndex = 4;
      this.txtAddress.Text = "";
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(112, 64);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(128, 20);
      this.txtPhone.TabIndex = 5;
      this.txtPhone.Text = "";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(70, 96);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(72, 24);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "save";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(158, 96);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(64, 24);
      this.btnLoad.TabIndex = 7;
      this.btnLoad.Text = "load";
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // SerDemo
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 141);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btnLoad,
                                                                  this.btnSave,
                                                                  this.txtPhone,
                                                                  this.txtAddress,
                                                                  this.txtName,
                                                                  this.label3,
                                                                  this.label2,
                                                                  this.label1});
      this.Name = "SerDemo";
      this.Text = "Serialization Demo";
      this.ResumeLayout(false);

    }
		#endregion

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.Run(new SerDemo());
    } // end main

    private void btnSave_Click(object sender, System.EventArgs e) {
      thePerson.Name = txtName.Text;
      thePerson.Address = txtAddress.Text;
      thePerson.Phone = txtPhone.Text;
      
      FileStream s;
      s = new FileStream("Contacts.bin", FileMode.Create, FileAccess.Write);
      BinaryFormatter bf = new BinaryFormatter();
      bf.Serialize(s, thePerson);
      s.Close();
    } // end btnSave_Click

    private void btnLoad_Click(object sender, System.EventArgs e) {
      FileStream s;
      s = new FileStream("Contacts.bin", FileMode.Open, FileAccess.Read);
      BinaryFormatter bf = new BinaryFormatter();
      thePerson = (Contact)bf.Deserialize(s);
      s.Close();
      txtName.Text = thePerson.Name;
      txtAddress.Text = thePerson.Address;
      txtPhone.Text = thePerson.Phone;
    } // end btnLoad_Click

  } // end class def
} // end namespace
