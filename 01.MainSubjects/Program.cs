using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region   YazdırmaKomutları

			//Console.Write("Merhaba Dünya");
			//Console.WriteLine("Selam");
			//Console.WriteLine("Hürrem");

			//Console.WriteLine("*****Yemek Kategorileri*****");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("3-Salatalar");
			//Console.WriteLine("4-Soğuk Başlangıçlar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-İçecekler");
			//Console.WriteLine();
			//Console.WriteLine("*****Yemek Kategorileri*****");
			#endregion

			#region  StringDeğişkenler
			//string
			//Değişken_türü değişken adı;

			//string name;
			//name = "Hürrem";
			//Console.Write(name);

			//string customerName;
			//string customerSurname;
			//string customerPhone;
			//string customerEmail, district, city;

			//customerName = "Hürrem Sultan";
			//customerSurname = "Dikmen";
			//customerPhone = "+90 500 20 23 ";
			//customerEmail = "deneme@gmail.com";
			//district = "Esenler";
			//city = "İstanbul";
			//Console.WriteLine("****Rezervasyon Kartı****");
			//Console.WriteLine();
			//Console.WriteLine("---------------------------------------");
			//Console.WriteLine("Müşteri:" + customerName +" " + customerSurname);
			//Console.WriteLine("İletişim:" + customerPhone);
			//Console.WriteLine("Email Adresi:" + customerEmail);
			//Console.WriteLine("Adres:" + district + " " +city);
			//Console.WriteLine("---------------------------------------");
			#endregion

			#region IntDeğişkenler

			//int
			//int number =24;
			//Console.Writelline(number);

			int hamburgerPrice= 300;
			int CokePrice = 35;
			int friesPrice = 50;
			int waterPrice = 10;
			int pizzaPrice = 250;
			int lemonadePrice = 30;

			Console.WriteLine("******* Restoran Menü Fiyatı *********");
			Console.WriteLine();
			Console.WriteLine("------HAMBURGER:" + hamburgerPrice + "TL");
			Console.WriteLine("------PİZZA:" + pizzaPrice + "TL");
			Console.WriteLine("------KIZARTMA:" + friesPrice +"TL");
			Console.WriteLine("------COLA:" + CokePrice + "TL");
			Console.WriteLine("------SU:"+  waterPrice + "TL");
			Console.WriteLine("------LİMONATA:"+ lemonadePrice + "TL");
			Console.WriteLine(" ");
			Console.WriteLine("******* Restoran Menü Fiyatı *********");


			Console.WriteLine();

			int hamburgerCount;
			int pizzaCount;
			int friesCount;
			int waterCount;
			int lemonadeCount;
			int cokeCount;

			int totalHamburgerPrice = 0;
			int totalFriesPrice = 0;
			int totalWaterPrice = 0;
			int totalLemonatePrice= 0;
			int totalPizzaPrice = 0;
			int totalCokePrice = 0;
		

			hamburgerCount = 3;
			pizzaCount = 0;
            friesCount = 1;
			waterCount = 3;
			lemonadeCount = 0;
			cokeCount = 3;

			Console.WriteLine("-----------------------------------");//görsel amaçlı
			Console.WriteLine();


			totalHamburgerPrice = hamburgerCount * hamburgerPrice ;
			totalFriesPrice= friesCount * friesPrice;
			totalWaterPrice= waterCount * waterPrice;
			totalPizzaPrice= pizzaCount * pizzaPrice;
			totalCokePrice = cokeCount * CokePrice;
			totalLemonatePrice = lemonadeCount * lemonadePrice;


			Console.WriteLine();
			Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL");
			Console.WriteLine("Kola Tutarı:" + totalCokePrice + "TL");
			Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL");
			Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + "TL");
			Console.WriteLine("Su Tutarı:" + totalWaterPrice + "TL");
			Console.WriteLine("Limonata Tutarı:" + totalLemonatePrice + "Tl");
			Console.WriteLine();

			int toplamTutar = 0;
			toplamTutar = totalCokePrice + totalFriesPrice + totalWaterPrice + totalHamburgerPrice + totalLemonatePrice + totalPizzaPrice; ;

			Console.WriteLine("***************Toplam Tutar:" + toplamTutar +"*****************");
			;
             #endregion

			Console.Read();
		}
	}
}




// Yazdırma Komutları