using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->create,read,update,delete

            Console.WriteLine("*** Menü Sipariş Etme Paneli");
            Console.WriteLine();

            Console.WriteLine("-------------");
            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek istediğiniz Kategori Adı:");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data source=WIN-9OO5RQ9OAPT\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategoryy (CategoryName) values (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarılı bir şekilde eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=WIN-9OO5RQ9OAPT\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=True"); ;

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı!");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source=WIN-9OO5RQ9OAPT\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=True"); ;
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi

            //Console.WriteLine("Silinecek ürün ID'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=WIN-9OO5RQ9OAPT\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=True"); ;
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Silme işlemi gerçekleşti!");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Yeni ürün Adı: ");
            string productName=Console.ReadLine();

            Console.Write("Yeni ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data source=WIN-9OO5RQ9OAPT\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=True"); ;
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@ProductName,ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Güncelleme başarılı!");







            #endregion








            Console.Read();





        }
    }
}
