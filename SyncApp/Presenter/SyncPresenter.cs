using System.IO;
using SyncApp.View;
using SyncApp.Model;

namespace SyncApp.Presenter
{
  public class SyncPresenter
  {
    IMainView view;

    public SyncPresenter(IMainView view)
    {
      this.view = view;
    }

    public void Sync(string dir1, string dir2)
    {
      var result = DirectorySync.CompareAndSync(dir1, dir2);

      foreach (var line in result)
      {
        view.ShowMessage(line);
      }
    }
  }
}