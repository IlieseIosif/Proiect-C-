using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using StocareDate;

namespace InterfataCuUtilizatorul
{
    public partial class Setari : Form
    {
        public enum NumarTotalCerinte:byte
        {
            Implicit=10,
            Personalizat
        }

        public enum AfisarePunctaj:byte
        {
            DoarLaSfarsit=0,
            Intotdeauna=1
        }

        const byte NumarMinimTotalCerinte = 5;
        const byte NumarMaximTotalCerinte = 15;

        private ListaSetari ListaSetari;

        public Setari()
        {
            InitializeComponent();

            ListaSetari = new ListaSetari(ConfigurationManager.AppSettings["NumeFisierStocareSetari"]);

            string sir=ListaSetari.GetSettingsList();

            if(sir != null)
            {
                string[] settings = sir.Split(' ');

                if(byte.Parse(settings[0]) == (byte)NumarTotalCerinte.Implicit)
                {
                    RadioButtonNumarTotalCerinteImplicit.Checked = true;
                }
                else
                {
                    RadioButtonNumarTotalCerintePersonalizat.Checked = true;
                    TextBoxNumarTotalCerintePersonalizat.Text = settings[0];
                }

                if(byte.Parse(settings[1]) == (byte)AfisarePunctaj.DoarLaSfarsit)
                {
                    CheckBoxAfisarePunctajLaSfarsit.Checked = true;
                }
                else
                {
                    CheckBoxAfisarePunctajIntotdeauna.Checked = true;
                }
            }
            else
            {   //cazul in care utilizatorul nu a modificat niciodata setarile
                RadioButtonNumarTotalCerinteImplicit.Checked = true;
                CheckBoxAfisarePunctajIntotdeauna.Checked = true;
            }
        }

        private void TextBoxNumarTotalCerintePersonalizat_Click(object sender, EventArgs e)
        {
            if (RadioButtonNumarTotalCerintePersonalizat.Checked)
            {
                LabelValidareNumarTotalCerintePersonalizat.Text = string.Empty;
                LabelValidareNumarTotalCerintePersonalizat.Visible = true;

                TextBoxNumarTotalCerintePersonalizat.ReadOnly = false;
            }
        }

        private void TextBoxNumarTotalCerintePersonalizat_MouseLeave(object sender, EventArgs e)
        {
            TextBoxNumarTotalCerintePersonalizat.ReadOnly = true;
        }

        private void TextBoxNumarTotalCerintePersonalizat_TextChanged(object sender, EventArgs e)
        {
            string sir = TextBoxNumarTotalCerintePersonalizat.Text;

            bool wrong = false;

            for (int i = 0; i < sir.Length; i++)
                if (sir[i] < '0' || sir[i] > '9')
                {
                    wrong = true;
                    LabelValidareNumarTotalCerintePersonalizat.ForeColor = Color.Red;
                    LabelValidareNumarTotalCerintePersonalizat.Text = "Trebuie să introduceți un număr!";
                    ButtonSalvare.Visible = false;
                    return;
                }

            if (sir.Length > 0 && !wrong)
            {
                if (int.Parse(sir) < NumarMinimTotalCerinte || int.Parse(sir) > NumarMaximTotalCerinte)
                {
                    LabelValidareNumarTotalCerintePersonalizat.ForeColor = Color.Red;
                    LabelValidareNumarTotalCerintePersonalizat.Text = "Numărul introdus trebuie să fie >= " + NumarMinimTotalCerinte + " și <= " + NumarMaximTotalCerinte + "!";
                    ButtonSalvare.Visible = false;
                }
                else
                {
                    LabelValidareNumarTotalCerintePersonalizat.ForeColor = Color.DarkGreen;
                    LabelValidareNumarTotalCerintePersonalizat.Text = "Numărul introdus este corect!";
                    ButtonSalvare.Visible = true;
                }
            }
            else if (sir.Length == 0)
            {
                LabelValidareNumarTotalCerintePersonalizat.Text = "";
                ButtonSalvare.Visible = false;
            }
        }


        private void RadioButtonNumarTotalCerinteImplicit_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonNumarTotalCerinteImplicit.Checked)
            {
                LabelValidareNumarTotalCerintePersonalizat.Visible = false;
                ButtonSalvare.Visible = true;
            }
        }

        private void RadioButtonNumarTotalCerintePersonalizat_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonNumarTotalCerintePersonalizat.Checked)
                ButtonSalvare.Visible = false;      
        }

        private void CheckBoxAfisarePunctajIntotdeauna_CheckedChanged(object sender, EventArgs e)   //cele 2 CheckBox-uri functioneaza ca niste RadioButton-uri
        {
            if (CheckBoxAfisarePunctajIntotdeauna.Checked && CheckBoxAfisarePunctajLaSfarsit.Checked)
            {
                    CheckBoxAfisarePunctajLaSfarsit.Checked = false;
            }
            else if(!CheckBoxAfisarePunctajIntotdeauna.Checked && !CheckBoxAfisarePunctajLaSfarsit.Checked)
            {
                CheckBoxAfisarePunctajIntotdeauna.Checked = true;
            }
        }

        private void CheckBoxAfisarePunctajLaSfarsit_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAfisarePunctajLaSfarsit.Checked && CheckBoxAfisarePunctajIntotdeauna.Checked)
            {
                CheckBoxAfisarePunctajIntotdeauna.Checked = false;
            }
            else if (!CheckBoxAfisarePunctajLaSfarsit.Checked && !CheckBoxAfisarePunctajIntotdeauna.Checked)
            {
                CheckBoxAfisarePunctajLaSfarsit.Checked = true;
            }

        }

        private void Ieșire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSalvare_Click(object sender, EventArgs e)
        {
            byte n1, n2;

            if (RadioButtonNumarTotalCerinteImplicit.Checked)
                n1 = 10;
            else
                n1 = byte.Parse(TextBoxNumarTotalCerintePersonalizat.Text);

            if (CheckBoxAfisarePunctajIntotdeauna.Checked)
                n2 = 1;
            else
                n2 = 0;

            ListaSetari.Save(string.Format("{0} {1}", n1, n2));

            LabelValidareNumarTotalCerintePersonalizat.Text = "";

            MessageBox.Show("Setările au fost salvate!");
        }
    }
}
