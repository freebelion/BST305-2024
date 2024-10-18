namespace SinifKutup1
{
    public class Nokta
    {
        private double _x;
        private double _y;

        public Nokta()
        {
            _x = 0;
            _y = 0;
        }

        /// <summary>
        /// Parametrized constructor which accepts initial values for the two coordinates
        /// </summary>
        /// <param name="xinit">Initial value for the _x horizontal coordinate</param>
        /// <param name="yinit">Initial value for the _y vertical coordinate</param>
        public Nokta(double xinit, double yinit)
        {
            _x = xinit;
            _y = yinit;
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        
        public double Uzaklik()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }

        /// <summary>
        /// n2 ile gelen ikinci noktanın n1 ile gelen birinci noktaya x yönündeki mesafesini hesaplar
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double DeltaX(Nokta n1, Nokta n2)
        { return n2._x - n1._x; }

        public static double DeltaY(Nokta n1, Nokta n2)
        { return n2._y - n1._y; }

        public static double Uzaklik(Nokta n1, Nokta n2)
        {
            double dx = DeltaX(n1, n2);
            double dy = DeltaY(n1, n2);
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
