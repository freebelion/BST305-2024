namespace ArabirimOrnek
{
    public interface Fonksiyon
    {
        public double Deger(double x);
        // public double Turev(double x, double seviye);
    }

    class SinFonksiyon : Fonksiyon
    {
        public int Katsayi { get; set; }

        public SinFonksiyon(int katsayi_deger)
        { Katsayi = katsayi_deger; }

        public double Deger(double x)
        {
            return Math.Sin(Katsayi*x);
        }
    }

    class CosFonksiyon : Fonksiyon
    {
        public double Deger(double x)
        {
            return Math.Cos(x);
        }
    }

    class UsFonksiyon : Fonksiyon
    {
        public double Us {  get; set; }

        public UsFonksiyon(double usdeger) {  Us = usdeger; }

        public double Deger(double x)
        {
            return Math.Pow(x, Us);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Fonksiyon> fdizi = new List<Fonksiyon>();

            fdizi.Add(new SinFonksiyon(2));
            fdizi.Add(new CosFonksiyon());
            fdizi.Add(new UsFonksiyon(3));
            fdizi.Add(new UsFonksiyon(0.5));

            double x = 1.57;

            for (int i = 0; i < fdizi.Count; i++)
            {
                Console.WriteLine("f({0}) = {1}", x, fdizi[i].Deger(x));
            }
        }
    }
}
