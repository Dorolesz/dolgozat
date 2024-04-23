






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
    internal class Terepjaro : Jarmu
    {
        public string Hajtas {  get; set; }
        public bool OffroadKepessegek {  get; set; }
        public Terepjaro(string Gyarto, string Modell, int Evjarat, int AlapAr, string Hajtas, bool OffroadKepessegek) : base(Gyarto, Modell, Evjarat, AlapAr)
        {
            this.Hajtas = Hajtas;
            this.OffroadKepessegek = OffroadKepessegek;
        }
        public void OffroadCsomagFelszerel()
        {
            int csomagAr = 0;
            csomagAr += AlapAr;
            OffroadKepessegek = true;
        }
    }
}
