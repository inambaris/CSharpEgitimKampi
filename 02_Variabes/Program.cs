using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variabes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //double applePrice, strawberryPrice, potatoPrice, orangePrice;

            //applePrice = 2.5;
            //orangePrice = 3.5;
            //strawberryPrice = 5.5;
            //potatoPrice = 1.5;

            //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice);

            //double appleGram, strawberryGram, potatoGram, orangeGram;

            //appleGram = 250.5;
            //strawberryGram = 500.5;
            //orangeGram = 300.5;
            //potatoGram = 1000.5;

            //double appleTotalPrice, strawberryTotalPrice, potatoTotalPrice, orangeTotalPrice;
            //appleTotalPrice = applePrice * appleGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //potatoTotalPrice = potatoPrice * potatoGram;
            //orangeTotalPrice = orangePrice * orangeGram;

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Elma, Alınan Gram: " + appleGram + " Alınan Fiyat: " + appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal, Alınan Gram: " + orangeGram + " Alınan Fiyat: " + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek, Alınan Gram: " + strawberryGram + " Alınan Fiyat: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates, Alınan Gram: " + potatoGram + " Alınan Fiyat: " + potatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");

            //double totalPrice = appleTotalPrice + strawberryTotalPrice + potatoTotalPrice + orangeTotalPrice;
            //Console.WriteLine("Toplam Alınan Ürünlerin Fiyatı: " + totalPrice);
            #endregion

            #region Char Değişkenler

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgi Sistemi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber, passengerPhoneNumber;

            //Console.Write("Yolcu adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu ilçesi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu şehri:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu yaşı:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu kimlik numarası:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu telefon numarası:");
            //passengerPhoneNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Yolcu Bilgileri - " + " İsim :" + passengerName + " Soyisim: " + passengerSurname + " İlçe: " + passengerDistrict + " İstanbul" + passengerCity + " Yaş: " + passengerAge + " TC No:" + passengerIdentityNumber + " Tel no: " + passengerPhoneNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 5000;
            //chairPrice = 1500;
            //tvPrice = 3000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoePrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice + "TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri ve Dönüşümler

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama not: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri ve Dönüşümler

            char gender;
            Console.WriteLine("Lütfen cinsiyetinizi giriniz (E/K): ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
