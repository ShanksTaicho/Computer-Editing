namespace ComputerEditing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkOfis = new System.Windows.Forms.CheckBox();
            this.chkKisa = new System.Windows.Forms.CheckBox();
            this.ckhSik = new System.Windows.Forms.CheckBox();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.chkProgramlar = new System.Windows.Forms.CheckBox();
            this.chkVideolar = new System.Windows.Forms.CheckBox();
            this.chkMuzikler = new System.Windows.Forms.CheckBox();
            this.chkResimler = new System.Windows.Forms.CheckBox();
            this.chkKlasorler = new System.Windows.Forms.CheckBox();
            this.btnKlasorle = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Folder";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Gold;
            this.txtPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPath.Location = new System.Drawing.Point(87, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(481, 23);
            this.txtPath.TabIndex = 1;
            // 
            // btnFolder
            // 
            this.btnFolder.ForeColor = System.Drawing.Color.Navy;
            this.btnFolder.Location = new System.Drawing.Point(6, 19);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "File";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOfis);
            this.groupBox2.Controls.Add(this.chkKisa);
            this.groupBox2.Controls.Add(this.ckhSik);
            this.groupBox2.Controls.Add(this.chkWeb);
            this.groupBox2.Controls.Add(this.chkProgramlar);
            this.groupBox2.Controls.Add(this.chkVideolar);
            this.groupBox2.Controls.Add(this.chkMuzikler);
            this.groupBox2.Controls.Add(this.chkResimler);
            this.groupBox2.Controls.Add(this.chkKlasorler);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // chkOfis
            // 
            this.chkOfis.AutoSize = true;
            this.chkOfis.Location = new System.Drawing.Point(441, 31);
            this.chkOfis.Name = "chkOfis";
            this.chkOfis.Size = new System.Drawing.Size(123, 20);
            this.chkOfis.TabIndex = 3;
            this.chkOfis.Text = "Office Files";
            this.chkOfis.UseVisualStyleBackColor = true;
            // 
            // chkKisa
            // 
            this.chkKisa.AutoSize = true;
            this.chkKisa.Location = new System.Drawing.Point(441, 54);
            this.chkKisa.Name = "chkKisa";
            this.chkKisa.Size = new System.Drawing.Size(99, 20);
            this.chkKisa.TabIndex = 7;
            this.chkKisa.Text = "Shortcuts";
            this.chkKisa.UseVisualStyleBackColor = true;
            // 
            // ckhSik
            // 
            this.ckhSik.AutoSize = true;
            this.ckhSik.ForeColor = System.Drawing.Color.Yellow;
            this.ckhSik.Location = new System.Drawing.Point(277, 54);
            this.ckhSik.Name = "ckhSik";
            this.ckhSik.Size = new System.Drawing.Size(155, 20);
            this.ckhSik.TabIndex = 6;
            this.ckhSik.Text = "Compressed Files";
            this.ckhSik.UseVisualStyleBackColor = true;
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Location = new System.Drawing.Point(277, 31);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(99, 20);
            this.chkWeb.TabIndex = 2;
            this.chkWeb.Text = "Web Files";
            this.chkWeb.UseVisualStyleBackColor = true;
            // 
            // chkProgramlar
            // 
            this.chkProgramlar.AutoSize = true;
            this.chkProgramlar.Location = new System.Drawing.Point(162, 54);
            this.chkProgramlar.Name = "chkProgramlar";
            this.chkProgramlar.Size = new System.Drawing.Size(91, 20);
            this.chkProgramlar.TabIndex = 5;
            this.chkProgramlar.Text = "Programs";
            this.chkProgramlar.UseVisualStyleBackColor = true;
            // 
            // chkVideolar
            // 
            this.chkVideolar.AutoSize = true;
            this.chkVideolar.Location = new System.Drawing.Point(162, 31);
            this.chkVideolar.Name = "chkVideolar";
            this.chkVideolar.Size = new System.Drawing.Size(75, 20);
            this.chkVideolar.TabIndex = 1;
            this.chkVideolar.Text = "Videos";
            this.chkVideolar.UseVisualStyleBackColor = true;
            // 
            // chkMuzikler
            // 
            this.chkMuzikler.AutoSize = true;
            this.chkMuzikler.Location = new System.Drawing.Point(44, 31);
            this.chkMuzikler.Name = "chkMuzikler";
            this.chkMuzikler.Size = new System.Drawing.Size(75, 20);
            this.chkMuzikler.TabIndex = 0;
            this.chkMuzikler.Text = "Musics";
            this.chkMuzikler.UseVisualStyleBackColor = true;
            // 
            // chkResimler
            // 
            this.chkResimler.AutoSize = true;
            this.chkResimler.Location = new System.Drawing.Point(44, 54);
            this.chkResimler.Name = "chkResimler";
            this.chkResimler.Size = new System.Drawing.Size(91, 20);
            this.chkResimler.TabIndex = 4;
            this.chkResimler.Text = "Pictures";
            this.chkResimler.UseVisualStyleBackColor = true;
            // 
            // chkKlasorler
            // 
            this.chkKlasorler.AutoSize = true;
            this.chkKlasorler.Location = new System.Drawing.Point(44, 77);
            this.chkKlasorler.Name = "chkKlasorler";
            this.chkKlasorler.Size = new System.Drawing.Size(83, 20);
            this.chkKlasorler.TabIndex = 8;
            this.chkKlasorler.Text = "Folders";
            this.chkKlasorler.UseVisualStyleBackColor = true;
            // 
            // btnKlasorle
            // 
            this.btnKlasorle.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlasorle.ForeColor = System.Drawing.Color.Blue;
            this.btnKlasorle.Location = new System.Drawing.Point(492, 189);
            this.btnKlasorle.Name = "btnKlasorle";
            this.btnKlasorle.Size = new System.Drawing.Size(94, 46);
            this.btnKlasorle.TabIndex = 2;
            this.btnKlasorle.Text = "Edit";
            this.btnKlasorle.UseVisualStyleBackColor = true;
            this.btnKlasorle.Click += new System.EventHandler(this.btnKlasorle_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(15, 206);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ShanksTaicho Utopian.io";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(598, 243);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnKlasorle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Editing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkOfis;
        private System.Windows.Forms.CheckBox chkKisa;
        private System.Windows.Forms.CheckBox ckhSik;
        private System.Windows.Forms.CheckBox chkWeb;
        private System.Windows.Forms.CheckBox chkProgramlar;
        private System.Windows.Forms.CheckBox chkVideolar;
        private System.Windows.Forms.CheckBox chkMuzikler;
        private System.Windows.Forms.CheckBox chkResimler;
        private System.Windows.Forms.CheckBox chkKlasorler;
        private System.Windows.Forms.Button btnKlasorle;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

