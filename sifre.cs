/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Ezgi EDE
**				ÖĞRENCİ NUMARASI.......:G211210051
**              DERSİN ALINDIĞI GRUP...:2B
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proje
{
    class sifreOlustur
    {
        static void Main(string[] args)
        {
            //Gerekli karakter dizilerini tanımladım.
            string[] kucukHarf = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r",
                "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] buyukHarf = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] rakam = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] sembol = { ".", ",", ":", ";", "-", "!", "#", "$", "%", "&", "/", "?", "*", "+", "^", "`", "'", "£", "=", "(", ")", "[", "]", "<", ">", "|", "´@", "_", "{", "}" };

            //Gerekli değişkenleri tanımladım.
            string sifre;
            int puan = 0;
            int buyukHarfSayisi = 0;
            int kucukHarfSayisi = 0;
            int sembolSayisi = 0;
            int rakamSayisi = 0;
            
            
            //Şifre gereken şartları sağlamadığında kullanıcıdan tekrar veri almak için do-while döngüsü kullandım.

            do                                  
            {
                Console.WriteLine("Lütfen Şifrenizi Giriniz:");   //Kullanıcıdan veri girmesini istedim.
                sifre = Console.ReadLine();                       //Kullanıcının girdiğiveriyi aldım.


                //Şifrede kullanılan büyük harf sayısını buldum.
                for (int i = 0; i < sifre.Length; i++)
                {
                    for (int j = 0; j < buyukHarf.Count(); j++)
                    {
                        if (sifre[i].ToString() == buyukHarf[j])
                        {
                            buyukHarfSayisi = buyukHarfSayisi + 1;
                        }
                    }
                }

                //Şifrede kullanılan küçük harf sayısını buldum.
                for (int i = 0; i < sifre.Length; i++)
                {
                    for (int j = 0; j < kucukHarf.Count(); j++)
                    {
                        if (sifre[i].ToString() == kucukHarf[j])
                        {
                            kucukHarfSayisi = kucukHarfSayisi + 1;
                        }
                    }
                }

                //Şifrede kullanılan sembol sayısını buldum.
                for (int i = 0; i < sifre.Length; i++)
                {
                    for (int j = 0; j < sembol.Count(); j++)
                    {
                        if (sifre[i].ToString() == sembol[j])
                        {
                            sembolSayisi = sembolSayisi + 1;
                        }
                    }
                }

                //Şifrede kullanılan rakam sayısını buldum.
                for (int i = 0; i < sifre.Length; i++)
                {
                    for (int j = 0; j < rakam.Count(); j++)
                    {
                        if (sifre[i].ToString() == rakam[j])
                        {
                            rakamSayisi = rakamSayisi + 1;
                        }
                    }
                }
               
                //Şifre 9 karakter ve daha fazlası olursa olması gereken diğer şartı sağlamasını istedim.
                if (sifre.Count() >= 9)
                {
                    if (kucukHarfSayisi == 0 || (buyukHarfSayisi == 0) || (rakamSayisi == 0) || (sembolSayisi == 0))
                        Console.WriteLine("Şifreniz en az bir küçük harf,bir büyükharf, bir rakam bir sembol içermelidir ve en az 9 karakter uzunluğunda olmalıdır.");

                    else
                        Console.WriteLine("Şifre Kullanıma Uygun.");
                }


                //Şifre uzunluğu ve içeriği uygun olduğunda ekrana yazılacak değerleri yazdım.
                if (sifre.Count() >= 9)
                {
                    Console.WriteLine("Kullanılan Küçük Harf Sayısı: {0}", kucukHarfSayisi);
                    Console.WriteLine("Kullanılan Büyük Harf Sayısı: {0}", buyukHarfSayisi);
                    Console.WriteLine("Kullanılan Rakam Sayısı:{0}", rakamSayisi);
                    Console.WriteLine("Kullanılan Sembol Sayısı:{0}", sembolSayisi);
                }

                //Şifre uygun olmadığında ekrana yazılacak ifadeyi yazdım.
                else
                {
                    Console.WriteLine("Şifreniz 9 veya daha uzun karakterli olmalıdır ve en az bir küçük harf,bir büyükharf, bir rakam ,bir sembol içermelidir");
                }


            } while (sifre.Count() >= 9 && buyukHarfSayisi == 0 || sifre.Count() >= 9 && kucukHarfSayisi == 0  || sifre.Count() >= 9 && sembolSayisi == 0 || sifre.Count() >= 9 && rakamSayisi == 0 || sifre.Count() <= 9);


            //Büyük harf sayısına göre puan üzerinde yapılacak işlemi yazdım. 
            if (buyukHarfSayisi <= 2)
                for (int i = 0; i < buyukHarfSayisi; i++)
                {
                    puan = puan + 10;

                }
            else if (buyukHarfSayisi > 2)
                puan = puan + 20;

            //Küçük harf sayısına göre puan üzerinde yapılacak işlemi yazdım. 
            if (kucukHarfSayisi <= 2)
                for (int i = 0; i < kucukHarfSayisi; i++)
                {
                    puan = puan + 10;

                }
            else if (kucukHarfSayisi > 2)
                puan = puan + 20;

            //Rakam sayısına göre puan üzerinde yapılacak işlemi yazdım. 
            if (rakamSayisi <= 2)
                for (int i = 0; i < rakamSayisi; i++)
                {
                    puan = puan + 10;

                }
            else if (rakamSayisi > 2)
                puan = puan + 20;

            //Sembol sayısına göre puan üzerinde yapılacak işlemi yazdım. 
            for (int i = 0; i < sembolSayisi; i++)
            {
                puan = puan + 10;

            }

            //Şifre 9 karakterden oluşuyorsa puan üzerinde yapılacak işlemi yazdım.
            if (sifre.Count() == 9)
            {
                puan = +10;
                Console.WriteLine("Şifreniz 9 karakterli olduğundan +10 puan kazandınız.");
            }



            Console.WriteLine("Toplam puan:" + puan);   //Toplam puanı ekrana yazdırdım.

            //Şifrenin kabul edileceği puan aralığını sağlamasını istedim.
            if (puan >= 70)
            {
                Console.WriteLine("Şifre Kabul Edildi.");

                if (puan >= 90)
                {
                    Console.WriteLine("Güçlü Şifre ");
                }
                else if (puan < 90 & puan >= 70)
                {
                    Console.WriteLine("Orta Derecede Güçlü Şifre ");
                }

            }
            //Şifrenin kabul edilmeme durumu için ekrana yazılacak ifadeyi yazırdım. 
            else
            {
                Console.WriteLine("Güçsüz Şifre Kabul Edilemez.");
               
            }



           Console.ReadKey();  //Programı sonlandırdım.

        }


    }


}















