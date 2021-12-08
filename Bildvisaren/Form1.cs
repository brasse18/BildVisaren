using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;

namespace Bildvisaren
{
   
    public partial class Form1 : Form
    {
        public List<string> image_List = new List<string>();
        int index = 0;
        public List<string> mapps = new List<string>();
        public List<int> RandListIndex = new List<int>();
        int zoomRatio = 2;
        Vector2 MousePos;
        private bool _dragging;
        private static Random rng = new Random();

        public Form1(string[] args)
        {
            InitializeComponent();
            loadeSetings();
            if (args.Length != 0)
            {
                if (args[0].EndsWith(".bvpl"))
                {
                    loadPlaylist(args[0]);
                } else
                {
                    foreach (string path in args)
                    {
                        mapps.Add(path);
                    }
                    foreach (string text in mapps)
                    {
                        Console.WriteLine(text);
                    }
                    AddFolder(mapps.ToArray());
                }
            }
            if(image_List.Count != 0)
            {
                updateImageInfo();
            }
            chromiumWebBrowser1.Visible = false;
        }

        public void makeRandList()
        {
            RandListIndex.Clear();
            for(int i = 0; i < image_List.Count; i++)
            {
                RandListIndex.Add(i);
            }
            ShuffleRandIndexList();
            //string Sout = "";
            //System.Console.WriteLine("Rand Array: ");
            //foreach (int item in RandListIndex)
            //{
            //    Sout += item.ToString();
            //    Sout += " ,";
            //}
            //System.Console.WriteLine(Sout);
        }
        public void ShuffleRandIndexList()
        {
            int n = RandListIndex.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = RandListIndex[k];
                RandListIndex[k] = RandListIndex[n];
                RandListIndex[n] = value;
            }

        }

        public int getNextRandImageIndex()
        {

            return 0;
        }

        public void loadeSetings()
        {
            if (Properties.Settings.Default.black_back == true)
            {
                svart_eller_vit_back.Checked = true;
                pictureBox1.BackColor = Color.Black;
                this.BackColor = Color.Black;
            }
            else
            {
                svart_eller_vit_back.Checked = false;
                pictureBox1.BackColor = Color.White;
                this.BackColor = Color.White;
            }

            if (Properties.Settings.Default.resize_mousewell == true)
            {
                scroll_Size.Checked = true;
            }
            else
            {
                scroll_Size.Checked = false;
            }

            if (Properties.Settings.Default.fit_w_screen == true)
            {
                checkBox_w_screen.Checked = true;
            }
            else
            {
                checkBox_w_screen.Checked = false;
            }
            if (Properties.Settings.Default.fit_h_screen == true)
            {
                checkBox_w_screen.Checked = true;
            }
            else
            {
                checkBox_w_screen.Checked = false;
            }
            numericUpDown1.Value = Properties.Settings.Default.scroll_factor;
            if (Properties.Settings.Default.image_move_invert == -1)
            {
                checkBox_invert_move.Checked = true;
            }
            else
            {
                checkBox_invert_move.Checked = false;
            }
            if (Properties.Settings.Default.rand_order_image == true)
            {
                checkBox_rand_order_of_image.Checked = true;
            }
            else
            {
                checkBox_rand_order_of_image.Checked = false;
            }
        }

