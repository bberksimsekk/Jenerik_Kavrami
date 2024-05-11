using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenerik_Kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic (Jenerik) Kavramı

            //Personel p = new Personel(); //Jenerik Olmayan Nesne
            //p.Isim = "Alp";
            //p.Soyisim = "Sarıkışla";

            Personel<string> prs = new Personel<string>();
            prs.Isim = "Alp";
            prs.Soyisim = "Sarıkışla";
            prs.Yaş = "30";

            Personel<int> prs2 = new Personel<int>();
            prs2.Isim = "Alp";
            prs2.Soyisim = "Sarıkışla";
            prs2.Yaş = 30;
            prs2.ÇocukSayısı = 3;

            Console.WriteLine(prs2.Isim + " " + prs2.Soyisim + " " + (prs2.Yaş + 2) + " " + prs2.ÇocukSayısı);

            #endregion

            #region Araç Sınıfında Jenerik Kavramı

            Araç<string, int> araçlar = new Araç<string, int>();
            araçlar.Anahtar = "ID";
            araçlar.Değer = 34260616;

            Console.WriteLine(araçlar.Anahtar + " = " + araçlar.Değer);

            #endregion
        }
    }

    class Personel<T>
    {
        public string Isim { get; set; }

        public string Soyisim { get; set; }

        public T Yaş { get; set; }

        public T ÇocukSayısı { get; set; }
    }

    class Araç <T,Y>
    {
        public T Anahtar { get; set; }

        public Y Değer { get; set; }
    }
}
