using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Cafeteria_movil
{
    internal class Conection
    {
        private string connectionString = "Server=database-test.mssql.somee.com;Database=database-test;User Id=KingCris_SQLLogin_1;Password=ls6rw54otf;";

        public void ConnectionString()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // Ejecutar una consulta
                    string query = "SELECT TOP 10 * FROM YourTableName";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0].ToString()); // Ejemplo de lectura de datos
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}