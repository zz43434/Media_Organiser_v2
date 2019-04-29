using Media_Organiser.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Media_Organiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MediaFile> mediaFiles = new List<MediaFile>();
        string[] filePaths;
        List<Playlist> playlists = new List<Playlist>();
        List<Category> categories = new List<Category>();

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Environment.SpecialFolder root = folderDlg.RootFolder;
                filePaths = Directory.GetFiles(@folderDlg.SelectedPath,"*", SearchOption.AllDirectories);
            }

            if (result == DialogResult.OK)
            {
                for (var i = 0; i < filePaths.Length; i++)
                {
                    var fn = new FileInfo(filePaths[i]);
                    MediaFile importFile = new MediaFile();
                    importFile.Name = fn.Name.ToString();
                    importFile.Type = fn.Extension.ToString();
                    importFile.Path = fn.Directory.ToString();

                    mediaFiles.Add(importFile);
                }
            }
            dataGridView1.DataSource = mediaFiles;

            //using (StreamReader sr = new StreamReader(".\\MediaFiles.json"))
            //{
            //    string json = sr.ReadToEnd();
            //    mediaFiles = JsonConvert.DeserializeObject<List<MediaFile>>(json);
            //}


            using (StreamWriter file = File.CreateText(".\\MediaFiles.json"))
            {
                JsonSerializer serializer = new JsonSerializer();

                string json = JsonConvert.SerializeObject(mediaFiles);

                serializer.Serialize(file, json);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPlaylist addPlaylist = new AddPlaylist();

            addPlaylist.Show();
        }
    }
}
