using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Döngüler
			//for(x;y;z)
			//x: başlangıç
			//y:bitiş
			//z:artış-azalış

			//int i;
			//for(i=1; i<=5; i++) 
			//{
			//	Console.WriteLine("hürrem ");
			//}

			//for (int i = 1; i < 20; i++)
			//{
			//	Console.WriteLine(i);
			//}

			//for (int i = 3; i <=50 ; i+=3)
			//{
			//	Console.WriteLine(i);
			//}

			//Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz mitarı giriniz:");
			//int finishValue=int.Parse(Console.ReadLine());

			//for (int i = 1; i <=finishValue; i++)
			//{
			//	Console.WriteLine("Yaşasın Cumhuriyet");
			//}



			#endregion

			#region For Döngüsü Karar Yapıları

			//for (int i = 1; i <= 100; i++)
			//{
			//	if (i%5 ==0) 
			//	{
			//		Console.WriteLine(i);
			//	}

			//}

			//int totalValue = 0;
			//for (int i = 1; i <=10; i++)
			//{
			//	totalValue += i;

			//}
			//Console.WriteLine(totalValue);

			//int totalValue = 0;
			//for (int i = 1; i < 20; i++)
			//{
			//	if (i%2 ==0)
			//	{
			//		totalValue += i;
			//		Console.WriteLine(i);
			//	}
			//}


			//int sayac = 0;

			//for (int i = 1; i <=60; i++)
			//{
			//	if (i % 7 == 0)
			//	{
			//		sayac++;
			//	}
			//}
			//Console.WriteLine(sayac);


			//int bacterium = 1;

			//for (int i = 1; i <=24; i++)
			//{
			//	bacterium *= 2;
			//	Console.WriteLine(i + ". saat sonunda " + bacterium + "  vardır");
			//}

			#endregion

			#region While Döngüsü

			//While (Şart
			//{
			//}

			//int i = 1;
			//while(i<=10)
			//{
			//	Console.WriteLine("Merhaba döngüler");
			//	i++;
			//}

			//int i = 1;
			//while (i <=10) 
			//{
			//	if (i %3==0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//	i++;
			//}


			//int i = 1;
			//int sum = 0;

			//while (i <=10)
			//{
			//	sum += i;
			//	i++;
			//}

			//Console.WriteLine(sum);




			#endregion

			#region Örnek Sınav Sorusu
			// klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

		
			//Console.WriteLine("3 Basamaklı bir sayı giriniz:");
			//int sayı=int.Parse(Console.ReadLine());

			//int ones, tens, hundreds;
			//int sum;

			//ones = sayı % 10;
			//tens = sayı / 100;
			//hundreds = (sayı % 100)/10;
			//sum = ones + tens + hundreds;

			//if (sayı>=100)
			//{

			//	Console.WriteLine(ones + "-" + tens + "-" + hundreds);
			//	Console.WriteLine("Toplam: " + sum);
				

			//}
			//if (sayı<100)

			//{
			//	Console.WriteLine("HATA!!!! Lütfen 3 basamaklı bir sayı giriniz");
			//}


			#endregion


			Console.ReadKey();



		}
	}
}
