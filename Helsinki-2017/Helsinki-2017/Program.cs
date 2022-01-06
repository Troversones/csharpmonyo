using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki_2017
{
    class Program
    {
        public struct MyStruct
        {
            public string nev, oKod;
            public double pontszam, kPontszam, osszPont;
            public int hibaPont;
        }
        public static List<MyStruct> rovid = new List<MyStruct>();
        public static List<MyStruct> donto = new List<MyStruct>();

        static void Main(string[] args)
        {
            StreamReader olv = new StreamReader("rovidprogram.csv");
            string fc = olv.ReadLine();
            while (!olv.EndOfStream)
            {
                fc = olv.ReadLine();
                string[] s = fc.Split(';');
                MyStruct xd = new MyStruct();
                xd.nev = s[0];
                xd.oKod = s[1];
                xd.pontszam = double.Parse(s[2].Replace('.',','));
                xd.kPontszam = double.Parse(s[3].Replace('.', ','));
                xd.hibaPont = int.Parse(s[4].Replace('.', ','));
                rovid.Add(xd);
            }
            olv.Close();

            StreamReader olvaso2 = new StreamReader("donto.csv");
            fc = olvaso2.ReadLine();
            while (!olvaso2.EndOfStream)
            {
                fc = olvaso2.ReadLine();
                string[] s = fc.Split(';');
                MyStruct xd2 = new MyStruct();
                xd2.nev = s[0];
                xd2.oKod = s[1];
                xd2.pontszam = double.Parse(s[2].Replace('.', ','));
                xd2.kPontszam = double.Parse(s[3].Replace('.', ','));
                xd2.hibaPont = int.Parse(s[4]);
                donto.Add(xd2);
            }

            olvaso2.Close();

            Console.WriteLine("2. feladat");
            Console.WriteLine("A rövidprogramban indult versenyzők száma: " + rovid.Count);

            Console.WriteLine("3. feladat");
            bool kekw = false;
            int indexponthu = 0;
            while (!kekw && indexponthu < donto.Count)
            {
                if (donto[indexponthu].oKod == "HUN")
                {
                    kekw = true;
                }
                else
                {
                    indexponthu++;
                }
            }
            if (kekw)
            {
                Console.WriteLine("Bejutott magyar a kűrbe!");
            }
            else
            {
                Console.WriteLine("Nem jutott be magyar a kűrbe!");
            }
            Console.WriteLine("5. feladat");
            Console.WriteLine("Kérek egy nevet: ");
            string nev = Console.ReadLine();

            Console.WriteLine("6. feladat");
            double osszPont = osszPontszam(nev);
            if (osszPont == 0)
            {
                Console.WriteLine("Nem volt ilyen versenyző!");
            }
            else
            {
                Console.WriteLine("Az összpontszáma: " + osszPont);
            }

            Console.WriteLine("7. feladat");
            List<string> bejutottak = new List<string>();
            foreach (MyStruct arisztokratak in donto)
            {
                if (!bejutottak.Contains(arisztokratak.oKod))
                {
                    bejutottak.Add(arisztokratak.oKod);
                }
            }

            foreach (string orszag in bejutottak)
            {
                int db = 0;
                foreach (MyStruct arisztokratak in donto)
                {
                    if (arisztokratak.oKod == orszag)
                    {
                        db++;
                    }
                }
                if (db > 1)
                {
                    Console.WriteLine(orszag + ": " + db + " versenyző");
                }
            }

            Console.ReadKey();
        }
        static double osszPontszam(string nev)
        {
            double osszPont = 0;
            foreach (MyStruct arisztokratak in rovid)
            {
                if (arisztokratak.nev == nev)
                {
                    osszPont += arisztokratak.pontszam + arisztokratak.kPontszam - arisztokratak.hibaPont;
                }
            }

            foreach (MyStruct arisztokratak in donto)
            {
                if (arisztokratak.nev == nev)
                {
                    osszPont += arisztokratak.pontszam + arisztokratak.kPontszam - arisztokratak.hibaPont;
                }
            }
            return osszPont;
        }
    }
}
