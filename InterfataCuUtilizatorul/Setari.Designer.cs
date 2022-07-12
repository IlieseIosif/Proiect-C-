using System.Windows.Forms;
using StocareDate;

namespace InterfataCuUtilizatorul
{
    partial class Setari
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
            this.RadioButtonNumarTotalCerinteImplicit = new System.Windows.Forms.RadioButton();
            this.RadioButtonNumarTotalCerintePersonalizat = new System.Windows.Forms.RadioButton();
            this.PanouSetareNumarTotalCerinte = new System.Windows.Forms.Panel();
            this.LabelNumarCerinteImplicit = new System.Windows.Forms.Label();
            this.TextBoxNumarTotalCerintePersonalizat = new System.Windows.Forms.TextBox();
            this.LabelValidareNumarTotalCerintePersonalizat = new System.Windows.Forms.Label();
            this.LabelSetareNumarCerinte = new System.Windows.Forms.Label();
            this.LabelAfisarePunctaj = new System.Windows.Forms.Label();
            this.CheckBoxAfisarePunctajIntotdeauna = new System.Windows.Forms.CheckBox();
            this.CheckBoxAfisarePunctajLaSfarsit = new System.Windows.Forms.CheckBox();
            this.ButtonSalvare = new System.Windows.Forms.Button();
            this.Ieșire = new System.Windows.Forms.Button();
            this.PanouSetareNumarTotalCerinte.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButtonNumarTotalCerinteImplicit
            // 
            this.RadioButtonNumarTotalCerinteImplicit.AutoSize = true;
            this.RadioButtonNumarTotalCerinteImplicit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonNumarTotalCerinteImplicit.Location = new System.Drawing.Point(20, 14);
            this.RadioButtonNumarTotalCerinteImplicit.Name = "RadioButtonNumarTotalCerinteImplicit";
            this.RadioButtonNumarTotalCerinteImplicit.Size = new System.Drawing.Size(145, 43);
            this.RadioButtonNumarTotalCerinteImplicit.TabIndex = 0;
            this.RadioButtonNumarTotalCerinteImplicit.TabStop = true;
            this.RadioButtonNumarTotalCerinteImplicit.Text = "Implicit";
            this.RadioButtonNumarTotalCerinteImplicit.UseVisualStyleBackColor = true;
            this.RadioButtonNumarTotalCerinteImplicit.CheckedChanged += new System.EventHandler(this.RadioButtonNumarTotalCerinteImplicit_CheckedChanged);
            // 
            // RadioButtonNumarTotalCerintePersonalizat
            // 
            this.RadioButtonNumarTotalCerintePersonalizat.AutoSize = true;
            this.RadioButtonNumarTotalCerintePersonalizat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonNumarTotalCerintePersonalizat.Location = new System.Drawing.Point(20, 68);
            this.RadioButtonNumarTotalCerintePersonalizat.Name = "RadioButtonNumarTotalCerintePersonalizat";
            this.RadioButtonNumarTotalCerintePersonalizat.Size = new System.Drawing.Size(227, 43);
            this.RadioButtonNumarTotalCerintePersonalizat.TabIndex = 1;
            this.RadioButtonNumarTotalCerintePersonalizat.TabStop = true;
            this.RadioButtonNumarTotalCerintePersonalizat.Text = "Personalizat";
            this.RadioButtonNumarTotalCerintePersonalizat.UseVisualStyleBackColor = true;
            this.RadioButtonNumarTotalCerintePersonalizat.CheckedChanged += new System.EventHandler(this.RadioButtonNumarTotalCerintePersonalizat_CheckedChanged);
            // 
            // PanouSetareNumarTotalCerinte
            // 
            this.PanouSetareNumarTotalCerinte.Controls.Add(this.RadioButtonNumarTotalCerinteImplicit);
            this.PanouSetareNumarTotalCerinte.Controls.Add(this.RadioButtonNumarTotalCerintePersonalizat);
            this.PanouSetareNumarTotalCerinte.Location = new System.Drawing.Point(52, 144);
            this.PanouSetareNumarTotalCerinte.Name = "PanouSetareNumarTotalCerinte";
            this.PanouSetareNumarTotalCerinte.Size = new System.Drawing.Size(272, 127);
            this.PanouSetareNumarTotalCerinte.TabIndex = 2;
            // 
            // LabelNumarCerinteImplicit
            // 
            this.LabelNumarCerinteImplicit.AutoSize = true;
            this.LabelNumarCerinteImplicit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNumarCerinteImplicit.Location = new System.Drawing.Point(347, 160);
            this.LabelNumarCerinteImplicit.Name = "LabelNumarCerinteImplicit";
            this.LabelNumarCerinteImplicit.Size = new System.Drawing.Size(55, 39);
            this.LabelNumarCerinteImplicit.TabIndex = 3;
            this.LabelNumarCerinteImplicit.Text = "10";
            // 
            // TextBoxNumarTotalCerintePersonalizat
            // 
            this.TextBoxNumarTotalCerintePersonalizat.BackColor = System.Drawing.Color.White;
            this.TextBoxNumarTotalCerintePersonalizat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNumarTotalCerintePersonalizat.Location = new System.Drawing.Point(345, 211);
            this.TextBoxNumarTotalCerintePersonalizat.Name = "TextBoxNumarTotalCerintePersonalizat";
            this.TextBoxNumarTotalCerintePersonalizat.ReadOnly = true;
            this.TextBoxNumarTotalCerintePersonalizat.Size = new System.Drawing.Size(57, 47);
            this.TextBoxNumarTotalCerintePersonalizat.TabIndex = 4;
            this.TextBoxNumarTotalCerintePersonalizat.Click += new System.EventHandler(this.TextBoxNumarTotalCerintePersonalizat_Click);
            this.TextBoxNumarTotalCerintePersonalizat.TextChanged += new System.EventHandler(this.TextBoxNumarTotalCerintePersonalizat_TextChanged);
            this.TextBoxNumarTotalCerintePersonalizat.MouseLeave += new System.EventHandler(this.TextBoxNumarTotalCerintePersonalizat_MouseLeave);
            // 
            // LabelValidareNumarTotalCerintePersonalizat
            // 
            this.LabelValidareNumarTotalCerintePersonalizat.AutoSize = true;
            this.LabelValidareNumarTotalCerintePersonalizat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelValidareNumarTotalCerintePersonalizat.Location = new System.Drawing.Point(428, 219);
            this.LabelValidareNumarTotalCerintePersonalizat.Name = "LabelValidareNumarTotalCerintePersonalizat";
            this.LabelValidareNumarTotalCerintePersonalizat.Size = new System.Drawing.Size(0, 39);
            this.LabelValidareNumarTotalCerintePersonalizat.TabIndex = 5;
            this.LabelValidareNumarTotalCerintePersonalizat.Visible = false;
            // 
            // LabelSetareNumarCerinte
            // 
            this.LabelSetareNumarCerinte.AutoSize = true;
            this.LabelSetareNumarCerinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSetareNumarCerinte.Location = new System.Drawing.Point(45, 84);
            this.LabelSetareNumarCerinte.Name = "LabelSetareNumarCerinte";
            this.LabelSetareNumarCerinte.Size = new System.Drawing.Size(495, 39);
            this.LabelSetareNumarCerinte.TabIndex = 6;
            this.LabelSetareNumarCerinte.Text = "Selectează numărul de cerințe:";
            // 
            // LabelAfisarePunctaj
            // 
            this.LabelAfisarePunctaj.AutoSize = true;
            this.LabelAfisarePunctaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAfisarePunctaj.Location = new System.Drawing.Point(45, 377);
            this.LabelAfisarePunctaj.Name = "LabelAfisarePunctaj";
            this.LabelAfisarePunctaj.Size = new System.Drawing.Size(356, 39);
            this.LabelAfisarePunctaj.TabIndex = 7;
            this.LabelAfisarePunctaj.Text = "Se afișează punctajul:";
            // 
            // CheckBoxAfisarePunctajIntotdeauna
            // 
            this.CheckBoxAfisarePunctajIntotdeauna.AutoSize = true;
            this.CheckBoxAfisarePunctajIntotdeauna.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxAfisarePunctajIntotdeauna.Location = new System.Drawing.Point(411, 376);
            this.CheckBoxAfisarePunctajIntotdeauna.Name = "CheckBoxAfisarePunctajIntotdeauna";
            this.CheckBoxAfisarePunctajIntotdeauna.Size = new System.Drawing.Size(217, 43);
            this.CheckBoxAfisarePunctajIntotdeauna.TabIndex = 8;
            this.CheckBoxAfisarePunctajIntotdeauna.Text = "Întotdeauna";
            this.CheckBoxAfisarePunctajIntotdeauna.UseVisualStyleBackColor = true;
            this.CheckBoxAfisarePunctajIntotdeauna.CheckedChanged += new System.EventHandler(this.CheckBoxAfisarePunctajIntotdeauna_CheckedChanged);
            // 
            // CheckBoxAfisarePunctajLaSfarsit
            // 
            this.CheckBoxAfisarePunctajLaSfarsit.AutoSize = true;
            this.CheckBoxAfisarePunctajLaSfarsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxAfisarePunctajLaSfarsit.Location = new System.Drawing.Point(411, 425);
            this.CheckBoxAfisarePunctajLaSfarsit.Name = "CheckBoxAfisarePunctajLaSfarsit";
            this.CheckBoxAfisarePunctajLaSfarsit.Size = new System.Drawing.Size(251, 43);
            this.CheckBoxAfisarePunctajLaSfarsit.TabIndex = 9;
            this.CheckBoxAfisarePunctajLaSfarsit.Text = "Doar la sfârșit";
            this.CheckBoxAfisarePunctajLaSfarsit.UseVisualStyleBackColor = true;
            this.CheckBoxAfisarePunctajLaSfarsit.CheckedChanged += new System.EventHandler(this.CheckBoxAfisarePunctajLaSfarsit_CheckedChanged);
            // 
            // ButtonSalvare
            // 
            this.ButtonSalvare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSalvare.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonSalvare.Location = new System.Drawing.Point(508, 736);
            this.ButtonSalvare.Name = "ButtonSalvare";
            this.ButtonSalvare.Size = new System.Drawing.Size(154, 54);
            this.ButtonSalvare.TabIndex = 10;
            this.ButtonSalvare.Text = "Salvare";
            this.ButtonSalvare.UseVisualStyleBackColor = false;
            this.ButtonSalvare.Visible = false;
            this.ButtonSalvare.Click += new System.EventHandler(this.ButtonSalvare_Click);
            // 
            // Ieșire
            // 
            this.Ieșire.BackColor = System.Drawing.Color.OrangeRed;
            this.Ieșire.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ieșire.ForeColor = System.Drawing.Color.White;
            this.Ieșire.Location = new System.Drawing.Point(1758, 12);
            this.Ieșire.Name = "Ieșire";
            this.Ieșire.Size = new System.Drawing.Size(128, 61);
            this.Ieșire.TabIndex = 11;
            this.Ieșire.Text = "Ieșire";
            this.Ieșire.UseVisualStyleBackColor = false;
            this.Ieșire.Click += new System.EventHandler(this.Ieșire_Click);
            // 
            // Setari
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 924);
            this.Controls.Add(this.Ieșire);
            this.Controls.Add(this.ButtonSalvare);
            this.Controls.Add(this.CheckBoxAfisarePunctajLaSfarsit);
            this.Controls.Add(this.CheckBoxAfisarePunctajIntotdeauna);
            this.Controls.Add(this.LabelAfisarePunctaj);
            this.Controls.Add(this.LabelSetareNumarCerinte);
            this.Controls.Add(this.LabelValidareNumarTotalCerintePersonalizat);
            this.Controls.Add(this.TextBoxNumarTotalCerintePersonalizat);
            this.Controls.Add(this.LabelNumarCerinteImplicit);
            this.Controls.Add(this.PanouSetareNumarTotalCerinte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setari";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanouSetareNumarTotalCerinte.ResumeLayout(false);
            this.PanouSetareNumarTotalCerinte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton RadioButtonNumarTotalCerinteImplicit;
        private RadioButton RadioButtonNumarTotalCerintePersonalizat;
        private Panel PanouSetareNumarTotalCerinte;
        private Label LabelNumarCerinteImplicit;
        private TextBox TextBoxNumarTotalCerintePersonalizat;
        private Label LabelValidareNumarTotalCerintePersonalizat;
        private Label LabelSetareNumarCerinte;
        private Label LabelAfisarePunctaj;
        private CheckBox CheckBoxAfisarePunctajIntotdeauna;
        private CheckBox CheckBoxAfisarePunctajLaSfarsit;
        private Button ButtonSalvare;
        private Button Ieșire;
    }
}