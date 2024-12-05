using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekil_Uygulamasi
{
    public class Ucgen : Sekil
    {
        public int tabanalani {  get; set; }
        public int yuksellik { get; set; }
        public Ucgen(string isim, int tabanalani, int yuksekllik ) : base(isim)
        {
            this.tabanalani = tabanalani;
            this.yuksellik = yuksekllik;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " 'nin alanı : " + ((tabanalani * yuksellik)/2));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine(getIsim() + " 'nin taban alanı : " + tabanalani);
            Console.WriteLine(getIsim() + " 'nin yüksekliği : " + yuksellik);
        }

    }
}
