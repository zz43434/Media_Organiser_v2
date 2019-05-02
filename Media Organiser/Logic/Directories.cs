using Media_Organiser.Forms;
using Media_Organiser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Organiser.Logic
{
    public class Directories
    {
        private Form1 _form;
        private string[] filePaths;
        public List<DirectoryModel> directories = new List<DirectoryModel>();
        public List<PlaylistModel> playlists = new List<PlaylistModel>();
        public List<CategoryModel> categories = new List<CategoryModel>();

        public Directories(Form1 form)
        {
            _form = form;
        }

        public void loadFiles()
        {
            try
            {
                playlists = Json.ReadSavedObject<List<PlaylistModel>>(@".\playlists.json");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                directories = Json.ReadSavedObject<List<DirectoryModel>>(@".\directories.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                categories = Json.ReadSavedObject<List<CategoryModel>>(@".\categories.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (directories != null)
            {
                foreach(DirectoryModel direc in directories)
                {
                    _form.listViewLibrary.Items.Add(new ListViewItem(direc.DirectoryName, _form.listViewLibrary.Groups[0]));
                }
            }
            if(playlists != null)
            {
                foreach(PlaylistModel playlist in playlists)
                {
                    _form.listViewLibrary.Items.Add(new ListViewItem(playlist.PlaylistName, _form.listViewLibrary.Groups[1]));
                }
            }
            if(categories != null)
            {
                foreach(CategoryModel category in categories)
                {
                    _form.listViewLibrary.Items.Add(new ListViewItem(category.CategoryName, _form.listViewLibrary.Groups[2]));
                }
            }
            _form.listViewLibrary.Refresh();
        }

        public void createDirectory()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = true;
         
            DialogResult result = folderBrowser.ShowDialog();
            DirectoryModel direct = new DirectoryModel(folderBrowser.SelectedPath, new BindingList<MediaFileModel>());

            if (result == DialogResult.OK)
            {
                Environment.SpecialFolder root = folderBrowser.RootFolder;
                try
                {
                    filePaths = Directory.GetFiles(folderBrowser.SelectedPath, "*.pdf", SearchOption.AllDirectories);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (var i = 0; i < filePaths.Length; i++)
            {
                var fn = new FileInfo(filePaths[i]);
                MediaFileModel importFile = new MediaFileModel();
                importFile.Name = fn.Name.ToString();
                importFile.Type = fn.Extension.ToString();
                importFile.Path = fn.Directory.ToString();

                direct.MediaFiles.Add(importFile);
            }

            ListViewItem directory = new ListViewItem(folderBrowser.SelectedPath, _form.listViewLibrary.Groups[0]);
            directory.Selected = true;

            directories.Add(direct);
            _form.listViewLibrary.Items.Add(directory);

            _form.dataGridView1.DataSource = direct.MediaFiles;
            Json.saveToJson(@".\directories.json", directories);
        }

        public void createPlaylist()
        {
            AddPlaylist pForm = new AddPlaylist(directories);
            pForm.ShowDialog();

            ListViewItem playlist = new ListViewItem(pForm.playlistName, _form.listViewLibrary.Groups[1]);
            PlaylistModel plist = new PlaylistModel(pForm.playlistName, new List<MediaFileModel>());
            playlist.Selected = true;

            foreach (MediaFileModel file in pForm.addPlaylist)
            {
                plist.MediaFiles.Add(file);
            }

            playlists.Add(plist);
            _form.listViewLibrary.Items.Add(playlist);

            _form.dataGridView1.DataSource = plist.MediaFiles;
            Json.saveToJson(@".\playlists.json", playlists);
        }

        public void createCategory()
        {
            CreateCategory newCategory = new CreateCategory();
            newCategory.ShowDialog();
            
            CategoryModel ctg = new CategoryModel(newCategory.categoryName);
            ListViewItem category = new ListViewItem(newCategory.categoryName, _form.listViewLibrary.Groups[2]);
            category.Selected = true;

            categories.Add(ctg);
            _form.listViewLibrary.Items.Add(category);
            Json.saveToJson(@".\categories.json", categories);
        }

        public void deleteListViewItem(ListViewItem item)
        {
            foreach (DirectoryModel direc in directories.ToArray())
            {
                directories.Remove(direc);
                _form.listViewLibrary.Items.Remove(item);
            }

            foreach (PlaylistModel playlist in playlists.ToArray())
            {
                if (playlist.PlaylistName == item.Text)
                {
                    playlists.Remove(playlist);
                    _form.listViewLibrary.Items.Remove(item);
                }
            }

            foreach (CategoryModel category in categories.ToArray())
            {
                if (category.CategoryName == item.Text)
                {
                    categories.Remove(category);
                    _form.listViewLibrary.Items.Remove(item);
                }
            }

            _form.dataGridView1.DataSource = null;

            Json.saveToJson(@".\playlists.json", categories);
            Json.saveToJson(@".\categories.json", categories);
            Json.saveToJson(@".\directories.json", categories);
        }

        public void editListViewItem(ListViewItem item)
        {
            foreach (PlaylistModel playlist in playlists)
            {
                if (playlist.PlaylistName == item.Text)
                {
                    AddPlaylist form = new AddPlaylist(playlist, directories);
                    form.ShowDialog();

                    playlist.PlaylistName = form.playlistName;
                    item.Text = form.playlistName;
                    playlist.MediaFiles.RemoveRange(0, playlist.MediaFiles.Count);

                    foreach (MediaFileModel file in form.addPlaylist)
                    {
                        playlist.MediaFiles.Add(file);
                    }
                    item.Selected = true;
                    _form.dataGridView1.Refresh();
                }
            }
        }

        private void addCategoryMediaItem(MediaFileModel file)
        {
            List<string> categoryList = new List<string>();

            foreach (ListViewItem item in _form.listViewLibrary.Groups[2].Items)
            {
                categoryList.Add(item.Text);
            }
            AddCategory categoryForm = new AddCategory(file, categoryList);
            categoryForm.ShowDialog();

            file.Category = categoryForm.Category.CategoryName;
        }

        private void editListMediaItem(MediaFileModel file)
        {
            AddComment form = new AddComment(file);
            form.ShowDialog();

            file.Comment = form.Comment;
        }

        private void deleteListMediaItem(ListViewItem selectedList)
        {
            MediaFileModel file = _form.dataGridView1.CurrentRow.DataBoundItem as MediaFileModel;
        }

        public void changeDataSourceListViewClick()
        {
            string selectedList = _form.listViewLibrary.SelectedItems[0].Text;

            foreach (DirectoryModel directory in directories)
            {
                if (directory.DirectoryName == selectedList)
                {
                    _form.dataGridView1.DataSource = directory.MediaFiles;
                }
            }

            foreach (PlaylistModel playlist in playlists)
            {
                if (playlist.PlaylistName == selectedList)
                {
                    _form.dataGridView1.DataSource = playlist.MediaFiles;
                }
            }
        }

        private void listViewMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListViewItem selectedList = _form.listViewLibrary.SelectedItems[0];
            switch (e.ClickedItem.ToString())
            {
                case "Delete":
                    deleteListViewItem(selectedList);
                    _form.dataGridView1.Refresh();
                    break;
                case "Edit":
                    editListViewItem(selectedList);
                    _form.dataGridView1.Refresh();
                    break;
            }
        }

        internal void listViewLibraryMenu(MouseButtons button)
        {
            if (button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Edit");
                menu.Items.Add("Delete");
                menu.ItemClicked += new ToolStripItemClickedEventHandler(listViewMenu_ItemClicked);
                menu.Show(Cursor.Position);
            }
        }

        private void dataGridViewMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MediaFileModel file = _form.dataGridView1.CurrentRow.DataBoundItem as MediaFileModel;

            ListViewItem selectedList = _form.listViewLibrary.SelectedItems[0];
            switch (e.ClickedItem.ToString())
            {
                case "Delete":
                    deleteListMediaItem(selectedList);
                    _form.dataGridView1.Refresh();
                    break;
                case "Add Comment":
                    editListMediaItem(file);
                    _form.dataGridView1.Refresh();
                    break;
                case "Add Category":
                    addCategoryMediaItem(file);
                    _form.dataGridView1.Refresh();
                    break;
            }
        }

        internal void dataGridViewClick(MouseEventArgs e)
        {
            if (_form.dataGridView1.SelectedRows.Count > 0)
            {
                _form.fileInfoNameSelected.Text = _form.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                _form.fileInfoTypeSelected.Text = _form.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                _form.fileInfoPathSelected.Text = _form.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                if (_form.dataGridView1.SelectedRows[0].Cells[3].Value != null)
                {
                    _form.fileInfoComment.Text = _form.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            
            if (e.Button == MouseButtons.Right && _form.dataGridView1.DataSource != null)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Add Comment");
                menu.Items.Add("Add Category");
                menu.Items.Add("Delete");
                menu.ItemClicked += new ToolStripItemClickedEventHandler(dataGridViewMenu_ItemClicked);
                menu.Show(Cursor.Position);
            }
        }
    }
}
