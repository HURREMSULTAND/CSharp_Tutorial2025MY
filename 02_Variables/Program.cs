using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region DoubleDeğişkenler
			//double number;
			//number = 4.85;
			//Console.WriteLine(number);

			//Console.OutputEncoding = System.Text.Encoding.UTF8;
			//string tl;
			//tl = "\u20BA";

			//Console.WriteLine("********Fiyat Listesi********");
			//Console.WriteLine();

			//double applePrice, orangePrice, strawberryPrice, tomatoPrice;
			//applePrice = 14.85;
			//orangePrice = 20.45;
			//strawberryPrice = 56.21;
			//tomatoPrice = 63.10;


			//Console.WriteLine("-------Elma birim fiyatı:" + applePrice +  tl);
			//Console.WriteLine("-------Portakal birim fiyatı:" + orangePrice + tl);
			//Console.WriteLine("-------Çilek birim fiyatı:" + strawberryPrice + tl);
			//Console.WriteLine("-------Domates birim fiyatı:" + tomatoPrice + tl);

			//double appleGram , orangeGram,strawberryGram,tomatoGram; ;
			//appleGram = 1.254;
			//orangeGram =6.123;
			//strawberryGram = 0.250;
			//tomatoGram = 2.142;

			//double totalApple=appleGram*appleGram; ;
			//double totalOrange=orangeGram*orangeGram; 
			//double totalStrawberry=strawberryPrice*strawberryPrice;
			//double totalTomato = tomatoGram * tomatoPrice;

			//Console.WriteLine("Toplam Domates Fiyatı:   " + totalTomato);
			//Console.WriteLine("Toplam Elma Fiyatı:      " + totalApple);
			//Console.WriteLine("Toplam Çilek Fiyatı:     " + totalStrawberry);
			//Console.WriteLine("Toplam Portakal Fiyatı:  " + totalOrange);

			//double toplamAlışVerişTutarı = 0;
			//toplamAlışVerişTutarı = totalTomato + totalStrawberry + totalApple + totalStrawberry;

			//Console.WriteLine("--------------------------------------------------------------");
			//Console.WriteLine("Ödenecek Alış Veriş Tutarınız:" + toplamAlışVerişTutarı);
			//         Console.ReadLine();
			#endregion


			#region ÇarDeğişkenler

			//char symbol;
			//symbol='a';
			//	Console.WriteLine(symbol);
			//Console.ReadLine();

			#endregion

			#region Klavyeden Veri Girişi String Değişkenler

			//Console.WriteLine("*********C# Hava Yolları Yolcu Bilgisi********");
			//Console.WriteLine();

			//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

			//Console.Write("Yolcu Adı: ");
			//passengerName=Console.ReadLine();

			//Console.Write("Yolcu Soyadı: ");
			//passengerSurname = Console.ReadLine();

			//Console.Write("İlçe Bilgisi: ");
			//passengerDistrict= Console.ReadLine();

			//Console.Write("Şehir Bilgisi:");
			//passengerCity= Console.ReadLine();

			//Console.Write("Yolcu Yaşı:");
			//passengerAge = Console.ReadLine();

			//Console.Write("Yolcu Numarası:");
			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine();

			//Console.WriteLine("---------------------------");


			//Console.WriteLine("Yolcu Numarası:" +  "" + passengerIdentityNumber);


			//Console.WriteLine("Yolcu Adı Soyadı:" + " "   + passengerName +"" + passengerSurname);


			//Console.WriteLine("Yolcu Adresi:" +  passengerDistrict + "/"+ passengerCity);

			//Console.WriteLine("Yolcu yaşı:" + passengerAge);

			//Console.ReadLine();
			#endregion

			#region Klavyeden Tam Sayı Girişleri ve Dönüşümler

			//	int shoesPrice, computerPrice, tvPrice, chairPrice;
			//	shoesPrice = 1000;
			//	computerPrice = 20000;
			//	tvPrice = 12000;
			//	chairPrice = 5000;

			//	int shoesCount = 0;
			//	int computerCount = 0;
			//	int tvCount = 0;
			//	int chairCount = 0;

			//	Console.Write("Lütfen aldığınız Ayakkabı sayısını giriniz:");
			//	shoesCount = int.Parse(Console.ReadLine());

			//	Console.Write("Lütfen aldığınız Koltuk sayısını giriniz:");
			//	chairCount = int.Parse(Console.ReadLine());

			//	Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz:");
			//computerCount = int.Parse(Console.ReadLine());

			//	Console.Write("Lütfen aldığınız TV sayısını giriniz:");
			//	tvCount = int.Parse(Console.ReadLine());


			//	 int totalShoes = shoesCount * shoesPrice;
			//	 int totalChair =chairCount * chairPrice;
			//	 int totalComputer =computerCount * computerPrice;
			//	 int totalTV =tvCount * tvPrice;

			//	int toplamAlışVeriş = totalComputer + totalTV + totalComputer + totalShoes;
			//	Console.WriteLine();

			//	Console.WriteLine("Yapılan toplam Alışveriş Tutarı:" + toplamAlışVeriş);
			//	Console.ReadKey();




			#endregion


			#region   Klavyeden Double Sayı İşlemleri 

			//double vize , final = 0;
			//Console.WriteLine("Lütfen vize notunu giriniz:");
			// vize =double.Parse(Console.ReadLine());


			//Console.WriteLine("Lütfen final notunu giriniz:");
			//final = double.Parse(Console.ReadLine());

			//double ortalamaHesapla = 0;
			//ortalamaHesapla = (vize * 0.30) + (final * 0.70);

			//Console.WriteLine("Bu Dersten Ortalamanız:" +  ortalamaHesapla);
			//Console.ReadKey();
			#endregion

			#region  Klavyeden Cinsiyet Girişi
			char gender;
			Console.WriteLine("Lütfen cinsiyet seçiniz:");
			gender=char.Parse(Console.ReadLine());

			Console.WriteLine("Seçtiğiniz cinsiyet:" + ""  + gender);
			Console.ReadLine();
			#endregion











		}
	}
}
