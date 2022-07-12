using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StocareDate
{
    public class ListaDeImagini
    {
        string locatieFisier;
        List<string> ListaImagini;

        public ListaDeImagini(string numeFisier)
        {
            locatieFisier = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            locatieFisier += "\\" + numeFisier;
            /* se incearca deschiderea fisierului in modul OpenOrCreate
            astfel incat sa fie creat daca nu exista */
            Stream openOrCreate = File.Open(locatieFisier, FileMode.OpenOrCreate);
            openOrCreate.Close();

            ListaImagini = new List<string>();

            using (StreamReader streamReader = new StreamReader(locatieFisier))
            {
                string LinieDinFisier;

                while ((LinieDinFisier = streamReader.ReadLine()) != null)
                {
                    if (LinieDinFisier.Length != 0)
                        ListaImagini.Add(LinieDinFisier);
                }
            }
        }

        public static string GetCaleComunaProiect
        {
            get
            {
                return Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            }
        }

        public int dim
        {
            get
            {
                return ListaImagini.Count;
            }
        }

        public string this[int index]
        {
            get
            {
                return Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + ListaImagini[index % dim];
            }
        }

        public string GetNameAndTipeOfImage(int index)
        {
            string[] sir = ListaImagini[index].Split('\\');
            return sir[sir.Length - 1];
        }

        public bool Add(string path)    //path="\NumeFolderCuImagini\NumeImagine.tip"
        {
            int i;
            string[] sir = path.Split('\\');

            for (i = 0; i < dim; i++)
            {
                if (string.Compare(sir[sir.Length-1], GetNameAndTipeOfImage(i)) == 0)
                {
                    break;
                }
            }

            if(i == dim)    //imaginea nu exista in lista de imagini
            {
                ListaImagini.Add(path);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            ListaImagini.RemoveAt(index);
        }

        public void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(locatieFisier, false))
            {
                foreach (string cuvant in ListaImagini)
                    streamWriter.WriteLine(cuvant);
            }
        }
    }
}
