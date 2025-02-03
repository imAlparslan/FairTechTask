using RemotingTask.RemoteObjects;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RemotingTask.Server.Database
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository()
        {
            var dbsettings = DatabaseSettings.Load();
            _connectionString = dbsettings.applicationConnectionString;
        }
        public bool AddProduct(string name, decimal price)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO Product (Name, Price) VALUES (@Name, @Price)",con);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Price", price);
            con.Open();
            return command.ExecuteNonQuery() > 0;
            
        }

        public Product GetProductById(int id)
        {
            string command = "SELECT * FROM Product WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(command, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            (
                                id: reader.GetInt32(0),
                                name: reader.GetString(1),
                                price: reader.GetDecimal(2)
                            );
                        }
                    }
                }
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            string command = "SELECT * FROM Product";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(command, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            (
                                id: reader.GetInt32(0),
                                name: reader.GetString(1),
                                price: reader.GetDecimal(2)
                            ));
                        }
                    }
                }
            }
            return products;
        }

        public bool DeleteProduct(int id)
        {
            string command = "DELETE FROM Product WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(command, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@Id", id);
                    return deleteCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateProduct(int id, string name, decimal price)
        {
            string command = "UPDATE Product SET Name = @Name, Price = @Price WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(command, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Name", name);
                    updateCommand.Parameters.AddWithValue("@Price", price);
                    updateCommand.Parameters.AddWithValue("@Id", id);
                    return updateCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ProductNameExists(string name)
        {
            string command = "SELECT COUNT(*) FROM Product WHERE Name = @Name";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(command, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Name", name);
                    return (int)selectCommand.ExecuteScalar() > 0;
                }
            }
        }

    }
}
