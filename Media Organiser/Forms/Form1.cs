using Media_Organiser.Logic;
using System;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _test1 = new Directories(this);
            _test1.loadFiles();
            listViewLibrary.Groups.Add(new ListViewGroup("Directories"));
            listViewLibrary.Groups.Add(new ListViewGroup("Playlists"));
            listViewLibrary.Groups.Add(new ListViewGroup("Directories"));

        }

        private Directories _test1;
        
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _test1.createDirectory();
        }

        private void listViewLibrary_Click(object sender, EventArgs e)
        {
            _test1.changeDataSourceListViewClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void addPlaylistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _test1.createPlaylist();
        }

        private void addCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _test1.createCategory();
        }

        private void listViewLibrary_MouseDown(object sender, MouseEventArgs e)
        {
            _test1.listViewLibraryMenu(e.Button);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            _test1.dataGridViewClick(e);
        }
    }
}
