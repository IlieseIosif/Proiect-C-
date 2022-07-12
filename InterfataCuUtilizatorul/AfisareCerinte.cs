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
using Librarie;
using StocareDate;

namespace InterfataCuUtilizatorul
{
    public partial class AfisareCerinte : Form
    {
        ListaSetari ListaSetari;
        Cerinta Cerinta;

        List<PictureBox> Imagini;
        List<Label> LabeluriAsociateImaginilor;

        const int NumarMinimCuvinte = 4;
        const int NumarMinimImagini = 12;

        int aCataCerinta = 0;
        int NumarTotalCerinte=10;
        Color CuloareChenarImagineSelectata = Color.DarkRed;

        List<string> ListaCuvinteAfisate;
        List<string[]> ListaImaginiDeSelectat;
        List<int> ListaImaginiSelectate;

        float punctaj = 0;

        public AfisareCerinte()
        {
            string NumeFisierCuCuvinte = ConfigurationManager.AppSettings["NumeFisierCuCuvinte"];
            string NumeFisieruImagini = ConfigurationManager.AppSettings["NumeFisierCuImagini"];
            string NumeFisierStocareSetari = ConfigurationManager.AppSettings["NumeFisierStocareSetari"];

            Cerinta = new Cerinta(NumeFisierCuCuvinte, NumeFisieruImagini);
            ListaSetari = new ListaSetari(NumeFisierStocareSetari);

            InitializeComponent();
            ButtonRevizuireRaspunsuri.Click += RevizuireCerintaCurenta;

            Imagini = new List<PictureBox>();
            Imagini.AddRange(new PictureBox[] { Img1, Img2, Img3 });

            LabeluriAsociateImaginilor = new List<Label>();
            LabeluriAsociateImaginilor.AddRange(new Label[] { LabelImagine1, LabelImagine2, LabelImagine3 });

            string sir = ListaSetari.GetSettingsList();

            if (sir != null)
            {
                string[] settings = sir.Split(' ');

                if (byte.Parse(settings[0]) != (byte)Setari.NumarTotalCerinte.Implicit)
                    NumarTotalCerinte = int.Parse(settings[0]);

                if (byte.Parse(settings[1]) == (byte)Setari.AfisarePunctaj.Intotdeauna)//afisare punctaj intotdeauna
                    LabelCuPunctajulCurent.Visible = true;
                else
                    LabelCuPunctajulCurent.Visible = false;
            }

            ListaCuvinteAfisate = new List<string>();
            ListaImaginiDeSelectat = new List<string[]>();
            ListaImaginiSelectate = new List<int>();
        }

        private void UpdateControlsWithRandomValues()
        {
            LabelCuPunctajulCurent.Text = string.Format("Punctaj: {0:##0.00} \\ 100,00", punctaj);
            LabelCuNumarulCerinteiCurente.Text = (aCataCerinta + 1) + "\\" + NumarTotalCerinte;

            LabelCuCuvantulAleator.Text = String.Empty;
            LabelCuCuvantulAleator.Text = Cerinta.RandomWord;
            ListaCuvinteAfisate.Add(LabelCuCuvantulAleator.Text);

            ListaImaginiDeSelectat.Add(new string[] { Cerinta.RandomImage, Cerinta.RandomImage, Cerinta.RandomImage });

            for (int i = 0; i < Imagini.Count; i++)
            {
                Imagini[i].Image = Image.FromFile(ListaImaginiDeSelectat[aCataCerinta][i]);
            }

            ListaImaginiSelectate.Add(0);   //0-nici o imagine selectata   1-selectata prima   2-selectata a doua  3-selectata a treia imagine
        }

        private void AfisareCerinta_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            if (Cerinta.TotalNumberOfWords < NumarMinimCuvinte)
            {
                MessageBox.Show("Sunt mai puțin de " + NumarMinimCuvinte + " cuvinte!\n\nPentru a adăuga cuvinte folosește butonul Adaugă/Șterge din meniul principal.");
                this.Close();
                return;
            }

            if (Cerinta.TotalNumberOfImages < NumarMinimImagini)
            {
                MessageBox.Show("Sunt mai puțin de " + NumarMinimImagini + " imagini!\n\nPentru a adăuga imagini folosește butonul Adaugă/Șterge din meniul principal.");
                this.Close();
                return;
            }

            this.Visible = true;

            UpdateControlsWithRandomValues();
        }

