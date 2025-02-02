using RemotingTask.RemoteObjects;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RemotingTask.Server.Database
{
    public class ProductRepository : IProductRepository
    {
        public bool AddProduct(string name, decimal price)
        {

            string command = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=RemotingTask.db"))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(command, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Price", price);
                    return insertCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        public Product GetProductById(int id)
        {
            string command = "SELECT * FROM Products WHERE Id = @Id";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=RemotingTask.db"))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(command, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Id", id);
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
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
            string command = "SELECT * FROM Products";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=RemotingTask.db"))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(command, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
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
            string command = "DELETE FROM Products WHERE Id = @Id";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=RemotingTask.db"))
            {
                connection.Open();
                using (SQLiteCommand deleteCommand = new SQLiteCommand(command, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@Id", id);
                    return deleteCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateProduct(int id, string name, decimal price)
        {
            string command = "UPDATE Products SET Name = @Name, Price = @Price WHERE Id = @Id";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=RemotingTask.db"))
            {
                connection.Open();
                using (SQLiteCommand updateCommand = new SQLiteCommand(command, connection))
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
            string command = "SELECT COUNT(*) FROM Products WHERE Name = @Name";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=RemotingTask.db"))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(command, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Name", name);
                    return (long)selectCommand.ExecuteScalar() > 0;
                }
            }
        }

    }
}
