namespace Media_Organiser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Directories", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Playlists", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Categories", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.listViewLibrary = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fileInfoNameLabel = new System.Windows.Forms.Label();
            this.fileInfoNameSelected = new System.Windows.Forms.Label();
            this.fileInfoTypeLabel = new System.Windows.Forms.Label();
            this.fileInfoTypeSelected = new System.Windows.Forms.Label();
            this.fileInfoPathLabel = new System.Windows.Forms.Label();
            this.fileInfoPathSelected = new System.Windows.Forms.Label();
            this.fileInfoCommentLabel = new System.Windows.Forms.Label();
            this.fileInfoCommentSelected = new System.Windows.Forms.TextBox();
            this.fileInfoCategoryLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library:";
            // 
            // listViewLibrary
            // 
            this.listViewLibrary.AutoArrange = false;
            listViewGroup1.Header = "Directories";
            listViewGroup1.Name = "Directories";
            listViewGroup1.Tag = "Directories";
            listViewGroup2.Header = "Playlists";
            listViewGroup2.Name = "Playlists";
            listViewGroup2.Tag = "Playlists";
            listViewGroup3.Header = "Categories";
            listViewGroup3.Name = "Categories";
            listViewGroup3.Tag = "Categories";
            this.listViewLibrary.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.listViewLibrary.Location = new System.Drawing.Point(16, 40);
            this.listViewLibrary.MultiSelect = false;
            this.listViewLibrary.Name = "listViewLibrary";
            this.listViewLibrary.Size = new System.Drawing.Size(174, 398);
            this.listViewLibrary.TabIndex = 1;
            this.listViewLibrary.UseCompatibleStateImageBehavior = false;
            this.listViewLibrary.View = System.Windows.Forms.View.Tile;
            this.listViewLibrary.Click += new System.EventHandler(this.listViewLibrary_Click);
            this.listViewLibrary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewLibrary_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMediaToolStripMenuItem,
            this.addPlaylistToolStripMenuItem,
            this.addCategoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importMediaToolStripMenuItem
            // 
            this.importMediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.importMediaToolStripMenuItem.Name = "importMediaToolStripMenuItem";
            this.importMediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.importMediaToolStripMenuItem.Text = "Media";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.importToolStripMenuItem.Text = "Import ";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // addPlaylistToolStripMenuItem
            // 
            this.addPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlaylistToolStripMenuItem1});
            this.addPlaylistToolStripMenuItem.Name = "addPlaylistToolStripMenuItem";
            this.addPlaylistToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.addPlaylistToolStripMenuItem.Text = "Playlists";
            // 
            // addPlaylistToolStripMenuItem1
            // 
            this.addPlaylistToolStripMenuItem1.Name = "addPlaylistToolStripMenuItem1";
            this.addPlaylistToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.addPlaylistToolStripMenuItem1.Text = "Add Playlist";
            this.addPlaylistToolStripMenuItem1.Click += new System.EventHandler(this.addPlaylistToolStripMenuItem1_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem1});
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.addCategoryToolStripMenuItem.Text = "Categories";
            // 
            // addCategoryToolStripMenuItem1
            // 
            this.addCategoryToolStripMenuItem1.Name = "addCategoryToolStripMenuItem1";
            this.addCategoryToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.addCategoryToolStripMenuItem1.Text = "Add Category";
            this.addCategoryToolStripMenuItem1.Click += new System.EventHandler(this.addCategoryToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.fileType,
            this.filePath,
            this.fileComments});
            this.dataGridView1.Location = new System.Drawing.Point(197, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(408, 398);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // fileName
            // 
            this.fileName.DataPropertyName = "Name";
            this.fileName.HeaderText = "Name";
            this.fileName.Name = "fileName";
            // 
            // fileType
            // 
            this.fileType.DataPropertyName = "Type";
            this.fileType.HeaderText = "Type";
            this.fileType.Name = "fileType";
            // 
            // filePath
            // 
            this.filePath.DataPropertyName = "Path";
            this.filePath.HeaderText = "Path";
            this.filePath.Name = "filePath";
            // 
            // fileComments
            // 
            this.fileComments.DataPropertyName = "Comment";
            this.fileComments.HeaderText = "Comment";
            this.fileComments.Name = "fileComments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File View:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(627, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 178);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fileInfoNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoNameSelected, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoTypeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoTypeSelected, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoPathLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoPathSelected, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoCommentLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoCommentSelected, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoCategoryLabel, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(627, 224);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 130);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // fileInfoNameLabel
            // 
            this.fileInfoNameLabel.AutoSize = true;
            this.fileInfoNameLabel.Location = new System.Drawing.Point(3, 0);
            this.fileInfoNameLabel.Name = "fileInfoNameLabel";
            this.fileInfoNameLabel.Size = new System.Drawing.Size(38, 13);
            this.fileInfoNameLabel.TabIndex = 0;
            this.fileInfoNameLabel.Text = "Name:";
            // 
            // fileInfoNameSelected
            // 
            this.fileInfoNameSelected.AutoSize = true;
            this.fileInfoNameSelected.Location = new System.Drawing.Point(118, 0);
            this.fileInfoNameSelected.Name = "fileInfoNameSelected";
            this.fileInfoNameSelected.Size = new System.Drawing.Size(0, 13);
            this.fileInfoNameSelected.TabIndex = 1;
            // 
            // fileInfoTypeLabel
            // 
            this.fileInfoTypeLabel.AutoSize = true;
            this.fileInfoTypeLabel.Location = new System.Drawing.Point(3, 26);
            this.fileInfoTypeLabel.Name = "fileInfoTypeLabel";
            this.fileInfoTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.fileInfoTypeLabel.TabIndex = 2;
            this.fileInfoTypeLabel.Text = "Type:";
            // 
            // fileInfoTypeSelected
            // 
            this.fileInfoTypeSelected.AutoSize = true;
            this.fileInfoTypeSelected.Location = new System.Drawing.Point(118, 26);
            this.fileInfoTypeSelected.Name = "fileInfoTypeSelected";
            this.fileInfoTypeSelected.Size = new System.Drawing.Size(0, 13);
            this.fileInfoTypeSelected.TabIndex = 3;
            // 
            // fileInfoPathLabel
            // 
            this.fileInfoPathLabel.AutoSize = true;
            this.fileInfoPathLabel.Location = new System.Drawing.Point(3, 52);
            this.fileInfoPathLabel.Name = "fileInfoPathLabel";
            this.fileInfoPathLabel.Size = new System.Drawing.Size(32, 13);
            this.fileInfoPathLabel.TabIndex = 4;
            this.fileInfoPathLabel.Text = "Path:";
            // 
            // fileInfoPathSelected
            // 
            this.fileInfoPathSelected.AutoSize = true;
            this.fileInfoPathSelected.Location = new System.Drawing.Point(118, 52);
            this.fileInfoPathSelected.Name = "fileInfoPathSelected";
            this.fileInfoPathSelected.Size = new System.Drawing.Size(0, 13);
            this.fileInfoPathSelected.TabIndex = 5;
            // 
            // fileInfoCommentLabel
            // 
            this.fileInfoCommentLabel.AutoSize = true;
            this.fileInfoCommentLabel.Location = new System.Drawing.Point(3, 78);
            this.fileInfoCommentLabel.Name = "fileInfoCommentLabel";
            this.fileInfoCommentLabel.Size = new System.Drawing.Size(56, 13);
            this.fileInfoCommentLabel.TabIndex = 6;
            this.fileInfoCommentLabel.Text = "Comments";
            // 
            // fileInfoCommentSelected
            // 
            this.fileInfoCommentSelected.Location = new System.Drawing.Point(118, 81);
            this.fileInfoCommentSelected.Name = "fileInfoCommentSelected";
            this.fileInfoCommentSelected.Size = new System.Drawing.Size(100, 20);
            this.fileInfoCommentSelected.TabIndex = 7;
            // 
            // fileInfoCategoryLabel
            // 
            this.fileInfoCategoryLabel.AutoSize = true;
            this.fileInfoCategoryLabel.Location = new System.Drawing.Point(3, 104);
            this.fileInfoCategoryLabel.Name = "fileInfoCategoryLabel";
            this.fileInfoCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.fileInfoCategoryLabel.TabIndex = 8;
            this.fileInfoCategoryLabel.Text = "Category:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listViewLibrary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlaylistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label fileInfoNameLabel;
        private System.Windows.Forms.Label fileInfoNameSelected;
        private System.Windows.Forms.Label fileInfoTypeLabel;
        private System.Windows.Forms.Label fileInfoTypeSelected;
        private System.Windows.Forms.Label fileInfoPathLabel;
        private System.Windows.Forms.Label fileInfoPathSelected;
        private System.Windows.Forms.Label fileInfoCommentLabel;
        private System.Windows.Forms.TextBox fileInfoCommentSelected;
        private System.Windows.Forms.Label fileInfoCategoryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileComments;
        public System.Windows.Forms.ListView listViewLibrary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

