using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        List<DirectoryModel> direc;
        List<MediaFileModel> addPlaylist = new List<MediaFileModel>();
        List<MediaFileModel> allMedia = new List<MediaFileModel>();

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
            dataGridView2.DataSource = addPlaylist.ToArray();

            dataGridView1.AutoGenerateColumns = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MediaFileModel currentFile = dataGridView1.CurrentRow.DataBoundItem as MediaFileModel;
            addPlaylist.Add(currentFile);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();

            if (textBox1.Text.Length > 0 && addPlaylist != null)
            {
                form.createPlaylist(textBox1.Text, addPlaylist);
            }

            this.Close();
        }
    }
}
