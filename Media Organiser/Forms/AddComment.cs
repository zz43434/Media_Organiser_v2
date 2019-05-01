using Media_Organiser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Organiser.Forms
{
    public partial class AddComment : Form
    {
        public AddComment(MediaFileModel file)
        {
            InitializeComponent();
            label2.Text = file.Name;
            label4.Text = file.Type;
            label6.Text = file.Path;
        }

        public string Comment = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Comment = textBox1.Text;
                this.Close();
            }
        }
    }
}
