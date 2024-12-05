using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekil_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Şekil Uygulamamıza Hoşgeldiniz ");

            while (true)
            {
                Console.WriteLine("İşlem Seciniz:");
                Console.WriteLine("1- Dikdörtgen İşlemleri");
                Console.WriteLine("2- Üçgen İşlemleri");
                Console.WriteLine("3- Kare İşlemleri");
                Console.WriteLine("4- q'ye basarak çıkınız");
                string secim = Console.ReadLine();
                if (secim == "q")
                {
                    Console.WriteLine("Şekil Uygulamamızdan çıkış yapılıyor, iyi günler dileriz..");
                    break;
                }
                else if (secim == "1")
                {
                    while (true)
                    {
                        Console.WriteLine(" Lütfen secim yapınız: ");
                        Console.WriteLine("1- Dikdörtgen Alan Hesapla");
                        Console.WriteLine("2- Dikdörtgen Bilgileri Göster");
                        Console.WriteLine("3- q'ya basarsa Dikdörtgen'den çıkış yap");

                        string secimdikdortgen = Console.ReadLine();
                        if (secimdikdortgen == "1")
                        {

                            Console.WriteLine("Kisa Kenarı Giriniz: ");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun Kenarı Giriniz: ");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());
                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kisakenar, uzunkenar);

                            dikdortgen.sekilHesapla();
                        }
                        else if (secimdikdortgen == "2")
                        {
                            Console.WriteLine("Kisa Kenarı Giriniz: ");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun Kenarı Giriniz: ");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kisakenar, uzunkenar);
                            dikdortgen.sekilBilgileriGoster();
                        }
                        else if (secimdikdortgen == "q")
                        {
                            Console.WriteLine("Diktörtgen işlemlerinden çıkış yapıyorsunuz..");
                            break;
                        }
                    }
                }
                else if (secim == "2")
                {
                   

                    while (true)
                    {
                        Console.WriteLine(" Lütfen secim yapınız: ");
                        Console.WriteLine("1- Üçgenin Alan Hesapla");
                        Console.WriteLine("2- Üçgenin Bilgileri Göster");
                        Console.WriteLine("3- q'ya basarsa Üçgen'den çıkış yap");

                        string secimucgen = Console.ReadLine();

                        if (secimucgen == "1")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz : ");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin yüksekliğini giriniz : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", tabanalani, yukseklik);
                            ucgen.sekilHesapla();
                        }
                        else if (secimucgen == "2")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz : ");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin yüksekliğini giriniz : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", tabanalani, yukseklik);
                            ucgen.sekilBilgileriGoster();

                        }
                        else if (secimucgen == "q")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkılıyor");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir değer giriniz.");
                        }
                    }
                }
                else if (secim == "3")
                {
                  


                    while (true)
                    {
                        Console.WriteLine(" Lütfen secim yapınız: ");
                        Console.WriteLine("1- Karenin Alan Hesapla");
                        Console.WriteLine("2- Karenin Bilgileri Göster");
                        Console.WriteLine("3- q'ya basarsa Kare'den çıkış yap");

                        string seckare = Console.ReadLine();
                        if (seckare == "1")
                        {
                            Console.WriteLine("Karenin kenarını giriniz: ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Kare kare = new Kare("Kare", kenar);
                            kare.sekilHesapla();

                        }
                        else if (seckare == "2")
                        {
                            Console.WriteLine("Karenin kenarını giriniz: ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Kare kare = new Kare("Kare", kenar);
                            kare.sekilBilgileriGoster();
                        }
                        else if (seckare == "q")
                        {
                            Console.WriteLine("Karenin İşlemlerinden çıkılıyor");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz Bir Değer Giridiniz");
                }
            }
        }
    }
}
