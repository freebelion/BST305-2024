namespace Vektor
{
    /// <summary>
    /// Ana program sınıfı
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Fiziksel bir vektörü temsil eden sınıf
        /// </summary>
        public class Vektor
        {
            /// <summary>
            /// Vektörün yatay bileşeninin büyüklüğü
            /// </summary>
            private double _x;
            /// <summary>
            /// Vektörün dikey bileşeninin büyüklüğü
            /// </summary>
            private double _y;

            /// <summary>
            /// Gizli üye değişken _x için
            /// iki yönlü erişim hakkı veren
            /// özellik tanımı
            /// </summary>
            public double X
            {
                get { return _x; }
                set { _x = value; }
            }

            /// <summary>
            /// Gizli üye değişken _y için
            /// iki yönlü erişim hakkı veren
            /// özellik tanımı
            /// </summary>
            public double Y
            {
                get { return _y; }
                set { _y = value; }
            }

            public double Buyukluk
            {
                get { return Math.Sqrt(X * X + Y * Y); }
            }
        }

        static void Main(string[] args)
        {
            Vektor v1 = new Vektor();
            v1.X = 2.5; v1.Y = 3.4;

            Console.WriteLine("Vektor v({0}|{1}) Buyuklugu = {2}",
                v1.X, v1.Y, v1.Buyukluk);
        }
    }
}
