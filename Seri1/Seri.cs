using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Seri1
{
    public abstract class Seri
    {
        public double ILK {  get; set; }
        public double ADIM {  get; set; }
        protected double SAYI { get; set; }

        public Seri()
        {
            SAYI = ILK = 0; ADIM = 0;
        }

        public Seri(double ilk, double adim)
        {
            SAYI = ILK = ilk;
            ADIM = adim;
        }

        public void IlkeDon() { SAYI = ILK; }

        public abstract double Sonraki();
    }

    public class AritmetikSeri : Seri
    {
        public AritmetikSeri() : base() { }
        public AritmetikSeri(double ilk, double adim)
            : base(ilk, adim) { }

        public override double Sonraki()
        { return Math.Round(SAYI += ADIM, 3); }
    }

    public class GeometrikSeri : Seri
    {
        public GeometrikSeri() : base() { }
        public GeometrikSeri(double ilk, double adim)
            : base(ilk, adim) { }

        public override double Sonraki()
        { return SAYI *= ADIM; }
    }
}
