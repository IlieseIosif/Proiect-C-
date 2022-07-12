using System.Windows.Forms;
using System.Drawing;
using System;

namespace InterfataCuUtilizatorul
{
    partial class AfisareCerinte
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
            this.Img1 = new System.Windows.Forms.PictureBox();
            this.LabelCuCuvantulAleator = new System.Windows.Forms.Label();
            this.Img2 = new System.Windows.Forms.PictureBox();
            this.Img3 = new System.Windows.Forms.PictureBox();
            this.ButtonNEXT = new System.Windows.Forms.Button();
            this.LabelCuNumarulCerinteiCurente = new System.Windows.Forms.Label();
            this.ButtonIesire = new System.Windows.Forms.Button();
            this.LabelCuPunctajulCurent = new System.Windows.Forms.Label();
            this.LabelPunctajAfisatLaFinal = new System.Windows.Forms.Label();
            this.ButtonRevizuireRaspunsuri = new System.Windows.Forms.Button();
            this.LabelImagine1 = new System.Windows.Forms.Label();
            this.LabelImagine2 = new System.Windows.Forms.Label();
            this.LabelImagine3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).BeginInit();
            this.SuspendLayout();
            // 
            // Img1
            // 
            this.Img1.BackColor = System.Drawing.Color.White;
            this.Img1.ErrorImage = null;
            this.Img1.Location = new System.Drawing.Point(247, 404);
            this.Img1.Name = "Img1";
            this.Img1.Padding = new System.Windows.Forms.Padding(5);
            this.Img1.Size = new System.Drawing.Size(315, 212);
            this.Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img1.TabIndex = 4;
            this.Img1.TabStop = false;
            this.Img1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img_MouseDown);
            // 
            // LabelCuCuvantulAleator
            // 
            this.LabelCuCuvantulAleator.AutoSize = true;
            this.LabelCuCuvantulAleator.BackColor = System.Drawing.Color.Gainsboro;
            this.LabelCuCuvantulAleator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCuCuvantulAleator.Location = new System.Drawing.Point(320, 254);
            this.LabelCuCuvantulAleator.Name = "LabelCuCuvantulAleator";
            this.LabelCuCuvantulAleator.Size = new System.Drawing.Size(0, 55);
            this.LabelCuCuvantulAleator.TabIndex = 5;
            // 
            // Img2
            // 
            this.Img2.BackColor = System.Drawing.Color.White;
            this.Img2.Location = new System.Drawing.Point(607, 404);
            this.Img2.Name = "Img2";
            this.Img2.Padding = new System.Windows.Forms.Padding(5);
            this.Img2.Size = new System.Drawing.Size(315, 212);
            this.Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img2.TabIndex = 6;
            this.Img2.TabStop = false;
            this.Img2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img_MouseDown);
            // 
            // Img3
            // 
            this.Img3.BackColor = System.Drawing.Color.White;
            this.Img3.Location = new System.Drawing.Point(966, 404);
            this.Img3.Name = "Img3";
            this.Img3.Padding = new System.Windows.Forms.Padding(5);
            this.Img3.Size = new System.Drawing.Size(315, 212);
            this.Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img3.TabIndex = 7;
            this.Img3.TabStop = false;
            this.Img3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img_MouseDown);
            // 
            // ButtonNEXT
            // 
            this.ButtonNEXT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonNEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonNEXT.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonNEXT.Location = new System.Drawing.Point(1408, 773);
            this.ButtonNEXT.Name = "ButtonNEXT";
            this.ButtonNEXT.Size = new System.Drawing.Size(125, 67);
            this.ButtonNEXT.TabIndex = 8;
            this.ButtonNEXT.Text = "NEXT";
            this.ButtonNEXT.UseVisualStyleBackColor = false;
            this.ButtonNEXT.Click += new System.EventHandler(this.ButtonNEXT_Click);
            // 
            // LabelCuNumarulCerinteiCurente
            // 
            this.LabelCuNumarulCerinteiCurente.AutoSize = true;
            this.LabelCuNumarulCerinteiCurente.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCuNumarulCerinteiCurente.Location = new System.Drawing.Point(1627, 17);
            this.LabelCuNumarulCerinteiCurente.Name = "LabelCuNumarulCerinteiCurente";
            this.LabelCuNumarulCerinteiCurente.Size = new System.Drawing.Size(0, 42);
            this.LabelCuNumarulCerinteiCurente.TabIndex = 9;
            // 
            // ButtonIesire
            // 
            this.ButtonIesire.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonIesire.ForeColor = System.Drawing.Color.White;
            this.ButtonIesire.Location = new System.Drawing.Point(1774, 10);
            this.ButtonIesire.Name = "ButtonIesire";
            this.ButtonIesire.Size = new System.Drawing.Size(132, 56);
            this.ButtonIesire.TabIndex = 10;
            this.ButtonIesire.Text = "Ieșire";
            this.ButtonIesire.UseVisualStyleBackColor = false;
            this.ButtonIesire.Click += new System.EventHandler(this.ButtonIesire_Click);
            // 
            // LabelCuPunctajulCurent
            // 
            this.LabelCuPunctajulCurent.AutoSize = true;
            this.LabelCuPunctajulCurent.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCuPunctajulCurent.Location = new System.Drawing.Point(1264, 25);
            this.LabelCuPunctajulCurent.Name = "LabelCuPunctajulCurent";
            this.LabelCuPunctajulCurent.Size = new System.Drawing.Size(0, 33);
            this.LabelCuPunctajulCurent.TabIndex = 11;
            // 
            // LabelPunctajAfisatLaFinal
            // 
            this.LabelPunctajAfisatLaFinal.AutoSize = true;
            this.LabelPunctajAfisatLaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPunctajAfisatLaFinal.Location = new System.Drawing.Point(256, 414);
            this.LabelPunctajAfisatLaFinal.Name = "LabelPunctajAfisatLaFinal";
            this.LabelPunctajAfisatLaFinal.Size = new System.Drawing.Size(611, 120);
            this.LabelPunctajAfisatLaFinal.TabIndex = 12;
            this.LabelPunctajAfisatLaFinal.Text = "Ați  obținut  ";
            this.LabelPunctajAfisatLaFinal.Visible = false;
            // 
            // ButtonRevizuireRaspunsuri
            // 
            this.ButtonRevizuireRaspunsuri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonRevizuireRaspunsuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRevizuireRaspunsuri.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonRevizuireRaspunsuri.Location = new System.Drawing.Point(1011, 773);
            this.ButtonRevizuireRaspunsuri.Name = "ButtonRevizuireRaspunsuri";
            this.ButtonRevizuireRaspunsuri.Size = new System.Drawing.Size(455, 67);
            this.ButtonRevizuireRaspunsuri.TabIndex = 13;
            this.ButtonRevizuireRaspunsuri.Text = "Revizuiește răspunzurile";
            this.ButtonRevizuireRaspunsuri.UseVisualStyleBackColor = false;
            this.ButtonRevizuireRaspunsuri.Visible = false;
            this.ButtonRevizuireRaspunsuri.Click += new System.EventHandler(this.ButtonRevizuireRaspunsuri_Click);
            // 
            // LabelImagine1
            // 
            this.LabelImagine1.AutoSize = true;
            this.LabelImagine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelImagine1.Location = new System.Drawing.Point(349, 637);
            this.LabelImagine1.Name = "LabelImagine1";
            this.LabelImagine1.Size = new System.Drawing.Size(0, 42);
            this.LabelImagine1.TabIndex = 14;
            this.LabelImagine1.Visible = false;
            // 
            // LabelImagine2
            // 
            this.LabelImagine2.AutoSize = true;
            this.LabelImagine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelImagine2.Location = new System.Drawing.Point(702, 637);
            this.LabelImagine2.Name = "LabelImagine2";
            this.LabelImagine2.Size = new System.Drawing.Size(0, 42);
            this.LabelImagine2.TabIndex = 15;
            this.LabelImagine2.Visible = false;
            // 
            // LabelImagine3
            // 
            this.LabelImagine3.AutoSize = true;
            this.LabelImagine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelImagine3.Location = new System.Drawing.Point(1072, 637);
            this.LabelImagine3.Name = "LabelImagine3";
            this.LabelImagine3.Size = new System.Drawing.Size(0, 42);
            this.LabelImagine3.TabIndex = 16;
            this.LabelImagine3.Visible = false;
            // 
            // AfisareCerinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.LabelImagine3);
            this.Controls.Add(this.LabelImagine2);
            this.Controls.Add(this.LabelImagine1);
            this.Controls.Add(this.ButtonRevizuireRaspunsuri);
            this.Controls.Add(this.LabelPunctajAfisatLaFinal);
            this.Controls.Add(this.LabelCuPunctajulCurent);
            this.Controls.Add(this.ButtonIesire);
            this.Controls.Add(this.LabelCuNumarulCerinteiCurente);
            this.Controls.Add(this.ButtonNEXT);
            this.Controls.Add(this.Img3);
            this.Controls.Add(this.Img2);
            this.Controls.Add(this.LabelCuCuvantulAleator);
            this.Controls.Add(this.Img1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfisareCerinte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AfisareCerinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox Img1;
        private Label LabelCuCuvantulAleator;
        private PictureBox Img2;
        private PictureBox Img3;
        private Button ButtonNEXT;
        private Label LabelCuNumarulCerinteiCurente;
        private Button ButtonIesire;
        private Label LabelCuPunctajulCurent;
        private Label LabelPunctajAfisatLaFinal;
        private Button ButtonRevizuireRaspunsuri;
        private Label LabelImagine1;
        private Label LabelImagine2;
        private Label LabelImagine3;
    }
}