using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // generic listi kendin yazmaya çalış.

            SelamVer(isim: "Nazan", bir: 243234233);


            string[] sehirlerimiz = new[] { "trabzon", "rize", "ordu" };
            List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir" }; // generic list - generic collection

            sehirler.Add("Muğla");
            sehirler.Add("Adıyaman");


            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());


            Console.ReadLine();

        }

        static void SelamVer(string isim, int bir)
        { Console.WriteLine("Merhaba " + isim + ".Mevcut bakiyeniz: " + bir); }


        
    }
}
