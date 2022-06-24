// fucked by otter

using System.IO;
using System.Windows.Forms;

namespace E_Ware
{
  internal class Functions
  {
    public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
    {
      foreach (FileInfo file in new DirectoryInfo(Folder).GetFiles(FileType))
        lsb.Items.Add((object) file.Name);
    }
  }
}