        private void Img_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //s-a efectuat click stanga pe imagine
            {
                if (((PictureBox)sender).BackColor == this.BackColor)
                {
                    ((PictureBox)sender).BackColor = CuloareChenarImagineSelectata;
                }    
                else
                {
                    ((PictureBox)sender).BackColor = this.BackColor;
                }      
            }
        }

        private void ButtonNEXT_Click(object sender, EventArgs e)
        {
            if (aCataCerinta < NumarTotalCerinte)
            { 
                for(int i=0;i<Imagini.Count;i++)
                {
                    if(Imagini[i].BackColor == CuloareChenarImagineSelectata)
                    {
                        ListaImaginiSelectate[aCataCerinta] += 1 << i;
                    }
                }

                if (RaspunsCorect() == true)
                    punctaj += 1.0f / NumarTotalCerinte * 100;

                foreach (PictureBox pictureBox in Imagini)
                {
                    pictureBox.BackColor = this.BackColor;
                }

                ++aCataCerinta;

                if (aCataCerinta < NumarTotalCerinte)
                {
                    UpdateControlsWithRandomValues();
                }
                else
                {
                    LabelCuCuvantulAleator.Visible = false;
                    
                    foreach(PictureBox pictureBox in Imagini)
                    {
                        pictureBox.Visible = false;
                    }

                    LabelCuPunctajulCurent.Visible = false;
                    LabelCuNumarulCerinteiCurente.Visible = false;
                    ButtonNEXT.Visible = false;
                    LabelPunctajAfisatLaFinal.Text += string.Format("{0:##0.00} \\ 100,00!", punctaj);
                    LabelPunctajAfisatLaFinal.Visible = true;
                    ButtonRevizuireRaspunsuri.Visible = true;
                }
            }
        }

        private void ButtonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool RaspunsCorect()
        {
            string[] ImaginiDeSelectat = ListaImaginiDeSelectat[aCataCerinta];
            string[] sir;
            string NumePunctTipImagine;

            for(int i=0;i<Imagini.Count;i++)
            {
                sir = ImaginiDeSelectat[i].Split('\\');
                NumePunctTipImagine = sir[sir.Count() - 1];
                if (NumePunctTipImagine.ToLower().Contains(ListaCuvinteAfisate[aCataCerinta].ToLower()) == true && (ListaImaginiSelectate[aCataCerinta] & (1<<i)) == 0)
                    return false;
                else if (NumePunctTipImagine.ToLower().Contains(ListaCuvinteAfisate[aCataCerinta].ToLower()) == false && (ListaImaginiSelectate[aCataCerinta] & (1 << i)) != 0)
                    return false;
            }

            return true;
        }

        private bool ImagineSelectataCorect(int IndexImagine)
        {
            string[] ImaginiDeSelectat = ListaImaginiDeSelectat[aCataCerinta];
            string[] sir;
            string NumePunctTipImagine;

            sir = ImaginiDeSelectat[IndexImagine].Split('\\');
            NumePunctTipImagine = sir[sir.Count() - 1];
            if (NumePunctTipImagine.ToLower().Contains(ListaCuvinteAfisate[aCataCerinta].ToLower()) == true && (ListaImaginiSelectate[aCataCerinta] & (1<<IndexImagine)) == 0)
                return false;
            else if (NumePunctTipImagine.ToLower().Contains(ListaCuvinteAfisate[aCataCerinta].ToLower()) == false && (ListaImaginiSelectate[aCataCerinta] & (1 << IndexImagine)) != 0)
                return false;

            return true;
        }

        private void RevizuireCerintaCurenta(object sender, EventArgs e)
        {
            if(aCataCerinta<NumarTotalCerinte)
            {
                LabelCuPunctajulCurent.Text = string.Format("Punctaj: {0:##0.00} \\ 100,00", punctaj);
                LabelCuNumarulCerinteiCurente.Text = (aCataCerinta + 1) + "\\" + NumarTotalCerinte;

                LabelCuCuvantulAleator.Text = String.Empty;
                LabelCuCuvantulAleator.Text = ListaCuvinteAfisate[aCataCerinta];

                for (int i = 0; i < Imagini.Count; i++)
                {
                    Imagini[i].BackColor = this.BackColor;
                    Imagini[i].Image = Image.FromFile(ListaImaginiDeSelectat[aCataCerinta][i]);

                    if ((ListaImaginiSelectate[aCataCerinta] & (1 << i)) != 0) //daca imaginea a fost selectata
                    {
                        Imagini[i].BackColor = CuloareChenarImagineSelectata;
                    }

                    if (ImagineSelectataCorect(i) == true)
                    {
                        LabeluriAsociateImaginilor[i].BackColor = Color.DarkGreen;
                        LabeluriAsociateImaginilor[i].ForeColor = Color.White;
                        LabeluriAsociateImaginilor[i].Text = "Corect";
                    }
                    else
                    {
                        LabeluriAsociateImaginilor[i].BackColor = Color.DarkRed;
                        LabeluriAsociateImaginilor[i].ForeColor = Color.White;
                        LabeluriAsociateImaginilor[i].Text = "Greșit";
                    }
                }

                if (RaspunsCorect() == true)
                    punctaj += 1.0f / NumarTotalCerinte * 100;

                aCataCerinta++;
            }
            else
            {
                LabelCuCuvantulAleator.Visible = false;

                foreach (PictureBox pictureBox in Imagini)
                {
                    pictureBox.Visible = false;
                }

                LabelCuPunctajulCurent.Visible = false;
                LabelCuNumarulCerinteiCurente.Visible = false;
                ButtonNEXT.Visible = false;

                LabelPunctajAfisatLaFinal.Text = "Punctaj total: " + string.Format("{0:##0.00} \\ 100,00", punctaj);
                LabelPunctajAfisatLaFinal.Visible = true;

                foreach (Label label in LabeluriAsociateImaginilor)
                {
                    label.Visible = false;
                }
            }
        }

        private void ButtonRevizuireRaspunsuri_Click(object sender, EventArgs e)
        {
            ButtonRevizuireRaspunsuri.Visible = false;
            LabelCuCuvantulAleator.Visible = true;

            foreach (PictureBox pictureBox in Imagini)
            {
                pictureBox.Visible = true;
                pictureBox.MouseDown -= Img_MouseDown;
            }

            LabelCuPunctajulCurent.Visible = true;
            LabelCuNumarulCerinteiCurente.Visible = true;

            ButtonNEXT.Visible = true;
            ButtonNEXT.Click -= ButtonNEXT_Click;
            ButtonNEXT.Click += RevizuireCerintaCurenta;

            LabelPunctajAfisatLaFinal.Visible = false;

            foreach (Label label in LabeluriAsociateImaginilor)
            {
                label.Visible = true;
            }

            punctaj = 0;
            aCataCerinta = 0;
        }
    }
}
