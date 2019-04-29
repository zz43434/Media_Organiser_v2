using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lines = "ffs";

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(".\\MediaFiles.json");
            file.WriteLine(lines);
            
            file.Close();

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                label2.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            string[] filePaths = Directory.GetFiles(@folderDlg.SelectedPath);
            label3.Text = string.Join(" ", filePaths.ToString());

            for(var i = 0; i < filePaths.Length; i++)
            {
                
            }

            dataGridView1.DataSource = filePaths;



        }
    }
}
