using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekil_Uygulamasi
{
    public class Sekil  // base class, super class
    {
        public string isim { get; set; }    

        public Sekil(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return this.isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor..");
        }

        public virtual void sekilBilgileriGoster()
        {
            Console.WriteLine(getIsim() + " 'nin bilgileri !!");
        }

    }
}
