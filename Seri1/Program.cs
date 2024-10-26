namespace Seri1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seri s1 = new AritmetikSeri(1, 0.1);
            Seri s2 = new GeometrikSeri(1, 0.1);

            Console.WriteLine("Dizi ilk değer: {0} Adım: {1}",
                s1.ILK, s1.ADIM);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("=> {0}", s1.Sonraki());
            }
            Console.WriteLine();
            Console.WriteLine("Dizi ilk değer: {0} Adım: {1}",
                s2.ILK, s2.ADIM);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("=> {0}", s2.Sonraki());
            }
        }
    }
}
