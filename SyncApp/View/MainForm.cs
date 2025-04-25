using System;
using System.Windows.Forms;
using SyncApp.Presenter;

namespace SyncApp.View
{
  public partial class MainForm : Form, IMainView
  {
    public MainForm()
    {
      InitializeComponent();
      Presenter = new SyncPresenter(this);
    }

    SyncPresenter Presenter;

    private void buttonSelectDir1_Click(object sender, EventArgs e)
    {
      using (FolderBrowserDialog dialog = new FolderBrowserDialog())
      {
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          textBoxDir1.Text = dialog.SelectedPath;
        }
      }
    }

    private void buttonSelectDir2_Click(object sender, EventArgs e)
    {
      using (FolderBrowserDialog dialog = new FolderBrowserDialog())
      {
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          textBoxDir2.Text = dialog.SelectedPath;
        }
      }
    }

    private void buttonSync_Click(object sender, EventArgs e)
    {
      Presenter.Sync(textBoxDir1.Text, textBoxDir2.Text);
    }

    public void ShowMessage(string message)
    {
      listBoxLog.Items.Add(message);
    }
  }
}