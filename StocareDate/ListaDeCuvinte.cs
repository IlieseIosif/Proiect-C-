using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StocareDate
{
    public class ListaDeCuvinte
    {
        string locatieFisier;
        List<string> ListaCuvinte;

        public int dim
        {
            get
            {
                return ListaCuvinte.Count;
            }
        }

        public ListaDeCuvinte(string numeFisier)
        {
            locatieFisier = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName; 
            locatieFisier += "\\" + numeFisier;
            /* se incearca deschiderea fisierului in modul OpenOrCreate
            astfel incat sa fie creat daca nu exista */
            Stream openOrCreate = File.Open(locatieFisier, FileMode.OpenOrCreate);
            openOrCreate.Close();

            ListaCuvinte = new List<string>();

            using (StreamReader streamReader = new StreamReader(locatieFisier))
            {
                string LinieDinFisier;

                while ((LinieDinFisier = streamReader.ReadLine()) != null)
                {
                    if(LinieDinFisier.Length != 0)
                        ListaCuvinte.Add(LinieDinFisier);
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return ListaCuvinte[index%dim];
            }
        }

        public bool Add(string _cuvant)
        {

            foreach(string cuvant in ListaCuvinte)
            {
                if (string.Compare(cuvant.ToLower(),_cuvant.ToLower())==0)
                    return false;
            }

            ListaCuvinte.Add(_cuvant);

            return true;
        }

        public void Remove(string _cuvant)
        {
            ListaCuvinte.Remove(_cuvant);
        }

        public void Save()  //salveaza lista de cuvinte in fisier
        {
            using (StreamWriter streamWriter = new StreamWriter(locatieFisier,false))
            {
                foreach (string cuvant in ListaCuvinte)
                    streamWriter.WriteLine(cuvant);  
            }
        }
    }
}