using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace SyncApp.Model
{
  public static class DirectorySync
  {
    public static List<string> CompareAndSync(string dir1, string dir2)
    {
      var messages = new List<string>();
      var files1 = Directory.GetFiles(dir1, "*", SearchOption.AllDirectories);
      var files2 = Directory.GetFiles(dir2, "*", SearchOption.AllDirectories);

      var relative1 = new Dictionary<string, string>();
      var relative2 = new Dictionary<string, string>();

      foreach (var file in files1)
      {
        var relative = file.Substring(dir1.Length).TrimStart(Path.DirectorySeparatorChar);
        relative1[relative] = file;
      }

      foreach (var file in files2)
      {
        var relative = file.Substring(dir2.Length).TrimStart(Path.DirectorySeparatorChar);
        relative2[relative] = file;
      }
      var allKeys = new HashSet<string>(relative1.Keys);
      allKeys.UnionWith(relative2.Keys);

      foreach (var relativePath in allKeys)
      {
        var file1Exists = relative1.ContainsKey(relativePath);
        var file2Exists = relative2.ContainsKey(relativePath);

        if (file1Exists && file2Exists)
        {
          var file1 = relative1[relativePath];
          var file2 = relative2[relativePath];
          var hash1 = File.ReadAllBytes(file1);
          var hash2 = File.ReadAllBytes(file2);

          if (!StructuralComparisons.StructuralEqualityComparer.Equals(hash1, hash2))
          {
            File.Copy(file1, file2, true);
            File.Copy(file2, file1, true);
            messages.Add($"Файл \"{relativePath}\" изменен");
          }
        }
        else if (file1Exists)
        {
          var targetPath = Path.Combine(dir2, relativePath);
          Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
          File.Copy(relative1[relativePath], targetPath);
          File.Copy(targetPath, Path.Combine(dir1, relativePath), true);
          messages.Add($"Файл \"{relativePath}\" создан");
        }
        else if (file2Exists)
        {
          var targetPath = Path.Combine(dir1, relativePath);
          Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
          File.Copy(relative2[relativePath], targetPath);
          File.Copy(targetPath, Path.Combine(dir2, relativePath), true);
          messages.Add($"Файл \"{relativePath}\" создан");
        }
      }

      return messages;
    }
  }
}