
using System;
using System.Windows.Forms;
using CefSharp.Internals;
using CefSharp.Web;

namespace Bildvisaren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Next_Butten = new System.Windows.Forms.Button();
            this.pre_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_invert_move = new System.Windows.Forms.CheckBox();
            this.label_scroll_faktor = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_h_screen = new System.Windows.Forms.CheckBox();
            this.button_load_playlist = new System.Windows.Forms.Button();
            this.button_save_playlist = new System.Windows.Forms.Button();
            this.checkBox_w_screen = new System.Windows.Forms.CheckBox();
            this.button_image_list_visa = new System.Windows.Forms.Button();
            this.button_oppen_folder = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.svart_eller_vit_back = new System.Windows.Forms.CheckBox();
            this.Image_name = new System.Windows.Forms.Label();
            this.nega_size = new System.Windows.Forms.Button();
            this.scroll_Size = new System.Windows.Forms.CheckBox();
            this.plus_size = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip_image_list = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_load_playlist = new System.Windows.Forms.OpenFileDialog();
            this.checkBox_rand_order_of_image = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip_image_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // Next_Butten
            // 
            this.Next_Butten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Next_Butten.Location = new System.Drawing.Point(966, 3);
            this.Next_Butten.Name = "Next_Butten";
            this.Next_Butten.Size = new System.Drawing.Size(85, 61);
            this.Next_Butten.TabIndex = 0;
            this.Next_Butten.Text = "Nästa";
            this.Next_Butten.UseVisualStyleBackColor = true;
            this.Next_Butten.Click += new System.EventHandler(this.button1_Click);
            // 
            // pre_button
            // 
            this.pre_button.Location = new System.Drawing.Point(3, 3);
            this.pre_button.Name = "pre_button";
            this.pre_button.Size = new System.Drawing.Size(85, 61);
            this.pre_button.TabIndex = 1;
            this.pre_button.Text = "Föregående";
            this.pre_button.UseVisualStyleBackColor = true;
            this.pre_button.Click += new System.EventHandler(this.pre_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.checkBox_rand_order_of_image);
            this.panel1.Controls.Add(this.checkBox_invert_move);
            this.panel1.Controls.Add(this.label_scroll_faktor);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.checkBox_h_screen);
            this.panel1.Controls.Add(this.button_load_playlist);
            this.panel1.Controls.Add(this.button_save_playlist);
            this.panel1.Controls.Add(this.checkBox_w_screen);
            this.panel1.Controls.Add(this.button_image_list_visa);
            this.panel1.Controls.Add(this.button_oppen_folder);
            this.panel1.Controls.Add(this.Next_Butten);
            this.panel1.Controls.Add(this.pre_button);
            this.panel1.Controls.Add(this.button_open);
            this.panel1.Controls.Add(this.svart_eller_vit_back);
            this.panel1.Controls.Add(this.Image_name);
            this.panel1.Controls.Add(this.nega_size);
            this.panel1.Controls.Add(this.scroll_Size);
            this.panel1.Controls.Add(this.plus_size);
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 79);
            this.panel1.TabIndex = 2;
            this.panel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // checkBox_invert_move
            // 
            this.checkBox_invert_move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_invert_move.AutoSize = true;
            this.checkBox_invert_move.Location = new System.Drawing.Point(362, 45);
            this.checkBox_invert_move.Name = "checkBox_invert_move";
            this.checkBox_invert_move.Size = new System.Drawing.Size(82, 17);
            this.checkBox_invert_move.TabIndex = 16;
            this.checkBox_invert_move.Text = "Invert move";
            this.checkBox_invert_move.UseVisualStyleBackColor = true;
            this.checkBox_invert_move.CheckedChanged += new System.EventHandler(this.checkBox_invert_move_CheckedChanged);
            // 
            // label_scroll_faktor
            // 
            this.label_scroll_faktor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_scroll_faktor.AutoSize = true;
            this.label_scroll_faktor.Location = new System.Drawing.Point(359, 3);
            this.label_scroll_faktor.Name = "label_scroll_faktor";
            this.label_scroll_faktor.Size = new System.Drawing.Size(63, 13);
            this.label_scroll_faktor.TabIndex = 15;
            this.label_scroll_faktor.Text = "Scroll faktor";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(362, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox_h_screen
            // 
            this.checkBox_h_screen.AutoSize = true;
            this.checkBox_h_screen.Location = new System.Drawing.Point(144, 49);
            this.checkBox_h_screen.Name = "checkBox_h_screen";
            this.checkBox_h_screen.Size = new System.Drawing.Size(201, 17);
            this.checkBox_h_screen.TabIndex = 13;
            this.checkBox_h_screen.Text = "Anpasa nästa bild till Höjden av rutan";
            this.checkBox_h_screen.UseVisualStyleBackColor = true;
            this.checkBox_h_screen.CheckedChanged += new System.EventHandler(this.checkBox_h_screen_CheckedChanged);
            // 
            // button_load_playlist
            // 
            this.button_load_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_load_playlist.Location = new System.Drawing.Point(724, 33);
            this.button_load_playlist.Name = "button_load_playlist";
            this.button_load_playlist.Size = new System.Drawing.Size(75, 31);
            this.button_load_playlist.TabIndex = 12;
            this.button_load_playlist.Text = "Load Playlist";
            this.button_load_playlist.UseVisualStyleBackColor = true;
            this.button_load_playlist.Click += new System.EventHandler(this.button_load_playlist_Click);
            // 
            // button_save_playlist
            // 
            this.button_save_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save_playlist.Location = new System.Drawing.Point(724, 4);
            this.button_save_playlist.Name = "button_save_playlist";
            this.button_save_playlist.Size = new System.Drawing.Size(75, 30);
            this.button_save_playlist.TabIndex = 11;
            this.button_save_playlist.Text = "Save Playlist";
            this.button_save_playlist.UseVisualStyleBackColor = true;
            this.button_save_playlist.Click += new System.EventHandler(this.button_save_playlist_Click);
            // 
            // checkBox_w_screen
            // 
            this.checkBox_w_screen.AutoSize = true;
            this.checkBox_w_screen.Location = new System.Drawing.Point(144, 34);
            this.checkBox_w_screen.Name = "checkBox_w_screen";
            this.checkBox_w_screen.Size = new System.Drawing.Size(200, 17);
            this.checkBox_w_screen.TabIndex = 10;
            this.checkBox_w_screen.Text = "Anpasa nästa bild till bräden av rutan";
            this.checkBox_w_screen.UseVisualStyleBackColor = true;
            this.checkBox_w_screen.CheckedChanged += new System.EventHandler(this.checkBox_fit_w_screen_CheckedChanged);
            // 
            // button_image_list_visa
            // 
            this.button_image_list_visa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_image_list_visa.Location = new System.Drawing.Point(805, 33);
            this.button_image_list_visa.Name = "button_image_list_visa";
            this.button_image_list_visa.Size = new System.Drawing.Size(155, 31);
            this.button_image_list_visa.TabIndex = 9;
            this.button_image_list_visa.Text = "Visa listan av bilder";
            this.button_image_list_visa.UseVisualStyleBackColor = true;
            this.button_image_list_visa.Click += new System.EventHandler(this.button_image_list_visa_Click);
            // 
            // button_oppen_folder
            // 
            this.button_oppen_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_oppen_folder.Location = new System.Drawing.Point(805, 3);
            this.button_oppen_folder.Name = "button_oppen_folder";
            this.button_oppen_folder.Size = new System.Drawing.Size(80, 31);
            this.button_oppen_folder.TabIndex = 8;
            this.button_oppen_folder.Text = "Öppna Mapp";
            this.button_oppen_folder.UseVisualStyleBackColor = true;
            this.button_oppen_folder.Click += new System.EventHandler(this.button_oppen_folder_Click);
            // 
            // button_open
            // 
            this.button_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_open.Location = new System.Drawing.Point(884, 3);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(76, 31);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Öppna";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // svart_eller_vit_back
            // 
            this.svart_eller_vit_back.AutoSize = true;
            this.svart_eller_vit_back.Location = new System.Drawing.Point(144, 19);
            this.svart_eller_vit_back.Name = "svart_eller_vit_back";
            this.svart_eller_vit_back.Size = new System.Drawing.Size(192, 17);
            this.svart_eller_vit_back.TabIndex = 7;
            this.svart_eller_vit_back.Text = "bildens bakrunds färg(vit eller svart)";
            this.svart_eller_vit_back.UseVisualStyleBackColor = true;
            this.svart_eller_vit_back.CheckedChanged += new System.EventHandler(this.svart_eller_vit_back_CheckedChanged);
            // 
            // Image_name
            // 
            this.Image_name.AutoSize = true;
            this.Image_name.Location = new System.Drawing.Point(3, 64);
            this.Image_name.Name = "Image_name";
            this.Image_name.Size = new System.Drawing.Size(68, 13);
            this.Image_name.TabIndex = 7;
            this.Image_name.Text = "Image_name";
            // 
            // nega_size
            // 
            this.nega_size.Location = new System.Drawing.Point(94, 33);
            this.nega_size.Name = "nega_size";
            this.nega_size.Size = new System.Drawing.Size(44, 31);
            this.nega_size.TabIndex = 4;
            this.nega_size.Text = "-";
            this.nega_size.UseVisualStyleBackColor = true;
            this.nega_size.Click += new System.EventHandler(this.nega_size_Click);
            // 
            // scroll_Size
            // 
            this.scroll_Size.AutoSize = true;
            this.scroll_Size.Location = new System.Drawing.Point(144, 4);
            this.scroll_Size.Name = "scroll_Size";
            this.scroll_Size.Size = new System.Drawing.Size(166, 17);
            this.scroll_Size.TabIndex = 6;
            this.scroll_Size.Text = "Resize image using mous well";
            this.scroll_Size.UseVisualStyleBackColor = true;
            this.scroll_Size.CheckedChanged += new System.EventHandler(this.scroll_Size_CheckedChanged);
            // 
            // plus_size
            // 
            this.plus_size.Location = new System.Drawing.Point(94, 4);
            this.plus_size.Name = "plus_size";
            this.plus_size.Size = new System.Drawing.Size(44, 31);
            this.plus_size.TabIndex = 5;
            this.plus_size.Text = "+";
            this.plus_size.UseVisualStyleBackColor = true;
            this.plus_size.Click += new System.EventHandler(this.plus_size_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Bildvisaren.Properties.Resources.IMG_20170808_162357;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.chromiumWebBrowser1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 402);
            this.panel2.TabIndex = 3;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1055, 402);
            this.chromiumWebBrowser1.TabIndex = 1;
            this.chromiumWebBrowser1.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.ContextMenuStrip = this.contextMenuStrip_image_list;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(770, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(265, 383);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Visible = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // contextMenuStrip_image_list
            // 
            this.contextMenuStrip_image_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_del,
            this.toolStripMenuItem_clear});
            this.contextMenuStrip_image_list.Name = "contextMenuStrip_image_list";
            this.contextMenuStrip_image_list.Size = new System.Drawing.Size(129, 48);
            this.contextMenuStrip_image_list.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_image_list_Opening);
            // 
            // toolStripMenuItem_del
            // 
            this.toolStripMenuItem_del.Name = "toolStripMenuItem_del";
            this.toolStripMenuItem_del.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem_del.Text = "Ta bort";
            this.toolStripMenuItem_del.Click += new System.EventHandler(this.toolStripMenuItem_del_Click);
            // 
            // toolStripMenuItem_clear
            // 
            this.toolStripMenuItem_clear.Name = "toolStripMenuItem_clear";
            this.toolStripMenuItem_clear.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem_clear.Text = "Töm listan";
            this.toolStripMenuItem_clear.Click += new System.EventHandler(this.toolStripMenuItem_clear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Bilder(*.jepg;*.jpg;*.png;*.gif;*.webp) | *.jepg;*.jpg;*.png;*.gif;*.webp|All fi" +
    "les (*.*)|*.*\"";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "test";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bvpl";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog_load_playlist
            // 
            this.openFileDialog_load_playlist.FileName = "openFileDialog_load_playlist";
            this.openFileDialog_load_playlist.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_load_playlist_FileOk);
            // 
            // checkBox_rand_order_of_image
            // 
            this.checkBox_rand_order_of_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_rand_order_of_image.AutoSize = true;
            this.checkBox_rand_order_of_image.Location = new System.Drawing.Point(437, 4);
            this.checkBox_rand_order_of_image.Name = "checkBox_rand_order_of_image";
            this.checkBox_rand_order_of_image.Size = new System.Drawing.Size(124, 17);
            this.checkBox_rand_order_of_image.TabIndex = 17;
            this.checkBox_rand_order_of_image.Text = "Random image order";
            this.checkBox_rand_order_of_image.UseVisualStyleBackColor = true;
            this.checkBox_rand_order_of_image.CheckedChanged += new System.EventHandler(this.checkBox_rand_order_of_image_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 486);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bildvisaren";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip_image_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button Next_Butten;
        private System.Windows.Forms.Button pre_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button nega_size;
        private Button plus_size;
        private CheckBox scroll_Size;
        private Panel panel2;
        private Label Image_name;
        private CheckBox svart_eller_vit_back;
        private Button button_open;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button_oppen_folder;
        private ListView listView1;
        private Button button_image_list_visa;
        private CheckBox checkBox_w_screen;
        private SaveFileDialog saveFileDialog1;
        private Button button_save_playlist;
        private Button button_load_playlist;
        private OpenFileDialog openFileDialog_load_playlist;
        private ContextMenuStrip contextMenuStrip_image_list;
        private ToolStripMenuItem toolStripMenuItem_del;
        private ToolStripMenuItem toolStripMenuItem_clear;
        private CheckBox checkBox_h_screen;
        private Label label_scroll_faktor;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox_invert_move;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private CheckBox checkBox_rand_order_of_image;
    }
}

