using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
    internal class Jarmu
    {
        public string Gyarto { get; set; }
        public string Modell {  get; set; }
        public int Evjarat {  get; set; }
        public int AlapAr {  get; set; }
        public int KilometeroraAllas {  get; set; }
        public Jarmu(string Gyarto, string Modell, int Evjarat, int AlapAr, int kilometeroraAllas)
        {
            this.Gyarto = Gyarto;
            this.Modell = Modell;
            this.Evjarat = Evjarat;
            this.AlapAr = AlapAr;
            KilometeroraAllas = kilometeroraAllas;
        }
        public void JarmuInfo()
        {
            Console.WriteLine(Gyarto, Modell, Evjarat);
        }
        public void ArKalkulacio()
        {
            
        }
        public void KmAllasFrissites (int km)
        {
            km += KilometeroraAllas;
        }
    }

    

}
