using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
    internal class Szemelyauto : Jarmu
    {
        public int UlesekSzama { get; set; }
        public double Fogyasztas { get; set; }
        public Szemelyauto(string Gyarto, string Modell, int Evjarat, int AlapAr, int UlesekSzama, double Fogyasztas) : base(Gyarto, Modell, Evjarat, AlapAr)
        {
            this.UlesekSzama = UlesekSzama;
            this.Fogyasztas = Fogyasztas;
        }
        public void KenyelmiExtraBeszerzese(string extra)
        {
            if (extra == null)
            {
                extra += AlapAr;
            }
        }
    }
}
