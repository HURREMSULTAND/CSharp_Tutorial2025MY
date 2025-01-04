using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Metotlar
			//()
			//Geriye Değer Döndürmeyen Metotlar
			//Customer --> Lİstele,ekle,sil,güncelle
			//void anahtar kelimesi


			//void CustomerList()
			//{

			//	Console.WriteLine("Ali Yıldız");
			//	Console.WriteLine("Ayşe Yıldız");
			//	Console.WriteLine("Hakan Öztürk");
			//	Console.WriteLine("Merve Çınar");
			//}
			//CustomerList();
			//CustomerList();
			//CustomerList();
			//CustomerList();


			//	void sum()
			//{
			//	int x = 1;
			//	int y=2;
			//	int z = x + y;
			//	Console.WriteLine(z);
			//}

			//sum();

			#endregion

			#region Geriye Değer Döndürmeyen string PArametreli Metotlar


			//void WriteMethod(string customerNmae)
			//{
			//	Console.WriteLine(customerNmae);

			//}
			//WriteMethod("Mehmet Yıldırım");

			// void customerCart (string name,string surname)
			//{

			//	Console.WriteLine("müşteri: " + name + " " + surname);
			//}

			//customerCart("Mehmet", "Yıldız");
			//customerCart("Ayşegül"," Kaya");
			#endregion



			#region  Geriye Değer Döndürmeye Parametreli Metotlar

			//void sum(int number1, int number2, int number3)
			//{

			//	int result = number1 + number2 + number3;
			//		Console.WriteLine(result);

			//}
			//sum(4, 6, 45);
			#endregion


			#region Geriye DEğer Döndüren Metotlar

			//string CustomerName()
			//{ return "hürrem sultan ";
			//}

			//CustomerName();



			//string studentCard ()
			//{
			//	string name = "ali";
			//	string surName = "Yıldız";

			//	return name + " " + " " + surName;
			//}

			//Console.WriteLine(studentCard ());





			#endregion


			#region #region Geriye DEğer Döndüren  String Parametreli Metotlar

			//		string CountryCard (string countryName, string capital , string flagColor) 
			//		{
			//			string cardInfo = "Ülke" + countryName + " - Başkent "
			//+ capital + "- Bayrak Rengi" + flagColor;
			//			return cardInfo;
			//		}

			//		string x, y, z;
			//		Console.Write("Ülke Adını Giriniz:    ");
			//		x= Console.ReadLine();
			//		Console.Write("Ülke Başkentini Giriniz:    ");
			//		y= Console.ReadLine();
			//		Console.WriteLine("ülke bayrak rengini giriniz");
			//		z= Console.ReadLine();

			//		Console.WriteLine(CountryCard(x, y, z));

			//		Console.WriteLine(CountryCard("türkiye", "Ankara", "Kırmızı- Beyaz"));



			#endregion


			#region #region Geriye DEğer Döndüren  Int PArametreli Metotlar


   //         int Sum(int number1, int number2) 
			//{
			//int result =number1 + number2;
			//	return result;
			
			//}
			//Console.WriteLine(Sum(45,90));
			//Console.WriteLine(Sum(36,25));
			//Console.WriteLine(Sum(44,36));
			//Console.WriteLine(Sum(14,20));


		

		
			#endregion


				 string ExamResult(string student ,int exam1, int exam2,int exam3) 
			     {
			   int result=(exam1+ exam2+ exam3)/3;
				if (result >= 50)
				{
					return  student + "  İsimli Öğrenci Geçti  " +	"Ortalama: "+ result;
				}
                else
                {
					return student + "  İsimli Öğrenci Kaldı  " + "Ortalama: " + result;
				}

                 } 
			Console.WriteLine(ExamResult("Ali", 25, 41, 85));
			Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

			Console.ReadLine();


		}
	}
}
