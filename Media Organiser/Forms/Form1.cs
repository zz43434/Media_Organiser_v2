using Media_Organiser.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<DirectoryModel> directories = new List<DirectoryModel>();
        string[] filePaths;
        List<PlaylistModel> playlists = new List<PlaylistModel>();
        List<CategoryModel> categories = new List<CategoryModel>();

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                Environment.SpecialFolder root = folderBrowser.RootFolder;
                filePaths = Directory.GetFiles(folderBrowser.SelectedPath, "*.pdf", SearchOption.AllDirectories);

                DirectoryModel direct = new DirectoryModel();

                direct.DirectoryName = folderBrowser.SelectedPath;
                direct.MediaFiles = new List<MediaFileModel>();

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
                createDirectory(folderBrowser.SelectedPath);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                fileInfoNameSelected.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fileInfoTypeSelected.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                fileInfoPathSelected.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }


        private void addPlaylistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createPlaylist();
        }

        private void addCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createCategory();
        }

        private void createDirectory(string directoryName)
        {
            ListViewItem directory = new ListViewItem();

            directory.Group = listViewLibrary.Groups[0];
            directory.Name = directoryName;
            directory.Text = directoryName;
            directory.Selected = true;

            listViewLibrary.Items.Add(directory);
        }

        private void createPlaylist()
        {
            ListViewItem playlist = new ListViewItem();
            PlaylistModel plist = new PlaylistModel();

            plist.PlaylistName = "plat";
            plist.MediaFiles = new List<MediaFileModel>();

            playlist.Group = listViewLibrary.Groups[1];
            playlist.Name = "New items";
            playlist.Text = "HelloEW";
            playlist.Selected = true;



            listViewLibrary.Items.Add(playlist);
        }

        private void createCategory()
        {
            ListViewItem category = new ListViewItem();
            CategoryModel ctg = new CategoryModel();

            ctg.CategoryName = "ctg as";
            ctg.CategoryFiles = new List<MediaFileModel>();

            category.Group = listViewLibrary.Groups[2];
            category.Name = "New items";
            category.Text = "HelloEW";
            category.Selected = true;

            listViewLibrary.Items.Add(category);
        }

        private void listViewLibrary_Click(object sender, EventArgs e)
        {
            string selectedList =  listViewLibrary.SelectedItems[0].Text;

            foreach(DirectoryModel directory in directories)
            {
                if (directory.DirectoryName == selectedList)
                {
                    dataGridView1.DataSource = directory.MediaFiles;
                } else
                {
                    dataGridView1.DataSource = null;
                }
            }

        }

        private void editPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlaylist pForm = new AddPlaylist();

            pForm.ShowDialog();

           
        }
    }
}
