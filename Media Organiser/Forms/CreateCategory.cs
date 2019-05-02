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
    public partial class CreateCategory : Form
    {
        public CreateCategory()
        {
            InitializeComponent();
        }

        public string categoryName { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                categoryName = textBox1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter Category name!");
            }
        }
    }
}
