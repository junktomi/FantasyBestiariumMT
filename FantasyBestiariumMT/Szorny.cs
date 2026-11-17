using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace FantasyBestiariumMT
{
    internal class Szorny
    {
        private int id;
        private string nev;
        private int veszelyessegiSzint;
        private string elohely;
        private string foGyengeseg;
        private string leggyakoribbZsakmany;
        private bool veszelyesE;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int VeszelyessegiSzint { get => veszelyessegiSzint; set => veszelyessegiSzint = value; }
        public string Elohely { get => elohely; set => elohely = value; }
        public string FoGyengeseg { get => foGyengeseg; set => foGyengeseg = value; }
        public string LeggyakoribbZsakmany { get => leggyakoribbZsakmany; set => leggyakoribbZsakmany = value; }
        public bool VeszelyesE { get => veszelyesE; set => veszelyesE = value; }
    }
}
