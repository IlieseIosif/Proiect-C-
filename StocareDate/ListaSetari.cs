using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace StocareDate
{
    public class ListaSetari
    {
        private string locatieFisier;
        public ListaSetari(string numeFisier)
        {
            locatieFisier = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            locatieFisier += "\\" + numeFisier;
            /* se incearca deschiderea fisierului in modul OpenOrCreate
            astfel incat sa fie creat daca nu exista */
            Console.WriteLine(locatieFisier);
            Stream openOrCreate = File.Open(locatieFisier, FileMode.OpenOrCreate);
            openOrCreate.Close();
        }

        //va returna un string cu 2 numere separate printr-un spatiu:primul numar 
        public string GetSettingsList()
        {
            using (StreamReader streamReader = new StreamReader(locatieFisier))
            {
                string LinieDinFisier;

                return LinieDinFisier = streamReader.ReadLine();
            }
        }

        public void Save(string sir)
        {
            using (StreamWriter streamWriter = new StreamWriter(locatieFisier))
            {
                streamWriter.WriteLine(sir);
            }

        }
    }
}
