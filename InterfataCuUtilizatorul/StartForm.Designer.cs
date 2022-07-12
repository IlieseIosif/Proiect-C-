using System.Windows.Forms;

namespace InterfataCuUtilizatorul
{
    public partial class StartForm:Form
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
            this.ButtonStartJoc = new System.Windows.Forms.Button();
            this.ButtonAdaugaSterge = new System.Windows.Forms.Button();
            this.Setări = new System.Windows.Forms.Button();
            this.Ieșire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStartJoc
            // 
            this.ButtonStartJoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonStartJoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStartJoc.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonStartJoc.Location = new System.Drawing.Point(871, 327);
            this.ButtonStartJoc.Name = "ButtonStartJoc";
            this.ButtonStartJoc.Size = new System.Drawing.Size(210, 80);
            this.ButtonStartJoc.TabIndex = 0;
            this.ButtonStartJoc.Text = "Start joc";
            this.ButtonStartJoc.UseVisualStyleBackColor = false;
            this.ButtonStartJoc.Click += new System.EventHandler(this.ButtonStartJoc_Click);
            // 
            // ButtonAdaugaSterge
            // 
            this.ButtonAdaugaSterge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAdaugaSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdaugaSterge.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonAdaugaSterge.Location = new System.Drawing.Point(825, 461);
            this.ButtonAdaugaSterge.Name = "ButtonAdaugaSterge";
            this.ButtonAdaugaSterge.Size = new System.Drawing.Size(298, 80);
            this.ButtonAdaugaSterge.TabIndex = 1;
            this.ButtonAdaugaSterge.Text = "Adaugă / Șterge";
            this.ButtonAdaugaSterge.UseVisualStyleBackColor = false;
            this.ButtonAdaugaSterge.Click += new System.EventHandler(this.ButtonAdaugaSterge_Click);
            // 
            // Setări
            // 
            this.Setări.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Setări.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Setări.ForeColor = System.Drawing.Color.DarkGreen;
            this.Setări.Location = new System.Drawing.Point(871, 596);
            this.Setări.Name = "Setări";
            this.Setări.Size = new System.Drawing.Size(210, 80);
            this.Setări.TabIndex = 2;
            this.Setări.Text = "Setări";
            this.Setări.UseVisualStyleBackColor = false;
            this.Setări.Click += new System.EventHandler(this.Setări_Click);
            // 
            // Ieșire
            // 
            this.Ieșire.BackColor = System.Drawing.Color.OrangeRed;
            this.Ieșire.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ieșire.ForeColor = System.Drawing.Color.White;
            this.Ieșire.Location = new System.Drawing.Point(1743, 12);
            this.Ieșire.Name = "Ieșire";
            this.Ieșire.Size = new System.Drawing.Size(144, 64);
            this.Ieșire.TabIndex = 9;
            this.Ieșire.Text = "Ieșire";
            this.Ieșire.UseVisualStyleBackColor = false;
            this.Ieșire.Click += new System.EventHandler(this.Ieșire_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1899, 1034);
            this.Controls.Add(this.Ieșire);
            this.Controls.Add(this.Setări);
            this.Controls.Add(this.ButtonAdaugaSterge);
            this.Controls.Add(this.ButtonStartJoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonStartJoc;
        private Button ButtonAdaugaSterge;
        private Button Setări;
        private Button Ieșire;
    }
}