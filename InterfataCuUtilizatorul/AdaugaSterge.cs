using System;
using System.Collections;
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
    public partial class AdaugaSterge : Form
    {
        ArrayList TablouInScaraCuGrupuriDeControale;
        int IndexCurentTablouInScara=0;
        int IndexAnteriorTablouInScara = 0;

        ListaDeCuvinte ListaDeCuvinte;
        ListaDeImagini ListaDeImagini;

        const string NumeFolderCuImagini = "ImaginiCuAnimale";

        public AdaugaSterge()
        {
            ListaDeCuvinte = new ListaDeCuvinte(ConfigurationManager.AppSettings["NumeFisierCuCuvinte"]);
            ListaDeImagini = new ListaDeImagini(ConfigurationManager.AppSettings["NumeFisierCuImagini"]);

            InitializeComponent();
            this.ButtonAdaugareStergereCuvinte.Click += new System.EventHandler(this.ButtonAdaugareStergereCuvinte_Click);  //vom ascunde unele controale in cazul in care lista de 
                                                                                                                            //cuvinte este vidă

            this.ButtonAdaugareStergereImagini.Click += new System.EventHandler(this.ButtonAdaugareStergereImagini_Click);

            this.SelectImagesToAddDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);

            TablouInScaraCuGrupuriDeControale = new ArrayList();
            TablouInScaraCuGrupuriDeControale.Add(new List<List<Control>> { new List<Control> { ButtonAdaugareStergereCuvinte, ButtonAdaugareStergereImagini } });
            TablouInScaraCuGrupuriDeControale.Add(new List<List<Control>> { new List<Control> { ListBoxCuToateCuvintele,LabelListBoxCuToateCuvintele,LabelTextBoxIntroducereCuvant,
                                                                                                TextBoxIntroducereCuvant,ButtonAdaugaCuvant,ButtonStergeCuvinteSelectate},
                                                                            new List<Control> { PanelCuToateImaginile,ButtonAdaugaImagini,ButtonStergeImaginiSelectate,LabelListaVidaDeImagini} 
                                                                          });

            System.IO.Directory.CreateDirectory(ListaDeImagini.GetCaleComunaProiect + "\\" + NumeFolderCuImagini);

            LoadWordsOnListBox();
            LoadImagesOnThePanel();
        }

        private void ButtonInapoi_Click(object sender, EventArgs e)
        {
            if (IndexCurentTablouInScara == 0)
            {
                this.Close();
            }
            else
            {
                List<Control> GrupDeControale = ((List<List<Control>>)TablouInScaraCuGrupuriDeControale[IndexCurentTablouInScara / 10])[IndexCurentTablouInScara % 10];
                for (int i = 0; i < GrupDeControale.Count(); i++)
                {
                    GrupDeControale[i].Visible = false;
                }

                if(IndexCurentTablouInScara / 10 == 1)
                    if(IndexCurentTablouInScara % 10 == 0) //optiunea curenta este Adaugare/Stergere cuvinte
                    {
                        TextBoxIntroducereCuvant.Text = "";
                        ListaDeCuvinte.Save();
                    }
                    else if(IndexCurentTablouInScara % 10 == 1) //optiunea curenta este Adaugare/Stergere imagini
                    {
                        ListaDeImagini.Save();
                    }

                GrupDeControale = ((List<List<Control>>)TablouInScaraCuGrupuriDeControale[IndexAnteriorTablouInScara / 10])[IndexAnteriorTablouInScara % 10];
                for (int i = 0; i < GrupDeControale.Count(); i++)
                {
                    GrupDeControale[i].Visible = true;
                }

                IndexCurentTablouInScara = IndexAnteriorTablouInScara;
            }
        }

        private void ButtonAdaugareStergereCuvinte_Click(object sender, EventArgs e)
        {
            if (ListaDeCuvinte.dim == 0)  //daca lista de cuvinte este vidă, vom ascunde unele controale 
            {
                LabelListBoxCuToateCuvintele.Text = "Lista de cuvinte nu conține\nnici un cuvânt!";
                ListBoxCuToateCuvintele.Visible = false;
                ButtonStergeCuvinteSelectate.Visible = false;
            }
        }

        private void ButtonAdaugareStergereImagini_Click(object sender, EventArgs e)
        {
            if (ListaDeImagini.dim == 0)  //daca lista de imagini este vidă, vom ascunde unele controale 
            {
                LabelListaVidaDeImagini.Visible = true;
                PanelCuToateImaginile.Visible = false;
                ButtonStergeImaginiSelectate.Visible = false;
            }
            else
            {
                LabelListaVidaDeImagini.Visible = false;    //la evenimentul ButtonAdaugareStergereImagini.Click aceasta eticheta devine vizibila 
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            List<Control> GrupDeControale = ((List<List<Control>>)TablouInScaraCuGrupuriDeControale[IndexCurentTablouInScara/10])[IndexCurentTablouInScara % 10];

            IndexAnteriorTablouInScara = IndexCurentTablouInScara;
            IndexCurentTablouInScara += 10;

            for (int i= 0; i<GrupDeControale.Count();i++)
            {
                GrupDeControale[i].Visible = false;

                if ((Control)sender == GrupDeControale[i])
                    IndexCurentTablouInScara += i;
            }

            GrupDeControale = ((List<List<Control>>)TablouInScaraCuGrupuriDeControale[IndexCurentTablouInScara / 10])[IndexCurentTablouInScara % 10];
            for (int i = 0; i < GrupDeControale.Count(); i++)
            {
                GrupDeControale[i].Visible = true;
            }
        }

        public PictureBox InitializePictureBox(string path,int ACataImagineDinPanel)
        {
            PictureBox imagine = new PictureBox();
            imagine.Image = Image.FromFile(path);
            imagine.BackColor = PanelCuToateImaginile.BackColor;
            imagine.ErrorImage = null;
            imagine.Location = new System.Drawing.Point(4 + 190 * (ACataImagineDinPanel % 7), 4 + 128 * (ACataImagineDinPanel / 7));
            imagine.Padding = new System.Windows.Forms.Padding(3);
            imagine.Size = new System.Drawing.Size(189, 127);
            imagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imagine.TabIndex = 4;
            imagine.TabStop = false;
            imagine.MouseDown += new MouseEventHandler(this.Img_MouseDown);

            return imagine;
        }

        private void LoadWordsOnListBox()
        {
            for (int i = 0; i < ListaDeCuvinte.dim; i++)
            {
                ListBoxCuToateCuvintele.Items.Add(ListaDeCuvinte[i]);
            }

            ListBoxCuToateCuvintele.Sorted = true;
        }

        private void LoadImagesOnThePanel()
        {
            for (int i = 0; i < ListaDeImagini.dim; i++)
            {
                PanelCuToateImaginile.Controls.Add(InitializePictureBox(ListaDeImagini[i],i));
            }
        }

        private void AdaugaSterge_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < TablouInScaraCuGrupuriDeControale.Count; i++)
                for (int j = 0; j < ((List<List<Control>>)TablouInScaraCuGrupuriDeControale[i]).Count; j++)
                    foreach (Control control in ((List<List<Control>>)TablouInScaraCuGrupuriDeControale[i])[j])
                        control.Visible = false;
        }

        private void TextBoxIntroducereCuvant_TextChanged(object sender, EventArgs e)
        {
            string cuvant = TextBoxIntroducereCuvant.Text;

            Size size = TextRenderer.MeasureText(cuvant, TextBoxIntroducereCuvant.Font);  //dimensiunea in pixeli a continutului TextBox-ului

            if (size.Width > 1070)
            {
                TextBoxIntroducereCuvant.Text = cuvant.Substring(0,cuvant.Length-1);
                MessageBox.Show("S-a atins dimensiunea maximă a cuvântului!");
            }
            else if (size.Width > 425)
            {
                TextBoxIntroducereCuvant.Width = size.Width + 28;   
            }
            else
            {
                TextBoxIntroducereCuvant.Width = 425;
            }
        }

        private void ButtonAdaugaCuvant_Click(object sender, EventArgs e)
        {
            string cuvant = TextBoxIntroducereCuvant.Text;
            int NumarCaractereCuvant = TextBoxIntroducereCuvant.Text.Length;

            if (NumarCaractereCuvant != 0)
            {
                int i;
                for (i = 0; i < NumarCaractereCuvant; i++)
                    if (cuvant[i] >= '1' && cuvant[i] <= '9')
                    {
                        MessageBox.Show("Cuvântul nu poate conține cifre!");
                        return;
                    }
                    else
                    if (cuvant[i] == ' ')
                    {
                        MessageBox.Show("Cuvântul nu poate conține spații!");
                        return;
                    }
            }
            else
            {
                MessageBox.Show("Cuvântul trebuie să conțină cel puțin o literă!");
                return;
            }

            if(ListaDeCuvinte.Add(cuvant)==false)
            {
                foreach(string element in ListBoxCuToateCuvintele.Items)
                {
                    if (string.Compare(cuvant.ToLower(), element.ToLower()) == 0)
                    {
                        ListBoxCuToateCuvintele.ClearSelected();    //deselectare elemente selectate din ListBox

                        ListBoxCuToateCuvintele.SelectedIndex = ListBoxCuToateCuvintele.Items.IndexOf(element); //selectare cuvant existent in ListBox
                        break;
                    }
                }
                
                MessageBox.Show("Cuvântul deja există!");
                ListBoxCuToateCuvintele.SelectedIndex = -1;     //deselectare element selectat din ListBox
            }
            else 
            {
                //daca lista de cuvinte era vidă si s-a adaugat primul cuvant, vom seta pe vizibil unele controale 
                LabelListBoxCuToateCuvintele.Text = "Cuvintele existente:";
                LabelListBoxCuToateCuvintele.Visible = true;
                ListBoxCuToateCuvintele.Visible = true;
                ButtonStergeCuvinteSelectate.Visible = true;

                ListBoxCuToateCuvintele.ClearSelected();    //deselectare elemente selectate din ListBox

                ListBoxCuToateCuvintele.Items.Add(cuvant);
                ListBoxCuToateCuvintele.SelectedIndex = ListBoxCuToateCuvintele.Items.IndexOf(cuvant);
                MessageBox.Show("Cuvântul a fost adăugat!");
                ListBoxCuToateCuvintele.SelectedIndex = -1;     //deselectare element selectat din ListBox
            }
        }

        private void ButonIesire_Click(object sender, EventArgs e)
        {
            if (IndexCurentTablouInScara / 10 == 1) //s-a selectat unul dintre butonele: Adaugare/Stergere cuvinte,Adaugare/Stergere imagini
                if (IndexCurentTablouInScara % 10 == 0) //optiunea curenta este Adaugare/Stergere cuvinte
                {
                    ListaDeCuvinte.Save();
                }
                else if (IndexCurentTablouInScara % 10 == 1) //optiunea curenta este Adaugare/Stergere imagini
                {
                    ListaDeImagini.Save();
                }

            this.Close();
        }

        private void ButtonStergeCuvinteSelectate_Click(object sender, EventArgs e)
        {
            List<string> CuvinteSelectate = new List<string>();

            foreach(string cuvant in ListBoxCuToateCuvintele.SelectedItems)
            {
                CuvinteSelectate.Add(cuvant);
            }

            if (CuvinteSelectate.Count == 0)
            {
                MessageBox.Show("Nu ați selectat nici un cuvânt!");
            }
            else
            {
                for (int i = 0; i < CuvinteSelectate.Count; i++)
                {
                    ListaDeCuvinte.Remove(CuvinteSelectate[i]);
                    ListBoxCuToateCuvintele.Items.Remove(CuvinteSelectate[i]);
                }

                if (ListaDeCuvinte.dim == 0)  //daca lista de cuvinte a devenit vidă, vom ascunde unele controale 
                {
                    LabelListBoxCuToateCuvintele.Text = "Lista de cuvinte nu conține\nnici un cuvânt!";
                    ListBoxCuToateCuvintele.Visible = false;
                    ButtonStergeCuvinteSelectate.Visible = false;
                }

                MessageBox.Show("Cuvintele selectate au fost șterse!");
            }
        }

        private void Img_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left) //s-a efectuat click pe imagine
            {
                if (((PictureBox)sender).BackColor == PanelCuToateImaginile.BackColor)
                {
                    ((PictureBox)sender).BackColor = Color.DarkRed;
                }
                else
                {
                    ((PictureBox)sender).BackColor = PanelCuToateImaginile.BackColor;
                }
            }
        }

        private void ButtonStergereImaginiSelectate_Click(object sender, EventArgs e)
        {
            bool MacarOImagineSelectata = false;
            int index=0;
            List<PictureBox> ListaPictureBoxDeScosDinPanel = new List<PictureBox>();

            foreach (PictureBox imagine in PanelCuToateImaginile.Controls)
            {
                if(imagine.BackColor==Color.DarkRed)    //imaginea este selectata
                {
                    imagine.MouseDown -= Img_MouseDown;
                    imagine.Image.Dispose();
                    imagine.Image = null;
                    ListaPictureBoxDeScosDinPanel.Add(imagine);
                    System.IO.File.Delete(ListaDeImagini[index]);
                    ListaDeImagini.RemoveAt(index); //sterge din ListaDeImagini denummirea imaginii ce va fi stearsa
                    MacarOImagineSelectata = true;
                }
                else
                {
                    imagine.Location = new System.Drawing.Point(4 + 190 * (index % 7), 4 + 128 * (index / 7));
                    index++;
                    PanelCuToateImaginile.Refresh();
                }
            }

            if(MacarOImagineSelectata==true)
            {
                //eliminarea imaginilor din Panel se face aici,deoarece daca s-ar face in bucla foreach, modificarea colectiei PanelCuToateImaginile.Controls ar duce la
                //neverificarea unor imagini daca sunt selectate
                foreach (PictureBox imagine in ListaPictureBoxDeScosDinPanel)    
                {
                    PanelCuToateImaginile.Controls.Remove(imagine);
                }

                if (ListaDeImagini.dim == 0)  //daca lista de imagini este vidă, vom ascunde unele controale 
                {
                    LabelListaVidaDeImagini.Visible = true;
                    PanelCuToateImaginile.Visible = false;
                    ButtonStergeImaginiSelectate.Visible = false;
                }

                MessageBox.Show("Imaginile selectate au fost șterse!");
            }
            else
            {
                MessageBox.Show("Nu ai selectat nici o imagine!");
            }
        }

        private void ButtonAdaugaImagini_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O imagine va fi asociată unui cuvânt doar dacă respectivul cuvânt este inclus în numele imaginii!\n\nNu sunt acceptate imagini cu același nume!\nAsigurați-vă ca imaginile selectate au în componența lor un număr pentru a evita acest lucru!");
            SelectImagesToAddDialog.ShowDialog();
        }

        private void SelectImagesToAddDialog_FileOk(object sender, CancelEventArgs e)
        {
            int NumarTotalImaginiDeAdaugat = 0;
            int NumarImaginiExistente = 0;

            foreach (string path in SelectImagesToAddDialog.FileNames)
            {
                NumarTotalImaginiDeAdaugat += 1;

                string[] sir = path.Split('\\');

                if (ListaDeImagini.Add("\\" + NumeFolderCuImagini + "\\" + sir[sir.Length-1]) == true)   //nu exista nici o imagine cu acelasi nume si tip
                {
                    string CaleImagineDeCreat = ListaDeImagini.GetCaleComunaProiect + "\\" + NumeFolderCuImagini + "\\" + sir[sir.Length - 1];

                    using (var myFile = System.IO.File.Create(CaleImagineDeCreat)) { };
                    System.IO.File.Copy(path, CaleImagineDeCreat, true);    //copiaza continutul din imaginea de adugat in imaginea creata

                    PanelCuToateImaginile.Controls.Add(InitializePictureBox(CaleImagineDeCreat, PanelCuToateImaginile.Controls.Count));
                    PanelCuToateImaginile.Refresh();
                }
                else
                {
                    MessageBox.Show("Există deja o imagine " + sir[sir.Length - 1] + " în lista de imagini!");
                    NumarImaginiExistente += 1;
                }
            }

            if(NumarTotalImaginiDeAdaugat - NumarImaginiExistente > 0)
            {
                //daca lista de imagini era vidă si s-au adaugat imagini, vom afisa unele controale 
                LabelListaVidaDeImagini.Visible = false;
                PanelCuToateImaginile.Visible = true;
                ButtonStergeImaginiSelectate.Visible = true;
                
                MessageBox.Show("Imaginile au fost adăugate!");
            }
        }
    }
}
