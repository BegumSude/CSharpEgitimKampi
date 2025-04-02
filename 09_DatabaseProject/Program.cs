using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tableNumber;
            //Ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi*****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********************************************************");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişlerr");
            Console.WriteLine("4-Çıkış Yap!");

            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz:");

            tableNumber = Console.ReadLine();


            Console.WriteLine("----------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=WIN-9OO5RQ9OAPT\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategoryy",connection);
            SqlDataAdapter adapter=new SqlDataAdapter(command);
            DataTable dataTable=new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(var item in dataTable.Rows)
            {
                Console.WriteLine(item);
            }





            Console.Read();
        }
    }
}
