/*
 * Romimghelper v1.00
 * Copyright (c) 2024 [Your Name]
 * Licensed under the MIT License. See LICENSE file in the project root for full license information.
 * GitHub: https://github.com/yourusername/romimghelper
 */
namespace romimghelper
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnMovePNGs;
        private System.Windows.Forms.Button btnDeletePNGs;
        private System.Windows.Forms.ProgressBar progressBar1; // Declare progressBar1
        private System.Windows.Forms.Label lblCopyright;

        private void InitializeComponent()
        {
            this.btnMovePNGs = new System.Windows.Forms.Button();
            this.btnDeletePNGs = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar(); // Initialize progressBar1
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMovePNGs
            // 
            this.btnMovePNGs.Location = new System.Drawing.Point(50, 100);
            this.btnMovePNGs.Name = "btnMovePNGs";
            this.btnMovePNGs.Size = new System.Drawing.Size(100, 30);
            this.btnMovePNGs.TabIndex = 0;
            this.btnMovePNGs.Text = "Move PNGs";
            this.btnMovePNGs.UseVisualStyleBackColor = true;
            this.btnMovePNGs.Click += new System.EventHandler(this.btnMovePNGs_Click);
            // 
            // btnDeletePNGs
            // 
            this.btnDeletePNGs.Location = new System.Drawing.Point(200, 100);
            this.btnDeletePNGs.Name = "btnDeletePNGs";
            this.btnDeletePNGs.Size = new System.Drawing.Size(100, 30);
            this.btnDeletePNGs.TabIndex = 1;
            this.btnDeletePNGs.Text = "Delete PNGs";
            this.btnDeletePNGs.UseVisualStyleBackColor = true;
            this.btnDeletePNGs.Click += new System.EventHandler(this.btnDeletePNGs_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 150);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 20);
            this.progressBar1.Visible = false; // Initially hide the progress bar
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCopyright.Location = new System.Drawing.Point(50, 180);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(310, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "© 2024 [XMW-USER]. Licensed under the MIT License.";
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 230);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnDeletePNGs);
            this.Controls.Add(this.btnMovePNGs);
            this.Name = "Form1";
            this.Text = "Romimghelper v1.00";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
