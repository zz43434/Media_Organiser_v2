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
    public partial class AddCategory : Form
    {
        public AddCategory(MediaFileModel file, List<string> categories)
        {
            InitializeComponent();
            label3.Text = file.Name;
            label5.Text = file.Type;
            label7.Text = file.Path;
            if (file.Comment != "")
            {
                label9.Text = file.Comment;
            }
            if (file.Category != null)
            {
                label11.Text = file.Category.ToString();
            }
            listBox1.DataSource = categories;
        }

        public CategoryModel Category;

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Category = new CategoryModel(listBox1.SelectedValue.ToString());
                this.Close();
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Category = new CategoryModel(listBox1.SelectedValue.ToString());
            label11.Text = listBox1.SelectedItem.ToString();
        }
    }
}
