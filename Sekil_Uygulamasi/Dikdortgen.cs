using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sekil_Uygulamasi
{
    public class Dikdortgen : Sekil
    {
        public int kisakenar {  get; set; }
        public int uzunkenar { get; set; }
        public Dikdortgen(string isim, int kisakenar,int uzunkenar) : base(isim)
        {
            this.uzunkenar = uzunkenar;
            this.kisakenar = kisakenar;
        
        }
        public override void sekilHesapla()
        {
            Console.WriteLine("Dikdörtgenin alanı hesaplanıyor..");
            Console.WriteLine(getIsim() + "  'nin alanı : " + (kisakenar*uzunkenar));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine(getIsim() + " 'nin kisa kenarı : " + this.kisakenar);
            Console.WriteLine(getIsim() + " 'nin uzun kenarı : " + this.uzunkenar);
        }
    }
}
