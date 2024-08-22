//22.08.2024 -Sql servera bağlı basit bir ürün takip uygulaması
//Gökçehan Özdemir

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BasitUrunTakipUygulamasi;

public class ProductDal
{
    SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=UrunTakip; integrated security=true"); 
    //bağlantı nesnesi oluşturduk. her fonksiyonda bağlantı açmak için bu satırı yazacağız bu nedenle global bir yere aldık.
    public List<Product> GetAll() //tüm ürünlerin listelenmesi için 
    {
        ConnectionControl();
        // eğer bağlantı zaten açıksa buradan devam edecek

        SqlCommand command = new SqlCommand("Select * from Products", _connection); //bu komut bütün verileri listelemeye yarar.
        SqlDataReader reader = command.ExecuteReader(); //bu tamamını listeleme komutuna has bir kod farklı komutlarda farklı satırlar olacaktır
        //bu satırla öğeleri readera referansla aktarmış olduk 

        List<Product> products = new List<Product>();

        while (reader.Read())
        {

            Product product = new Product() //listenin öğelerini tablonun öğeleriyle eşledim
            {
                Id = Convert.ToInt32(reader["Id"]),
                ProductName = reader["productName"].ToString(),
                Stock = Convert.ToInt32(reader["stock"]),
                UnitPrice = Convert.ToDecimal(reader["unitPrice"]),

            };
            products.Add(product); //listeye ekledim
        }

        reader.Close();
        _connection.Close(); //bağlantıyı ve okuyucuyu kapattım 
        return products;
    }

    public void Add(Product product) //add butonuna tıkladığımızda ürünün sisteme eklenmesi için bir fonksiyon
    {
        ConnectionControl();

        SqlCommand command = new SqlCommand("Insert into Products values(@productName, @unitPrice, @stock)", _connection);
        command.Parameters.AddWithValue("@productName",product.ProductName);
        command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
        command.Parameters.AddWithValue("@stock", product.Stock);//aldığımız parametreleri gerekli yerlere atadık.
        command.ExecuteNonQuery();
        _connection.Close();//bağlantıyı kapatmayı unutma

    }

    public void Update(Product product) //ürün bilgilerini güncellemek için kullanılır.
    {
        ConnectionControl();
                                                                                                                            //burası önemli
        SqlCommand command = new SqlCommand("Update Products set productName=@productName, unitPrice=@unitPrice, stock=@stock where Id=@id", _connection);
        command.Parameters.AddWithValue("@productName", product.ProductName);
        command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
        command.Parameters.AddWithValue("@stock", product.Stock);//aldığımız parametreleri gerekli yerlere atadık.
        command.Parameters.AddWithValue("@id",product.Id);
        command.ExecuteNonQuery();
        _connection.Close();//bağlantıyı kapatmayı unutma

    }

    public void Delete(int id) {
        ConnectionControl();

        SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);
        command.Parameters.AddWithValue("@id", id);
        command.ExecuteNonQuery();
        _connection.Close();//bağlantıyı kapatmayı unutma


    }


    private void ConnectionControl()
    {
        if (_connection.State == ConnectionState.Closed)//bağlantı açık mı değil mi kontrol et eğer açık değilse açar.
        {
            _connection.Open(); //bağlantı açıldı
        }
    }
}