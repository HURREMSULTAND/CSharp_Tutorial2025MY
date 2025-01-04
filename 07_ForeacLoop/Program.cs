using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeacLoop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Foreach Döngüsü

			// Foreach(1;2;3;4)

			//1:Değişken türü
			//2:Değişken Adı
			//3:In
			//4:Liste,Koleksiyon,Dizi
			//!!!!!! En Önemli Özellik Başlangıç bitiş değeriyle uğraşmaya gerek yok direk yazdırılabilir!!!!!!!!!!!

			//string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

			//foreach (string x in cities) 
			//{
			//Console.WriteLine(x);
			//}


			//Console.ReadLine();



			//int[] numbers = { 45, 78, 985, 635, 74, 11, 6589, 4125, 2103698 };

			//foreach (int  number in numbers)
			//{
			//Console.WriteLine(number);
			//}


			//int[] numbers = { 45, 78, 985, 635, 74, 11, 6589, 4125, 2103698 };

			//foreach (int number in numbers) 
			//{
			//	if (number % 2 == 0)
			//	{  Console.WriteLine(number); }

			//}


			//int[] numbers = { 45, 78, 985, 635, 74, 11, 6589, 4125, 2103698 };
			//int total = 0;

			//foreach (int number in numbers)
			//{
			//	total += number;
			//}
			//Console.WriteLine(total);


			//List<int> numbers = new List<int>()
			//{
			//	1,2,3,4,5,6
			//};
			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}


			//string word = "merhaba";

			//foreach  (char c in word)
			//{
			//	Console.WriteLine(c);
			//}

			#region Örnek Sınav Sistemi Uygulaması 
//			Console.Write("*********C# Eğitim kampı Sınav Uygulaması");
//				Console.WriteLine();
//				Console.WriteLine();
//				Console.WriteLine();
//				Console.WriteLine();
//				Console.WriteLine();

//			//sınıftaki çğrenci sayısını kullanıcıan alma
//			Console.WriteLine("-------------------------------------");
//				Console.Write("Sınıfınızda Kaç Öğrenci Var ?");
//			int studentCount=int.Parse(Console.ReadLine());
//			Console.WriteLine("--------------------------");

//			//Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
//			string[] studentCountNames = new string[studentCount];
//			double[] studentExamAvg = new double[studentCount];

//			for (int i =0; i<studentCount; i++)
//			{
//				Console.Write($"{i + 1} . öğrencinin ismini giriniz:   ")
//;
//				studentCountNames[i] = Console.ReadLine();

//				double totalExamResult = 0;

//				// her öğrenci için 3 sınav notu girişi 

//				for (int j = 0; j < 3; j++)
//				{
//					Console.Write($"{studentCountNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz:  ");
//					double value = double.Parse(Console.ReadLine());
//					totalExamResult += value;// notları tolama kısmı

//				}

//				studentExamAvg[i] = totalExamResult/3;
//			}

//			//sınav oratalamaları 
//			for (int i = 0; i < studentCount; i++)
//			{
//				Console.WriteLine($"{ studentCountNames[i]} adlı öğrencinin ortalaması: { studentExamAvg[i]}");


//				//Öğrenciilerin geçip kalma durumları
//				if (studentExamAvg[i]>=50)
//				{
//					Console.WriteLine($"{studentCountNames[i]} adlı öğrenci dersi geçti");
//				}
//				else
//				{

//					Console.WriteLine($"{studentCountNames[i]} adlı öğrenci dersten kaldı");
//				}

//				Console.WriteLine("-----------------------------------------------");
//			}




			#endregion


			Console.ReadLine();

			#endregion


		}
	}
}
