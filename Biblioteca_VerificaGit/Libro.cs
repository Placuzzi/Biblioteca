using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_VerificaGit
{
    internal class Libro
    {
        internal string Autore { get; set; }
        internal string Titolo { get; set; }
        internal int AnnoPubl { get; set; }
        internal string Editor { get; set; }
        internal int NumPagin { get; set; }
        internal Libro()
        {
        
        }
        public string ReadingTime(int NumPagin)
        {
            string tempoLettura = "";
            if (NumPagin < 100)
            {
                tempoLettura = "il tempo di lettura è minore di 1h";
            }else if (NumPagin > 100 && NumPagin<200)
            {
                tempoLettura = "Il tempo di lettura e di circa 2h";
            }else if (NumPagin > 200)
            {
                tempoLettura= "Il tempo di lettura e maggiore di 2h";
            }

            return tempoLettura;
               
        }
        override string ToString() {
            string Dati;
            Dati = "Il Titolo del Libro è " + Titolo + ", l'autore è " + Autore + ", è stato pubblicato nell'anno " +AnnoPubl+ " l'editore del libro è " +Editor+ " e le pagine sono " + NumPagin;
            return Dati;
        }
    }
    
}
