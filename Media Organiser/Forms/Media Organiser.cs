using Media_Organiser.Logic;
using System;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class MediaOrganiser : Form
    {
        public MediaOrganiser()
        {
            InitializeComponent();
            _test1 = new LogicClass(this);
        }

        private LogicClass _test1;
        
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

        private void MediaOrganiser_Load(object sender, EventArgs e)
        {

        }
    }
}
