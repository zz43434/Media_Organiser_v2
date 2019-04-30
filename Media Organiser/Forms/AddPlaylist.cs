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
        public AddPlaylist()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "hello";


            this.Close();
        }
    }
}
