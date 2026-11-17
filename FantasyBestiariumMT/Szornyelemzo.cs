using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBestiariumMT
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek;

        public Szornyelemzo(List<Szorny> szornyek)
        {
            this.szornyek = szornyek;
        }

        public int OsszesSzornySzama()
        {
            return szornyek.Count;
        }

        public IEnumerable<string> VeszelyesSzornyekNevei()
        {
            string[] veszelyesSzornyekNevei = [];
            foreach (var item in szornyek)
            {
                if (item.VeszelyesE == true)
                {
                    veszelyesSzornyekNevei.Append(item.Nev);
                }
            }
            return veszelyesSzornyekNevei;
        }

        public IEnumerable<string> EgyediElohelyek()
        {
            string[] elohelyek = [];
            foreach (var item in szornyek)
            {
                if (elohelyek.Contains(item.Elohely))
                {

                }
                else
                {
                    elohelyek.Append(item.Elohely);
                }
            }
            return elohelyek.Order();
        }

        public double AtlagosVeszelyesseg()
        {
            double osszVesz = 0;
            int l = szornyek.Count;
            foreach (var item in szornyek)
            {
                osszVesz += item.VeszelyessegiSzint;
            }
            return osszVesz / l;
        }

        public IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            int legnagyobbVesz = 0;
            Szorny[] legveszelyesebbek = [];
            foreach (var item in szornyek)
            {
                if (item.VeszelyessegiSzint > legnagyobbVesz)
                {
                    legnagyobbVesz = item.VeszelyessegiSzint;
                }
            }
            foreach (var item in szornyek)
            {
                if (item.VeszelyessegiSzint == legnagyobbVesz)
                {
                    legveszelyesebbek.Append(item);
                }
            }
            return legveszelyesebbek;
        }

        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            Szorny[] MocsariVeszelyesek = [];
            foreach (var item in szornyek)
            {
                if(item.Elohely=="Fekete Mocsár" && item.VeszelyessegiSzint >= 5)
                {
                    MocsariVeszelyesek.Append(item);
                }
            }
            return MocsariVeszelyesek;
        }

        public bool VanExtremTuzGyengeSzorny()
        {
            bool vane = false;
            foreach (var item in szornyek)
            {
                if (item.FoGyengeseg == "Tűz" && item.VeszelyessegiSzint >= 9)
                {
                    vane = true;
                }

            }
            return vane;
        }
    }
}
