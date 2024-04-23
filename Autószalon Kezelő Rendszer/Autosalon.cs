using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
    internal class Autosalon
    {
        public List<Jarmu> Jarmu { get; set; }
        public Autosalon()
        {
            Jarmu = new List<Jarmu>();
        }
        public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            Jarmu.Add(jarmu);
        }
        public void JarmuKersese(string gyarto, string modell)
        {
            foreach (Jarmu jarmu in Jarmu)
            {
                if (jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    Console.WriteLine($"{jarmu.Gyarto} {jarmu.Modell}");
                }
                else
                {
                    Console.WriteLine("Nincs találat!");
                }
            }
        }
    }
}
