﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ComputerEditing.Properties;

namespace ComputerEditing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] folderNames = { "Folders", "Pictures", "Musics", "Videos", "Programs",
                                           "Web Files", "Compressed Files", "Office Files", "Shortcuts" };

        string[] extensions = { "", ".jpg.jpeg.png.ico.gif.bmp.ai.psd", ".mp3.mp4.au.mpg.mpeg", ".avi.flv.mov.qt", ".exe.bat.com", 
                                                         ".html.htm.aspx.php.css.jsp.js", ".rar.zip.iso.arc.cab", 
                                                         ".xls.xlsx.doc.docx.md5.accdb.txt.pps.pdf.log.bak.bat.dll.ttf", ".lnk" };

        private byte errCondition = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog gs = new FolderBrowserDialog();
            gs.ShowDialog();
            if (gs.SelectedPath != "")
            {
                txtPath.Text = gs.SelectedPath;
            }
            else
            {
                MessageBox.Show("Select Folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.folder;
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtPath.Text = desktop;
        }

        private void btnKlasorle_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                string path = txtPath.Text;
                string[] folders = Directory.GetFiles(path);

                foreach (CheckBox item in groupBox2.Controls)
                {
                    if (item.Checked)
                    {
                        string fileName = item.Text;
                        int fileNameIndex = 0;
                        for (int a = 0; a < folderNames.Length; a++)
                        {
                            if (folderNames[a].ToString() == fileName)
                            {
                                fileNameIndex = a;
                            }
                        }
                        string extension = extensions[fileNameIndex].ToString();

                        for (int a = 0; a < folders.Length; a++)
                        {
                            if (fileName != "Folders")
                            {
                                string namee = "";
                                try
                                {
                                    int lastPointIndex = folders[a].ToString().LastIndexOf(".");
                                    string DynFileExtension = folders[a].ToString().Substring(lastPointIndex,
                                                                      folders[a].ToString().Length - lastPointIndex);
                                    if (extension.Contains(DynFileExtension))
                                    {
                                        if (!Directory.Exists(path + "\\" + fileName))
                                        {
                                            Directory.CreateDirectory(path + "\\" + fileName);
                                        }
                                        int lastSlamIndex = folders[a].ToString().LastIndexOf(@"\");
                                        namee = folders[a].ToString().Substring(lastSlamIndex,
                                                                        folders[a].ToString().Length - lastSlamIndex);
                                        File.Move(folders[a].ToString(), path + "\\" + fileName + "\\" + namee);
                                    }
                                }
                                catch (Exception)
                                {
                                    errCondition = 1;
                                }
                            }
                            else
                            {
                                string[] folderss = Directory.GetDirectories(path);
                                string fileNamee = "";
                                for (int b = 0; b < folderss.Length; b++)
                                {
                                    try
                                    {
                                        string filePath = folderss[b].ToString();
                                        int lastSlaj = filePath.LastIndexOf(@"\");
                                        fileNamee = filePath.Substring(lastSlaj, folderss[b].ToString().Length
                                                                                                              - lastSlaj);
                                        string folderUnnamedPath = filePath.Substring(0, filePath.Length
                                                                                                      - fileNamee.Length);
                                        string lastPath = folderUnnamedPath + "\\Folders" + fileNamee;
                                        if (!fileNamee.Contains("Folders"))
                                        {
                                            if (!Directory.Exists(path + "\\" + fileName))
                                            {
                                                Directory.CreateDirectory(path + "\\" + fileName);
                                            }
                                            Directory.Move(filePath, lastPath);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        errCondition = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Path", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (errCondition == 1)
            {
                MessageBox.Show("Some running applications have not moved. Try again after closing the applications.",
                                                                    "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://utopian.io/@shankstaicho");
        }
    }
}