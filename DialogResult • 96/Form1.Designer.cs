﻿namespace DialogResult___96
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
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.rtbMesaj = new System.Windows.Forms.RichTextBox();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(13, 77);
            this.pbResim.Margin = new System.Windows.Forms.Padding(4);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(271, 247);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 7;
            this.pbResim.TabStop = false;
            // 
            // rtbMesaj
            // 
            this.rtbMesaj.Location = new System.Drawing.Point(342, 77);
            this.rtbMesaj.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMesaj.Name = "rtbMesaj";
            this.rtbMesaj.Size = new System.Drawing.Size(271, 247);
            this.rtbMesaj.TabIndex = 6;
            this.rtbMesaj.Text = "Yezda\nRavza\nNursevim\nHilal";
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(342, 27);
            this.btnRenk.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(271, 42);
            this.btnRenk.TabIndex = 5;
            this.btnRenk.Text = "Renk Seç";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(13, 27);
            this.btnResim.Margin = new System.Windows.Forms.Padding(4);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(271, 42);
            this.btnResim.TabIndex = 4;
            this.btnResim.Text = "Resim Seç";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Resim Dosyaları |*.jpg;*.png;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 361);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.rtbMesaj);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnResim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.RichTextBox rtbMesaj;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

