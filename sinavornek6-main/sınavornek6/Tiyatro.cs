using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınavornek6
{
    internal class Tiyatro
    {
        int oyunid;
        string oyunad;
        int sure;
        double fiyat;
        DateTime oyuntarih;
        string sahne;
        bool muzikal;

        public int Oyunid { get => oyunid; set => oyunid = value; }
        public string Oyunad { get => oyunad; set => oyunad = value; }
        public int Sure { get => sure; set => sure = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public DateTime Oyuntarih { get => oyuntarih; set => oyuntarih = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }

        public Tiyatro(int oyunid, string oyunad, int sure, double fiyat, DateTime oyuntarih, string sahne, bool muzikal)
        {
            this.oyunid = oyunid;
            this.oyunad = oyunad;
            this.sure = sure;
            this.fiyat = fiyat;
            this.oyuntarih = oyuntarih;
            this.sahne = sahne;
            this.muzikal = muzikal;
        }
    }
}