        public void updateImageInfo()
        {
            if (image_List.Count != 0)
            {
                if (image_List.Count <= index)
                {
                    index = image_List.Count - 1;
                }
                if (image_List[index].EndsWith(".webp"))
                {
                    chromiumWebBrowser1.LoadUrl("file:///" + image_List[index]);
                    chromiumWebBrowser1.Visible = true;
                } else
                {
                    chromiumWebBrowser1.Visible = false;
                    pictureBox1.Image = Image.FromFile(image_List[index]);
                }

                if (checkBox_w_screen.Checked == true || checkBox_h_screen.Checked == true)
                {
                    pictureBox1.Size = pictureBox1.Image.Size;
                    if (checkBox_w_screen.Checked == true)
                    {
                        // ful lösning hitta någon annan
                        while (pictureBox1.Width >= pictureBox1.Parent.Width - 20)
                        {
                            pictureBox1.Width = (int)(pictureBox1.Width * 0.99);
                            pictureBox1.Height = (int)(pictureBox1.Height * 0.99);
                        }
                    }

                    if (checkBox_h_screen.Checked == true)
                    {
                        // ful lösning hitta någon annan
                        while (pictureBox1.Height >= pictureBox1.Parent.Height)
                        {
                            pictureBox1.Width = (int)(pictureBox1.Width * 0.99);
                            pictureBox1.Height = (int)(pictureBox1.Height * 0.99);
                        }
                    }
                }
                else
                {
                    pictureBox1.Size = pictureBox1.Image.Size;
                }

                Image_name.Text = image_List[index];
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Selected = false;
                    item.BackColor = Color.White;

                }
                listView1.Items[index].BackColor = Color.BlanchedAlmond;
            } else
            {
                Image_name.Text = "---- Ingen bild ----";
            }
            if(image_List.Count != RandListIndex.Count)
            {
                makeRandList();
            }
        }

        public void uppdateListview()
        {
            listView1.Items.Clear();
            foreach(string item in image_List)
            {
                ListViewItem lvi = new ListViewItem(item);
                listView1.Items.Add(lvi);
            }
        }

        public void saveToPath(string path)
        {
            System.IO.File.WriteAllLines(path, image_List.ToArray());
        }

        public void AddFolder(string[] folders)
        {
            foreach (string path in folders)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
            uppdateListview();
        }

        public void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public void ProcessFile(string path)
        {
            if (path.EndsWith(".jpg") || path.EndsWith(".png") || path.EndsWith(".jpeg") || path.EndsWith(".gif") || path.EndsWith(".webp"))
            {
                Console.WriteLine("Processed file '{0}'.", path);
                image_List.Add(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox_rand_order_of_image.Checked == true)
            {
                int tempInt = RandListIndex.IndexOf(index);
                if (tempInt == RandListIndex.Count - 1)
                {
                    index = RandListIndex[0];
                }
                else
                {
                    tempInt++;
                    index = RandListIndex[tempInt]; ;
                }
            } else
            {
                if (index == image_List.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }

            
                updateImageInfo();
        }

        private void pre_button_Click(object sender, EventArgs e)
        {
            if (checkBox_rand_order_of_image.Checked == true)
            {
                int tempInt = RandListIndex.IndexOf(index);
                if (tempInt == 0)
                {
                    index = RandListIndex[RandListIndex.Count - 1];
                }
                else
                {
                    tempInt--;
                    index = RandListIndex[tempInt]; ;
                }
            }
            else
            {
                if (index == 0)
                {
                    index = image_List.Count - 1;
                }
                else
                {
                    index--;
                }
            }

                updateImageInfo();

        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //Set the zoomed width and height
            int widthZoom = pictureBox1.Width * zoomRatio / 100;
            int heightZoom = pictureBox1.Height * zoomRatio / 100;
            // Update the drawing based upon the mouse wheel scrolling.
            if (Properties.Settings.Default.resize_mousewell == true)
            {
                int scroling = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
                //pictureBox1.Size = new System.Drawing.Size(pictureBox1.Size.Width + scroling, pictureBox1.Size.Height + scroling);
                pictureBox1.Width += widthZoom * scroling;
                pictureBox1.Height += heightZoom * scroling;
            }
        }

        private void plus_size_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(pictureBox1.Size.Width + 50, pictureBox1.Size.Height + 100);
        }

        private void nega_size_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(pictureBox1.Image.Width - 50, pictureBox1.Size.Height - 100);
        }

        private void scroll_Size_CheckedChanged(object sender, EventArgs e)
        {
            if (scroll_Size.Checked == true)
            {
                Properties.Settings.Default.resize_mousewell = true;
            } else
            {
                Properties.Settings.Default.resize_mousewell = false;
            }
            Properties.Settings.Default.Save();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void svart_eller_vit_back_CheckedChanged(object sender, EventArgs e)
        {
            if (svart_eller_vit_back.Checked == true)
            {
                Properties.Settings.Default.black_back = true;
                pictureBox1.BackColor = Color.Black;
                this.BackColor = Color.Black;
            }
            else
            {
                Properties.Settings.Default.black_back = false;
                pictureBox1.BackColor = Color.White;
                this.BackColor = Color.White;
            }
            Properties.Settings.Default.Save();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (String file in openFileDialog1.FileNames)
            {
                image_List.Add(file);
            }
            uppdateListview();
        }

        private void button_oppen_folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(folderBrowserDialog1.SelectedPath);
                mapps.Clear();
                mapps.Add(folderBrowserDialog1.SelectedPath);
                AddFolder(mapps.ToArray());
            }
        }

        private void button_image_list_visa_Click(object sender, EventArgs e)
        {
            if (listView1.Visible)
            {
                listView1.Visible = false;
            } else
            {
                listView1.Visible = true;
            }
        }

        private void checkBox_fit_w_screen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_w_screen.Checked == true)
            {
                Properties.Settings.Default.fit_w_screen = true;
            }
            else
            {
                Properties.Settings.Default.fit_w_screen = false;
            }
            Properties.Settings.Default.Save();
        }

        private void checkBox_h_screen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_h_screen.Checked == true)
            {
                Properties.Settings.Default.fit_h_screen = true;
            }
            else
            {
                Properties.Settings.Default.fit_h_screen = false;
            }
            Properties.Settings.Default.Save();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string path = saveFileDialog1.FileName;
            Console.WriteLine("path of file '{0}'.", path);
            saveToPath(path);
        }

        private void button_save_playlist_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button_load_playlist_Click(object sender, EventArgs e)
        {
            openFileDialog_load_playlist.ShowDialog();
        }

        public void loadPlaylist(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            image_List.Clear();
            foreach (string PathToAdd in lines)
            {
                image_List.Add(PathToAdd);
                Console.WriteLine("add '{0}'.", PathToAdd);
            }
            index = 0;
            uppdateListview();
            updateImageInfo();
        }

        private void openFileDialog_load_playlist_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loadPlaylist(openFileDialog_load_playlist.FileName);
        }

        private void contextMenuStrip_image_list_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void toolStripMenuItem_del_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                image_List.Remove(item.Text);
            }
            uppdateListview();
            makeRandList();
        }

        private void toolStripMenuItem_clear_Click(object sender, EventArgs e)
        {
            image_List.Clear();
            listView1.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, EventArgs e)
        {
            if (!_dragging) return;

            if (Control.MouseButtons == MouseButtons.Left)
            {
                //Console.WriteLine("X '{0}' VerticalScroll: '{1}' max: {2} min: {3}", (int)(MousePos.X - Control.MousePosition.X), panel2.VerticalScroll.Value, panel2.VerticalScroll.Maximum, panel2.VerticalScroll.Minimum);
                //Console.WriteLine("Y '{0}' HorizontalScroll: '{1}' max: {2} min: {3}", (int)(MousePos.Y - Control.MousePosition.Y), panel2.HorizontalScroll.Value, panel2.HorizontalScroll.Maximum, panel2.HorizontalScroll.Minimum);
                // X
                int HScroll = (int)(Properties.Settings.Default.scroll_factor * Properties.Settings.Default.image_move_invert * (MousePos.X - Control.MousePosition.X));
                if (panel2.HorizontalScroll.Maximum >= panel2.HorizontalScroll.Value+ HScroll && panel2.HorizontalScroll.Minimum <= panel2.HorizontalScroll.Value + HScroll)
                {
                    panel2.HorizontalScroll.Value += HScroll;
                    //Console.WriteLine("HorizontalScroll: '{0}'.", HScroll);
                }
                // Y
                int VScroll = (int)(Properties.Settings.Default.scroll_factor * Properties.Settings.Default.image_move_invert * (MousePos.Y - Control.MousePosition.Y));
                if (panel2.VerticalScroll.Maximum >= panel2.VerticalScroll.Value + VScroll && panel2.VerticalScroll.Minimum <= panel2.VerticalScroll.Value + VScroll)
                {
                    panel2.VerticalScroll.Value += VScroll;
                    //Console.WriteLine("VerticalScroll: '{0}'.", VScroll);
                }
            }
            MousePos.X = Control.MousePosition.X;
            MousePos.Y = Control.MousePosition.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                _dragging = true;
                MousePos.X = Control.MousePosition.X;
                MousePos.Y = Control.MousePosition.Y;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.scroll_factor = (int)numericUpDown1.Value;
            Properties.Settings.Default.Save();
        }

        private void checkBox_invert_move_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_invert_move.Checked == true)
            {
                Properties.Settings.Default.image_move_invert = -1;
            }
            else
            {
                Properties.Settings.Default.image_move_invert = 1;
            }
            Properties.Settings.Default.Save();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {
                index = listView1.SelectedItems[0].Index;
                updateImageInfo();
            }
            
        }

        private void checkBox_rand_order_of_image_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rand_order_of_image.Checked == true)
            {
                Properties.Settings.Default.rand_order_image = true;
            }
            else
            {
                Properties.Settings.Default.rand_order_image = false;
            }
            Properties.Settings.Default.Save();
        }
    }
}
