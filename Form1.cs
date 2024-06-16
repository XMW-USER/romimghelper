/*
 * Romimghelper v1.00
 * Copyright (c) 2024 [XMW-USER]
 * Licensed under the MIT License. See LICENSE file in the project root for full license information.
 * GitHub: https://github.com/xmwuser/romimghelper
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;

namespace romimghelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "icon.ico"));

            progressBar1.Visible = false;
        }

        private void btnMovePNGs_Click(object sender, EventArgs e)
        {
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string folderPath = Path.GetDirectoryName(Application.ExecutablePath);
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Could not determine the executable path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pngFiles = Directory.GetFiles(folderPath, "*.png");
            var zipFiles = Directory.GetFiles(folderPath, "*.zip");

            progressBar1.Maximum = pngFiles.Length;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            foreach (var pngFile in pngFiles)
            {
                string pngFileName = Path.GetFileNameWithoutExtension(pngFile); 
                foreach (var zipFile in zipFiles)
                {
                    string zipFileName = Path.GetFileNameWithoutExtension(zipFile);
                    if (zipFileName == pngFileName)
                    {
                        using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Update))
                        {
                            archive.CreateEntryFromFile(pngFile, Path.GetFileName(pngFile));
                            File.Delete(pngFile); // Optionally delete the PNG file after adding to ZIP
                        }
                        break; // Move to the next PNG file once it's added to the appropriate ZIP
                    }
                }

                progressBar1.Value++;
            }

            progressBar1.Visible = false;
            MessageBox.Show("PNG files moved to ZIP files successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

private void lblCopyright_Click(object sender, EventArgs e)
{
    string githubUrl = "https://github.com/xmwuser/romimghelper";

    try
    {
        System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
        {
            FileName = githubUrl,
            UseShellExecute = true
        };
        System.Diagnostics.Process.Start(psi);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error opening GitHub URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void btnDeletePNGs_Click(object sender, EventArgs e)
        {
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string folderPath = Path.GetDirectoryName(Application.ExecutablePath);
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Could not determine the executable path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pngFiles = Directory.GetFiles(folderPath, "*.png");

            progressBar1.Maximum = pngFiles.Length;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            if (MessageBox.Show("Do you want to delete all the remaining PNG files?", "Delete PNG Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var pngFile in pngFiles)
                {
                    File.Delete(pngFile);
                    progressBar1.Value++;
                }

                progressBar1.Visible = false;
                MessageBox.Show("Remaining PNG files deleted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
