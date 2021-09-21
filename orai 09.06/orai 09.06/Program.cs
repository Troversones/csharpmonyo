using System;

namespace orai_09._06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region kerekites/atlag
            double[] átlagok = new double[10] { 1.89 , 4.21 , 3.23 , 2.11 , 3.78 , 1.77 ,3.66 , 4.66 , 3.89 , 3.55 };
            double átlagxd = 0;
            for (int i = 0; i < átlagok.Length; i++)
            {
                átlagxd = átlagxd + átlagok[i];

            }
            Console.WriteLine("Az osztály átlaga: {0}",Math.Round(átlagxd / átlagok.Length , 2));
            #endregion kerekites/atlag
            #region Gyokvonas
            Console.WriteLine("Adj meg egy számot, aminek a gyöke ki lesz számolva: ");
            int gigakek = Convert.ToInt32(Console.ReadLine());

            double janos = Math.Round(Math.Sqrt(gigakek),2);

            Console.WriteLine("A gyökvonás eredménye: {0}", janos);
            #endregion Gyokvonas
            #region pow
            Console.WriteLine("Adj meg egy számot, ami hatványolva lesz: ");
            int gigakek2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a szám hatványát: ");
            int hatvanyszam = Convert.ToInt32(Console.ReadLine());

            double hatvany = Math.Pow(gigakek2, hatvanyszam);

            Console.WriteLine("A szám hatványa: {0}" ,hatvany);
            #endregion pow
            #region Min
            Console.WriteLine("Adj meg két számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double min = Math.Min(a, b);
            Console.WriteLine("A kisebb szám: {0}", min);
            Console.ReadKey();
            #endregion Min
            #region Max
            Console.WriteLine("Adj meg egy számot: ");
            double szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg még egy számot: ");
            double szam2 = Convert.ToInt32(Console.ReadLine());

            double nagyobb = Math.Max(szam1, szam2);

            Console.WriteLine("A(z) első szám: {0}, a második szám: {1} ------ a kettő közül a nagyobb: {2}", szam1, szam2, nagyobb);
            #endregion Max
            #region Ceiling
            double[] átlagok2 = new double[10] { 1.89, 4.21, 3.23, 2.11, 3.78, 1.77, 3.66, 4.66, 3.89, 3.55 };
            double átlagxd2 = 0;
            for (int i = 0; i < átlagok2.Length; i++)
            {
                átlagxd2 = átlagxd2 + átlagok2[i];

            }
            Console.WriteLine("Az osztály átlaga fölfelé kerekítve {0} egész.", Math.Ceiling(átlagxd2 / átlagok2.Length));
            Console.ReadKey();
            #endregion Ceiling
            #region Floor
            double szam = 4.64;

            double egesz = Math.Floor(szam);

            Console.WriteLine("Kerek szám: {0}", egesz);

            Console.ReadKey();
            #endregion Floor
            Console.ReadKey();
        }
    }
}
