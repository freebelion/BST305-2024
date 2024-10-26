using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifKutup1
{
    public class Dikdortgen
    {
        Nokta _solust;
        double _genislik;
        double _yukseklik;

        public Dikdortgen()
        {
            _solust = new Nokta();
            _genislik = 0;
            _yukseklik = 0;
        }

        public double Genislik
        {
            get { return _genislik; }
            set { _genislik = value; }
        }

        public double Yukseklik
        {
            get => _yukseklik;
            set { _yukseklik = value; }
        }

        public Dikdortgen(Nokta solust, double gen, double yuk)
        {
            _solust = new Nokta();
            _solust.X = solust.X;
            _solust.Y = solust.Y;

            _genislik = gen;
            _yukseklik = yuk;
        }

        public Dikdortgen(double x1, double y1, double x2, double y2)
        {
            _solust = new Nokta(x1, y1);
            _genislik = x2 - x1;
            _yukseklik = y2 - y1;
        }

        public double Alan()
        {
            return _genislik * _yukseklik;
        }

        public bool NoktaDahil(Nokta n)
        {
            double dx = Nokta.XFark(_solust, n);
            double dy = Nokta.YFark(_solust, n);

            return (dx > 0) && (dx < _genislik) &&
                (dy > 0) && (dy < _yukseklik);
        }
    }
}
