using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Alt Alta 10 Tane Yıldız Oluşturma

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.WriteLine("*");

			//}
			#endregion
			#region Yan YAna 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun.

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.Write("*");

			//}
			#endregion


			#region Alt Alta 10 Tane Yıldız Oluşturma her satırda 10 tane yıldız

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.WriteLine("**********");

			//}
			#endregion

			#region Dik Üçgen
			//for (int i = 1; i <=5 ; i++)
			//{
			//	for (int j = 1; j <=i ; j++)
			//	{
			//		Console.Write("*");

			//	}
			//	Console.WriteLine();
			//}
			#endregion
			#region Ters Dik Üçgen

			//for (int k = 4; k >=1 ; k--)
			//{
			//	for (int m = 1; m<=k; m++)
			//	{
			//		Console.Write("*");
			//	} Console.WriteLine();
			//}
			#endregion

			#region Dik ve ters Dik Üçgen Beraber
			//for (int i = 1; i <=5 ; i++)
			//{
			//	for (int j = 1; j <=i ; j++)
			//	{
			//	Console.Write("*");

			//	}
			//	Console.WriteLine();
			//}
			//for (int k = 4; k >=1 ; k--)
			//{
			//	for (int m = 1; m<=k; m++)
			//	{
			//		Console.Write("*");
			//	} Console.WriteLine();
			//}
			#endregion

			#region Baklava Dilimi

			//üst kısım
			//int n = 5;
			//for (int i = 1; i <=n; i++)
			//{
			//	for (int j= n-1; j >0 ; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for  (int k=1;  k<=2*i-1;   k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			//for (int i = n-1; i >=1 ; i--)
			//{
			//	for (int j = n-1; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= 2*i-1; k++)
			//	{
			//		Console.Write("*");
			//	}

			//	Console.WriteLine();
			//}
			#endregion

			#region Pramit
			//int n = 5;

			////BOŞLUKLAR İÇİN
			//for (int i = 1;  i <= n; i++) 
			//{
			//for (int j = n-i; j>0; j-- )
			//	{
			//		Console.Write(" ");

			//	}

			////yıldızlAR İÇİN
			//	for (int k = 1; k <=2*i-1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	for (int k = 1; k <=2*i-1;  k++)
			//	{

			//	}
			//	Console.WriteLine();

			//}

			#endregion

			#region Ters Pramit

			//int n = 5;
			//for (int i = n;  i>=1;  i--)
			//{
			//	//boşlıklar
			//	for (int j= n-i; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	//yıldızlar
			//	for (int k = 1; k <= 2*i-1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion


			Console.ReadLine();

		}
	}
}
