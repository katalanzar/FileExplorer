using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string lastfolder = "..";
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var disk in DriveInfo.GetDrives())
            {
                cmbDrives.Items.Add(disk.Name);
                cmbDrives2.Items.Add(disk.Name);
            }
        }

        private void cmbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastfolder = cmbDrives.Text;
            List<DirectoryInfo> folders = new DirectoryInfo(cmbDrives.Text).GetDirectories().ToList();
            lstDir.Items.Clear();
            Dictionary<string, string> dicFolders = new Dictionary<string, string>();

            foreach (var folder in folders)
            {
                dicFolders.Add(folder.Name, folder.FullName);
            }

            lstDir.DataSource = new BindingSource(dicFolders, null);
            lstDir.DisplayMember = "Key";
            lstDir.ValueMember = "Value";
        }

        private void lstDir_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                lstFiles.DataSource = null;
                lstFiles.Items.Clear();
                List<FileInfo> files = new DirectoryInfo(lstDir.SelectedValue.ToString()).GetFiles().ToList();
                Dictionary<string, string> dicFiles = new Dictionary<string, string>();

                foreach (var file in files)
                {
                    dicFiles.Add(file.Name, file.FullName);
                }

                lstFiles.DataSource = new BindingSource(dicFiles, null);
                lstFiles.DisplayMember = "Key";
                lstFiles.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string selectedfolder = lstDir.SelectedValue.ToString();
            string selectedfoldertext = lstDir.Text;

            if(selectedfoldertext=="..")
            {
                if(new DirectoryInfo(lastfolder).Parent!=null)
                {
                    selectedfolder = new DirectoryInfo(lastfolder).Parent.FullName;
                }
            }
            List<DirectoryInfo> folders = new DirectoryInfo(lstDir.SelectedValue.ToString()).GetDirectories().ToList();
            lstDir.DataSource = null;
            Dictionary<string, string> dicFolders = new Dictionary<string, string>();
            dicFolders.Add("..", lastfolder);
            lastfolder = selectedfolder;

            foreach (var folder in folders)
            {
                dicFolders.Add(folder.Name, folder.FullName);
            }
            lstDir.DataSource = new BindingSource(dicFolders, null);
            lstDir.DisplayMember = "Key";
            lstDir.ValueMember = "Value";
        }

        private void lstFiles_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(lstFiles.SelectedValue.ToString());
            txtSize.Text = file.Length.ToString("N");
            txtAccess.Text = file.LastAccessTimeUtc.ToString();
            txtCreated.Text = file.CreationTimeUtc.ToString();
            txtPath.Text = file.FullName; 
        }
    }


}
