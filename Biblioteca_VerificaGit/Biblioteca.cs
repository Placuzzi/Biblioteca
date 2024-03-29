﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_VerificaGit
{
    internal class Biblioteca
    {
        internal List<Libro> Libri = new List<Libro>();
        DateTime OrarioApertura { get; set; }
        DateTime OrarioChiusura { get; set; }
        string NomeBiblioteca { get; set; }
        string IndirizzoBiblioteca { get; set; }

        internal Biblioteca(string NomeBiblioteca, string IndirizzoBiblioteca, DateTime OrarioChiusura, DateTime OrarioApertura)
        {
            this.NomeBiblioteca = NomeBiblioteca;
            this.IndirizzoBiblioteca = IndirizzoBiblioteca;
            this.OrarioChiusura = OrarioChiusura;
            this.OrarioApertura = OrarioApertura;
        }
    }
}
