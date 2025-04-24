namespace SyncApp.View
{
  partial class MainForm
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBoxDir1;
    private System.Windows.Forms.TextBox textBoxDir2;
    private System.Windows.Forms.Button buttonSelectDir1;
    private System.Windows.Forms.Button buttonSelectDir2;
    private System.Windows.Forms.Button buttonSync;
    private System.Windows.Forms.ListBox listBoxLog;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.textBoxDir1 = new System.Windows.Forms.TextBox();
      this.textBoxDir2 = new System.Windows.Forms.TextBox();
      this.buttonSelectDir1 = new System.Windows.Forms.Button();
      this.buttonSelectDir2 = new System.Windows.Forms.Button();
      this.buttonSync = new System.Windows.Forms.Button();
      this.listBoxLog = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      this.textBoxDir1.Location = new System.Drawing.Point(12, 12);
      this.textBoxDir1.Size = new System.Drawing.Size(300, 20);
      this.textBoxDir2.Location = new System.Drawing.Point(12, 38);
      this.textBoxDir2.Size = new System.Drawing.Size(300, 20);
      this.buttonSelectDir1.Location = new System.Drawing.Point(320, 10);
      this.buttonSelectDir1.Size = new System.Drawing.Size(100, 23);
      this.buttonSelectDir1.Text = "Выбрать папку 1";
      this.buttonSelectDir1.Click += new System.EventHandler(this.buttonSelectDir1_Click);
      this.buttonSelectDir2.Location = new System.Drawing.Point(320, 36);
      this.buttonSelectDir2.Size = new System.Drawing.Size(100, 23);
      this.buttonSelectDir2.Text = "Выбрать папку 2";
      this.buttonSelectDir2.Click += new System.EventHandler(this.buttonSelectDir2_Click);
      this.buttonSync.Location = new System.Drawing.Point(12, 64);
      this.buttonSync.Size = new System.Drawing.Size(408, 23);
      this.buttonSync.Text = "Синхронизировать";
      this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
      this.listBoxLog.Location = new System.Drawing.Point(12, 93);
      this.listBoxLog.Size = new System.Drawing.Size(408, 200);
      this.ClientSize = new System.Drawing.Size(434, 311);
      this.Controls.Add(this.textBoxDir1);
      this.Controls.Add(this.textBoxDir2);
      this.Controls.Add(this.buttonSelectDir1);
      this.Controls.Add(this.buttonSelectDir2);
      this.Controls.Add(this.buttonSync);
      this.Controls.Add(this.listBoxLog);
      this.Text = "Синхронизация папок";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}