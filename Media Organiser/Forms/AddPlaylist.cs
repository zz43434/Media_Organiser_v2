using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Media_Organiser.Models
{
    public partial class AddPlaylist : Form
    {
        public AddPlaylist(List<DirectoryModel> directories)
        {
            InitializeComponent();
            direc = directories;
        }

        public AddPlaylist(PlaylistModel playlist, List<DirectoryModel> directories)
        {
            InitializeComponent();
            direc = directories;
            foreach(MediaFileModel media in playlist.MediaFiles)
            {
                addPlaylist.Add(media);
            }
            playlistName = playlist.PlaylistName;
            textBox1.Text = playlistName;
        }


        public List<DirectoryModel> direc;
        public BindingList<MediaFileModel> addPlaylist = new BindingList<MediaFileModel>();
        public BindingList<MediaFileModel> allMedia = new BindingList<MediaFileModel>();
        public string playlistName = "";

        private void AddPlaylist_Load(object sender, EventArgs e)
        {
            foreach (DirectoryModel director in direc)
            {
                foreach (MediaFileModel media in director.MediaFiles)
                {
                    allMedia.Add(media);
                }
            }
            dataGridView1.DataSource = allMedia;
            dataGridView2.DataSource = addPlaylist;
            

            dataGridView1.AutoGenerateColumns = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { return; }
            MediaFileModel currentFile = dataGridView1.CurrentRow.DataBoundItem as MediaFileModel;
            String filename = currentFile.Name;
            try
            {
                allMedia.Remove(currentFile);
                addPlaylist.Add(currentFile);
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) { return; }
            MediaFileModel selectedFile = dataGridView2.CurrentRow.DataBoundItem as MediaFileModel;

            addPlaylist.Remove(selectedFile);
            allMedia.Add(selectedFile);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && addPlaylist.Count > 0)
            {
                playlistName = textBox1.Text;
                this.Close();
            }
        }

        private MediaFileModel findDataInSet(String filename)
        {
            MediaFileModel match = new MediaFileModel();
            foreach (MediaFileModel model in allMedia)
            {
                String modelName = model.Name;
                if (!modelName.Equals(filename)) { continue; }
                match = model;
            }
            return match;
        }
    }
}
