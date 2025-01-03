using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region   If Else
			//Console.WriteLine("Lütfen şifreyi giriniz:");
			//string password;
			//password = Console.ReadLine();
			//if (password == "abcd")
			//{
			//	Console.WriteLine("Şifre doğru");
			//	Console.ReadKey();

			//}
			//else
			//{ Console.WriteLine("Şifre yanlış");
			//	Console.ReadKey();

			//}

			//string capital, country;
			//Console.WriteLine("Başkenti Giriniz:");
			//capital = Console.ReadLine();

			//Console.WriteLine("Ülkeyi Giriniz:");
			//country = Console.ReadLine();

			//if (capital == "ankara" && country == "türkiye")
			//{

			//	Console.WriteLine("Veriler doğrulandı:");


			//}
			//else
			//{
			//	Console.WriteLine("Hatalı bilgi");

			//}
			//Console.ReadKey();

			//int number;
			//Console.WriteLine("Sayı giriniz:");
			//number = int.Parse(Console.ReadLine());

			//if (number == 5)
			//{
			//	Console.WriteLine("Sayı doğru");
			//	Console.ReadLine();
			//}
			//else
			//{
			//	Console.WriteLine("Sayı Hatalı:");

			//}
			//Console.ReadLine();

			//int exam1, exam2, exam3, average;
			//string result = "HATA";

			//Console.Write("Sınav1     :");
			//exam1 = int.Parse(Console.ReadLine());

			//Console.Write("Sınav2     :");
			//exam2 = int.Parse(Console.ReadLine());

			//Console.Write("Sınav3      :");
			//exam3 = int.Parse(Console.ReadLine());

			//average = (exam1 + exam2 + exam3) / 3;
			//Console.Write("Sınavların ortalaması:   " + " " + average);

			//if (average > 0 & average <= 50)
			//{
			//	result = "Sonuç VASAT";
			//}
			//if (average > 50 & average <= 70)
			//{
			//	result = "Sonuç ORTA";

			//}
			//if (average > 70 & average <= 84)
			//{
			//	result = "Sonuç İYİ";

			//}
			//if (average > 84)
			//{

			//	result = "Sonuç ÇOK İYİ";
			//}
			//Console.WriteLine(result);
			//Console.Read();


			//string city;
			//Console.Write("Lütfen Şehir Giriniz: ");
			//city= Console.ReadLine();

			//if (city == "adana" | city == "bursa" | city == "trabzon") 

			//{
			//	Console.WriteLine("Şehir Mevcut");
			//	Console.ReadLine();

			//}
			//else
			//{
			//	Console.WriteLine("Şehir Mevcut Değil");
			//	Console.ReadLine();
			//}

			//Console.Write("Lütfen Kullanıcı Adı Giriniz:");
			//string username=Console.ReadLine();
			//if(username !="admin")
			//{
			//	Console.WriteLine("Girilen İsim Yanlış");
			//}
			//else
			//{
			//	Console.WriteLine("HOŞGELDİNİZ");
			//}

			//Console.ReadLine();
			#endregion

			#region  Mod İşlemleri

			//int number;
			//number = 26;
			//int result = number % 5;
			//Console.WriteLine(result);
			//Console.ReadLine();


			//Console.Write("Lütfen 1. Sayıyı Giriniz:");
			//int sayı1=int.Parse(Console.ReadLine());


			//Console.Write("Lütfen 2. Sayıyı Giriniz:");
			//int sayı2 = int.Parse(Console.ReadLine());
			//int result = sayı1 % sayı2;
			//Console.Write("1. Sayının 2.Sayıya Bölümünden Kalan: " + result);
			//Console.ReadLine();

			//Console.Write("Lütfen sayı giriniz");
			//int sayı =int.Parse(Console.ReadLine());

			//if (sayı% 2 ==0 )
			//{
			//	Console.Write("sayı çifttir");
			//	Console.Read();	

			//}
			//else
			//{
			//	Console.Write("sayı tektir");


			//}

			//Console.ReadKey();


			//Console.WriteLine("Lütfen takım sembolünü giriniz");
			//char team=char.Parse(Console.ReadLine());	

			//if (team =='g')
			//{
			//	Console.WriteLine("Galatasaray");
			//	Console.ReadKey();
			//   }
			//if (team == 'f')
			//{
			//	Console.WriteLine("Fenerbahçe");
			//	Console.ReadKey();

			//}
			//if (team == 'b')
			//{
			//	Console.WriteLine("Beşiktaş");
			//	Console.ReadKey();
			//}
			#endregion

			#region Örnek Proje Uygulaması

			//Console.WriteLine("******* c# Eğitim Kampı Restoran *******");
			//Console.WriteLine("");
			//Console.WriteLine("------------------------------------------");
			//Console.WriteLine("1-Ana Yemekler");
			//Console.WriteLine("2-Çorbalar");
			//Console.WriteLine("3-Pizzalar");
			//Console.WriteLine("4-İçecekler");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("------------------------------------------");
			//Console.WriteLine();

			//string menuItem;

			//Console.Write("Detayını görmek istediğnizmenüyü seçin:     ");
			//menuItem = Console.ReadLine();

			//if (menuItem =="1")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("******Ana Yemekler******");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Köri soslu tavuk");
			//	Console.WriteLine("2-Kızartma Tabağı");
			//	Console.WriteLine("3-Fasülye Pilav");
			//	Console.WriteLine("4-Fırında Somon");
			//	Console.WriteLine("5-Patlıcan Musakka");
			//	Console.WriteLine("******Ana Yemekler******");
			//	Console.WriteLine();
			//}
			//if (menuItem == "2")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("******Çorbalar******");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Mercimek Çorbası");
			//	Console.WriteLine("2-Ezogelin Çorbası");
			//	Console.WriteLine("3-Yayla Çorbası");
			//	Console.WriteLine("******Çorbalar******");
			//	Console.WriteLine();
			//}
			//if (menuItem == "3")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("******Pizzalar******");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Margarita");
			//	Console.WriteLine("2-Tavukl Pizza");
			//	Console.WriteLine("3-Karışık Pizza");
			//	Console.WriteLine("******Pizzalar******");
			//	Console.WriteLine();
			//}
			//if (menuItem == "4")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("******İçecekler******");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Kola");
			//	Console.WriteLine("2-Ayran");
			//	Console.WriteLine("3-Limonata");
			//	Console.WriteLine("******İçecekler******");
			//	Console.WriteLine();
			//}
			//if (menuItem == "5")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("******Tatlılar******");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Sütlaç");
			//	Console.WriteLine("2-Kazandibi");
			//	Console.WriteLine("3-Baklava");
			//	Console.WriteLine("******Tatlılar******");
			//	Console.WriteLine();
			//}
			//Console.ReadLine();

			#endregion

			#region Switch Case


			//Console.WriteLine("Lütfen Ay Girişi Yapınız");
			//int mounthNumber =int.Parse(Console.ReadLine());

			//switch (mounthNumber)
			//{
			//	case 1: Console.Write("Ocak");break;
			//	case 2: Console.Write("Şubat"); break;
			//	case 3: Console.Write("Mart"); break;
			//	case 4: Console.Write("Nisan"); break;
			//	case 5: Console.Write("Mayıs"); break;
			//	case 6: Console.Write("Haziran"); break;
			//	case 7: Console.Write("Temmuz"); break;
			//	case 8: Console.Write("Ağustos"); break;
			//	case 9: Console.Write("Eylül"); break;
			//	case 10: Console.Write("Ekim"); break;
			//	case 11: Console.Write("Kasım"); break;
			//	case 12: Console.Write("Aralık"); break;
			//	default: Console.Write("Hatalı Veri Girişi!");
			//		break;
//}

			//Console.ReadKey();

			#endregion

			#region Switch Hesap Makinesi

			//int number1, number2, result;
			//char symbol;

			//Console.WriteLine("1.Sayıyı Giriniz:  ");
			//number1 =int.Parse(Console.ReadLine());

			//Console.WriteLine("2.Sayıyı Giriniz:  ");
			//number2 = int.Parse(Console.ReadLine());

			//Console.WriteLine("Lütfen Yapmak İsteiğiz İşlemi Giriniz:  ");
			//symbol = char.Parse(Console.ReadLine());


			//switch (symbol)
			//{
			//	case '+':
			//		result=number1+ number2;
			//		Console.WriteLine("Toplam: " + result);
			//		break;

			//	case '-':
			//		result = number1 - number2;
			//		Console.WriteLine("Fark: " + result);
			//		break;


			//	case '/':
			//		result = number1 / number2;
			//		Console.WriteLine("Bölüm: " + result);
			//		break;

			//	case '*':
			//		result = number1 * number2;
			//		Console.WriteLine("çarpım: " + result);
			//		break;

			//}

			//Console.ReadLine();
			#endregion




		}

	}

}




		

