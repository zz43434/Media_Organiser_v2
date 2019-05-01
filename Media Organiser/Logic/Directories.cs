using Media_Organiser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Organiser.Logic
{
    public class Directories
    {
        public static void createDirectorys(string[] filePaths, string name)
        {
            DirectoryModel direct = new DirectoryModel();

            direct.DirectoryName = name;
            direct.MediaFiles = new BindingList<MediaFileModel>();

            for (var i = 0; i < filePaths.Length; i++)
            {
                var fn = new FileInfo(filePaths[i]);
                MediaFileModel importFile = new MediaFileModel();
                importFile.Name = fn.Name.ToString();
                importFile.Type = fn.Extension.ToString();
                importFile.Path = fn.Directory.ToString();

                direct.MediaFiles.Add(importFile);
            }
            directories.Add(direct);
            createDirectory(name);
        }

        private static void createDirectory(string directoryName)
        {
            ListViewItem directory = new ListViewItem();

            directory.Group = listViewLibrary.Groups[0];
            directory.Text = directoryName;
            directory.Name = directoryName;
            directory.Selected = true;

            listViewLibrary.Items.Add(directory);
        }
    }
}
