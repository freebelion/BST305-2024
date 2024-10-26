using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SinifKutup1
{
    public class Cizgi
    {
        private List<Nokta> _noktalar;

        public Cizgi()
        {
            _noktalar = new List<Nokta>();
        }

        public Cizgi(int kapasite)
        {  _noktalar = new List<Nokta>(kapasite); }

        public void NoktaEkle(Nokta n)
        {  _noktalar.Add(n); }

        public Nokta this[int sirano]
        {
            get
            {
                if (sirano < 0 || sirano >= _noktalar.Count)
                {
                    throw new ApplicationException("Sira numarasio gecersiz"); 
                }
                else
                {
                    return _noktalar[sirano];
                }
            }
            set { _noktalar[sirano] = value; }
        }

        public double Uzunluk()
        {
            for(int i=0; i < _noktalar.Count; i++)
            {
                // içini siz doldurun
            }

            return double.NaN;
        }
    }
}
