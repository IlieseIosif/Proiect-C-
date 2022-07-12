
namespace InterfataCuUtilizatorul
{
    partial class AdaugaSterge
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
            this.ButtonAdaugareStergereCuvinte = new System.Windows.Forms.Button();
            this.ButtonAdaugareStergereImagini = new System.Windows.Forms.Button();
            this.ButonIesire = new System.Windows.Forms.Button();
            this.ButtonInapoi = new System.Windows.Forms.Button();
            this.ListBoxCuToateCuvintele = new System.Windows.Forms.ListBox();
            this.LabelListBoxCuToateCuvintele = new System.Windows.Forms.Label();
            this.LabelTextBoxIntroducereCuvant = new System.Windows.Forms.Label();
            this.TextBoxIntroducereCuvant = new System.Windows.Forms.TextBox();
            this.ButtonAdaugaCuvant = new System.Windows.Forms.Button();
            this.ButtonStergeCuvinteSelectate = new System.Windows.Forms.Button();
            this.PanelCuToateImaginile = new System.Windows.Forms.Panel();
            this.ButtonAdaugaImagini = new System.Windows.Forms.Button();
            this.ButtonStergeImaginiSelectate = new System.Windows.Forms.Button();
            this.SelectImagesToAddDialog = new System.Windows.Forms.OpenFileDialog();
            this.LabelListaVidaDeImagini = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAdaugareStergereCuvinte
            // 
            this.ButtonAdaugareStergereCuvinte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAdaugareStergereCuvinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdaugareStergereCuvinte.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonAdaugareStergereCuvinte.Location = new System.Drawing.Point(322, 365);
            this.ButtonAdaugareStergereCuvinte.Name = "ButtonAdaugareStergereCuvinte";
            this.ButtonAdaugareStergereCuvinte.Size = new System.Drawing.Size(478, 242);
            this.ButtonAdaugareStergereCuvinte.TabIndex = 0;
            this.ButtonAdaugareStergereCuvinte.Text = "adăugare / ștergere cuvinte";
            this.ButtonAdaugareStergereCuvinte.UseVisualStyleBackColor = true;
            this.ButtonAdaugareStergereCuvinte.Click += new System.EventHandler(this.Button_Click);
            // 
            // ButtonAdaugareStergereImagini
            // 
            this.ButtonAdaugareStergereImagini.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAdaugareStergereImagini.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdaugareStergereImagini.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonAdaugareStergereImagini.Location = new System.Drawing.Point(1099, 365);
            this.ButtonAdaugareStergereImagini.Name = "ButtonAdaugareStergereImagini";
            this.ButtonAdaugareStergereImagini.Size = new System.Drawing.Size(478, 242);
            this.ButtonAdaugareStergereImagini.TabIndex = 1;
            this.ButtonAdaugareStergereImagini.Text = "adăugare / ștergere imagini";
            this.ButtonAdaugareStergereImagini.UseVisualStyleBackColor = true;
            this.ButtonAdaugareStergereImagini.Click += new System.EventHandler(this.Button_Click);
            // 
            // ButonIesire
            // 
            this.ButonIesire.BackColor = System.Drawing.Color.OrangeRed;
            this.ButonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButonIesire.ForeColor = System.Drawing.Color.White;
            this.ButonIesire.Location = new System.Drawing.Point(1758, 12);
            this.ButonIesire.Name = "ButonIesire";
            this.ButonIesire.Size = new System.Drawing.Size(132, 56);
            this.ButonIesire.TabIndex = 12;
            this.ButonIesire.Text = "Ieșire";
            this.ButonIesire.UseVisualStyleBackColor = false;
            this.ButonIesire.Click += new System.EventHandler(this.ButonIesire_Click);
            // 
            // ButtonInapoi
            // 
            this.ButtonInapoi.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonInapoi.ForeColor = System.Drawing.Color.White;
            this.ButtonInapoi.Location = new System.Drawing.Point(1620, 12);
            this.ButtonInapoi.Name = "ButtonInapoi";
            this.ButtonInapoi.Size = new System.Drawing.Size(132, 56);
            this.ButtonInapoi.TabIndex = 13;
            this.ButtonInapoi.Text = "Înapoi";
            this.ButtonInapoi.UseVisualStyleBackColor = false;
            this.ButtonInapoi.Click += new System.EventHandler(this.ButtonInapoi_Click);
            // 
            // ListBoxCuToateCuvintele
            // 
            this.ListBoxCuToateCuvintele.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBoxCuToateCuvintele.FormattingEnabled = true;
            this.ListBoxCuToateCuvintele.HorizontalScrollbar = true;
            this.ListBoxCuToateCuvintele.ItemHeight = 31;
            this.ListBoxCuToateCuvintele.Location = new System.Drawing.Point(1332, 432);
            this.ListBoxCuToateCuvintele.Name = "ListBoxCuToateCuvintele";
            this.ListBoxCuToateCuvintele.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxCuToateCuvintele.Size = new System.Drawing.Size(483, 469);
            this.ListBoxCuToateCuvintele.TabIndex = 14;
            // 
            // LabelListBoxCuToateCuvintele
            // 
            this.LabelListBoxCuToateCuvintele.AutoSize = true;
            this.LabelListBoxCuToateCuvintele.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelListBoxCuToateCuvintele.Location = new System.Drawing.Point(1325, 354);
            this.LabelListBoxCuToateCuvintele.Name = "LabelListBoxCuToateCuvintele";
            this.LabelListBoxCuToateCuvintele.Size = new System.Drawing.Size(344, 42);
            this.LabelListBoxCuToateCuvintele.TabIndex = 15;
            this.LabelListBoxCuToateCuvintele.Text = "Cuvintele existente:";
            // 
            // LabelTextBoxIntroducereCuvant
            // 
            this.LabelTextBoxIntroducereCuvant.AutoSize = true;
            this.LabelTextBoxIntroducereCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTextBoxIntroducereCuvant.Location = new System.Drawing.Point(24, 172);
            this.LabelTextBoxIntroducereCuvant.Name = "LabelTextBoxIntroducereCuvant";
            this.LabelTextBoxIntroducereCuvant.Size = new System.Drawing.Size(749, 42);
            this.LabelTextBoxIntroducereCuvant.TabIndex = 16;
            this.LabelTextBoxIntroducereCuvant.Text = "Introdu cuvântul pe care dorești să îl adaugi:";
            // 
            // TextBoxIntroducereCuvant
            // 
            this.TextBoxIntroducereCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxIntroducereCuvant.Location = new System.Drawing.Point(805, 172);
            this.TextBoxIntroducereCuvant.Name = "TextBoxIntroducereCuvant";
            this.TextBoxIntroducereCuvant.Size = new System.Drawing.Size(425, 49);
            this.TextBoxIntroducereCuvant.TabIndex = 17;
            this.TextBoxIntroducereCuvant.TextChanged += new System.EventHandler(this.TextBoxIntroducereCuvant_TextChanged);
            // 
            // ButtonAdaugaCuvant
            // 
            this.ButtonAdaugaCuvant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAdaugaCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdaugaCuvant.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonAdaugaCuvant.Location = new System.Drawing.Point(31, 239);
            this.ButtonAdaugaCuvant.Name = "ButtonAdaugaCuvant";
            this.ButtonAdaugaCuvant.Size = new System.Drawing.Size(245, 59);
            this.ButtonAdaugaCuvant.TabIndex = 18;
            this.ButtonAdaugaCuvant.Text = "Adaugă cuvântul";
            this.ButtonAdaugaCuvant.UseVisualStyleBackColor = false;
            this.ButtonAdaugaCuvant.Click += new System.EventHandler(this.ButtonAdaugaCuvant_Click);
            // 
            // ButtonStergeCuvinteSelectate
            // 
            this.ButtonStergeCuvinteSelectate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonStergeCuvinteSelectate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStergeCuvinteSelectate.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonStergeCuvinteSelectate.Location = new System.Drawing.Point(1332, 953);
            this.ButtonStergeCuvinteSelectate.Name = "ButtonStergeCuvinteSelectate";
            this.ButtonStergeCuvinteSelectate.Size = new System.Drawing.Size(373, 59);
            this.ButtonStergeCuvinteSelectate.TabIndex = 19;
            this.ButtonStergeCuvinteSelectate.Text = "Șterge cuvintele selectate";
            this.ButtonStergeCuvinteSelectate.UseVisualStyleBackColor = true;
            this.ButtonStergeCuvinteSelectate.Click += new System.EventHandler(this.ButtonStergeCuvinteSelectate_Click);
            // 
            // PanelCuToateImaginile
            // 
            this.PanelCuToateImaginile.AutoScroll = true;
            this.PanelCuToateImaginile.BackColor = System.Drawing.Color.White;
            this.PanelCuToateImaginile.Location = new System.Drawing.Point(227, 156);
            this.PanelCuToateImaginile.Name = "PanelCuToateImaginile";
            this.PanelCuToateImaginile.Size = new System.Drawing.Size(1353, 775);
            this.PanelCuToateImaginile.TabIndex = 20;
            // 
            // ButtonAdaugaImagini
            // 
            this.ButtonAdaugaImagini.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAdaugaImagini.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdaugaImagini.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonAdaugaImagini.Location = new System.Drawing.Point(12, 12);
            this.ButtonAdaugaImagini.Name = "ButtonAdaugaImagini";
            this.ButtonAdaugaImagini.Size = new System.Drawing.Size(288, 58);
            this.ButtonAdaugaImagini.TabIndex = 21;
            this.ButtonAdaugaImagini.Text = "Adaugă imagini";
            this.ButtonAdaugaImagini.UseVisualStyleBackColor = false;
            this.ButtonAdaugaImagini.Click += new System.EventHandler(this.ButtonAdaugaImagini_Click);
            // 
            // ButtonStergeImaginiSelectate
            // 
            this.ButtonStergeImaginiSelectate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonStergeImaginiSelectate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStergeImaginiSelectate.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonStergeImaginiSelectate.Location = new System.Drawing.Point(227, 954);
            this.ButtonStergeImaginiSelectate.Name = "ButtonStergeImaginiSelectate";
            this.ButtonStergeImaginiSelectate.Size = new System.Drawing.Size(466, 58);
            this.ButtonStergeImaginiSelectate.TabIndex = 22;
            this.ButtonStergeImaginiSelectate.Text = "Șterge imaginile selectate";
            this.ButtonStergeImaginiSelectate.UseVisualStyleBackColor = false;
            this.ButtonStergeImaginiSelectate.Click += new System.EventHandler(this.ButtonStergereImaginiSelectate_Click);
            // 
            // SelectImagesToAddDialog
            // 
            this.SelectImagesToAddDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            this.SelectImagesToAddDialog.Multiselect = true;
            this.SelectImagesToAddDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SelectImagesToAddDialog_FileOk);
            // 
            // LabelListaVidaDeImagini
            // 
            this.LabelListaVidaDeImagini.AutoSize = true;
            this.LabelListaVidaDeImagini.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelListaVidaDeImagini.Location = new System.Drawing.Point(231, 962);
            this.LabelListaVidaDeImagini.Name = "LabelListaVidaDeImagini";
            this.LabelListaVidaDeImagini.Size = new System.Drawing.Size(706, 42);
            this.LabelListaVidaDeImagini.TabIndex = 0;
            this.LabelListaVidaDeImagini.Text = "Lista de imagini nu conține nici o imagine!";
            // 
            // AdaugaSterge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.LabelListaVidaDeImagini);
            this.Controls.Add(this.ButtonStergeImaginiSelectate);
            this.Controls.Add(this.ButtonAdaugaImagini);
            this.Controls.Add(this.PanelCuToateImaginile);
            this.Controls.Add(this.ButtonStergeCuvinteSelectate);
            this.Controls.Add(this.ButtonAdaugaCuvant);
            this.Controls.Add(this.TextBoxIntroducereCuvant);
            this.Controls.Add(this.LabelTextBoxIntroducereCuvant);
            this.Controls.Add(this.LabelListBoxCuToateCuvintele);
            this.Controls.Add(this.ListBoxCuToateCuvintele);
            this.Controls.Add(this.ButtonInapoi);
            this.Controls.Add(this.ButonIesire);
            this.Controls.Add(this.ButtonAdaugareStergereImagini);
            this.Controls.Add(this.ButtonAdaugareStergereCuvinte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdaugaSterge";
            this.Text = "AdaugaSterge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdaugaSterge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdaugareStergereCuvinte;
        private System.Windows.Forms.Button ButtonAdaugareStergereImagini;
        private System.Windows.Forms.Button ButonIesire;
        private System.Windows.Forms.Button ButtonInapoi;
        private System.Windows.Forms.ListBox ListBoxCuToateCuvintele;
        private System.Windows.Forms.Label LabelListBoxCuToateCuvintele;
        private System.Windows.Forms.Label LabelTextBoxIntroducereCuvant;
        private System.Windows.Forms.TextBox TextBoxIntroducereCuvant;
        private System.Windows.Forms.Button ButtonAdaugaCuvant;
        private System.Windows.Forms.Button ButtonStergeCuvinteSelectate;
        private System.Windows.Forms.Panel PanelCuToateImaginile;
        private System.Windows.Forms.Button ButtonAdaugaImagini;
        private System.Windows.Forms.Button ButtonStergeImaginiSelectate;
        private System.Windows.Forms.OpenFileDialog SelectImagesToAddDialog;
        private System.Windows.Forms.Label LabelListaVidaDeImagini;
    }
}