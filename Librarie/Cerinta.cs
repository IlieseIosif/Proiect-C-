using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocareDate;
using System.IO;

namespace Librarie
{
    public class Cerinta
    {
        Random Random;
        ListaDeCuvinte ListaDeCuvinte;
        ListaDeImagini ListaDeImagini;

        public Cerinta(string NumeFisierCuCuvinte, string NumeFisierCuImagini)
        {
            Random = new Random();
            ListaDeCuvinte = new ListaDeCuvinte(NumeFisierCuCuvinte);
            ListaDeImagini = new ListaDeImagini(NumeFisierCuImagini);
        }

        public string RandomWord
        {
            get
            {
                return ListaDeCuvinte[Random.Next()];
            }
        }

        public string RandomImage
        {
            get
            {
                return ListaDeImagini[Random.Next()];
            }
        }

        public int TotalNumberOfWords
        {
            get
            {
                return ListaDeCuvinte.dim;
            }
        }

        public int TotalNumberOfImages
        {
            get
            {
                return ListaDeImagini.dim;
            }
        }
    }
}
