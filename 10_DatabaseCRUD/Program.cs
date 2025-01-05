using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Crud-->Create-Read-Update-Delete

			Console.WriteLine("*****Menü sipariş İşlem Paneli*****");
			Console.WriteLine();
            Console.WriteLine("--------------------------------------");
			#region Kategori Ekleme İşlemi

			//Console.WriteLine("Eklemek istediğiniz kategori adı:  ");
			//string categoryName=Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=EğitimKampıDB;integrated security=true");


			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblCategory (categoryName) values (@p1)", connection);
			//command.Parameters.AddWithValue("@p1", categoryName);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.WriteLine("Kategori başarı ile eklendi!");
			#endregion

			#region  Ürün Ekleme İşlemi



			//bool productStatus;


			//Console.Write("Ürün Adı :   ");
			//productName=Console.ReadLine();
			//Console.Write("Ürün Fiyatı:   ");
			//productPrice=decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=EğitimKampıDB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
			//command.Parameters.AddWithValue("productName", productName);
			//command.Parameters.AddWithValue("productPrice", productPrice);
			//command.Parameters.AddWithValue("productStatus",true);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Ürün eklemesi başarılı!");
			#endregion
			#region Ürün Listeleme İşlemi

			//SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=EğitimKampıDB;integrated security=true");

			//connection.Open();
			//SqlCommand command = new SqlCommand("select  * from TblProduct", connection);
			//SqlDataAdapter adapter= new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);


			//foreach (DataRow row in dataTable.Rows) 
			//{
			//foreach (var item in row.ItemArray) 
			//	{
			//	Console.Write(item.ToString()+ " ");
			//	}
			//Console.WriteLine();

			//}

			//connection.Close();
			#endregion

			#region Ürün Silme İşlemi
			//Console.WriteLine("Silinecek olan ürün Id:  ");
			//int productId=int.Parse(Console.ReadLine());

			//SqlConnection connection=new SqlConnection("Data source=.\\SQLEXPRESS;initial Catalog=EğitimKampıDB;integrated security=true");
			//         connection.Open();

			//SqlCommand command = new SqlCommand("Delete from TblProduct where productId=@productId", connection);
			//command.Parameters.AddWithValue("productId", productId);
			//command.ExecuteNonQuery();

			//connection.Close();

			//Console.WriteLine("Silme işlemi tamamlandı!");
			#endregion



			#region Ürün Güncelleme İşlemi


			Console.Write("Güncellenecek ürün Id:  ");
			int productId=int.Parse(Console.ReadLine());

			Console.Write("Güncellenecek ürün Adı:  ");
			string productName = (Console.ReadLine());


			Console.Write("Güncellenecek ürün Fiyatı:  ");
			decimal productPrice = decimal.Parse(Console.ReadLine());


			SqlConnection connection = new SqlConnection("Data source=.\\SQLEXPRESS;initial Catalog=EğitimKampıDB;integrated security=true");
			connection.Open();
			SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,productPrice=@productPrice where productId=@productId", connection);
			_ = command.Parameters.AddWithValue("@productName", productName);
			_ = command.Parameters.AddWithValue("@productPrice", productPrice);
			command.Parameters.AddWithValue("@productId", productId);
			command.ExecuteNonQuery();

			Console.WriteLine("Güncelleme Başarılı!");



			#endregion

			Console.ReadLine();
		}
	}
}

