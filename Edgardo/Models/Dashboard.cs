using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgardo.Models
{
    public class Dashboard : DB
    {
        //Fields & Prperties

        private DateTime startDate = DateTime.Parse("1/1/1754 12:00:00 AM ");
        private DateTime endDate = DateTime.Now;
        private int stockTreshHold = 20;

        public int NumProductos = 0;
        public int NumClientes = 0;
        public int NumProveedores = 0;
        public int NumVentas = 0;

        public decimal Ingresos = 0;
        public decimal Ganancias = 0;

        //Constructor
        public Dashboard()
        {
            GetNumberItems();
        }


        //Methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT COUNT(id) FROM Producto";
                    NumProductos = (int)command.ExecuteScalar();

                    command.CommandText = "SELECT COUNT(id) FROM Cliente";
                    NumClientes = (int)command.ExecuteScalar();

                    command.CommandText = "SELECT COUNT(id) FROM Venta";
                    NumVentas = (int)command.ExecuteScalar();

                    command.CommandText = "SELECT SUM(total) FROM Venta";
                    Ingresos = decimal.Round((decimal)command.ExecuteScalar(),0);

                    Ganancias = decimal.Round(decimal.Multiply(Ingresos,(decimal)0.3),0);

                    //command.CommandText = "SELECT COUNT(id) FROM Proveedor";
                    //NumProveedores = (int)command.ExecuteScalar();
                }
            }
        }

        public List<Producto> GetProducts()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT * FROM Producto";
                    var reader = command.ExecuteReader();
                    var resultTable = new List<Producto>();
                    while (reader.Read())
                    {
                        resultTable.Add(new Producto
                        {
                            Name = (string)reader[1],
                            Price = (decimal)reader[2],
                            Stock = (int)reader[3]
                        });
                    }
                    return resultTable;
                }
            }
        }

        public List<Venta> GetSales()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM Venta
                                          WHERE fecha BETWEEN @startDate and @endDate
                                          order by fecha DESC";
                    command.Parameters.Add("@startDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<Venta>();
                    while (reader.Read())
                    {
                        resultTable.Add(new Venta
                        {
                            Fecha = (DateTime)reader[1],
                            Total = (decimal)reader[2]
                            
                        });
                    }
                    return resultTable;
                }
            }
        }

        public List<KeyValuePair<string,int>> GetUnderStock()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM Producto
                                          WHERE stock < @treshHold";
                    command.Parameters.Add("@treshHold", System.Data.SqlDbType.Int).Value = stockTreshHold;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<string, int>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<string, int>((string)reader[1],(int)reader[3]));
                    }
                    return resultTable;
                }
            }
        }

        public List<KeyValuePair<string,int>> GetTopProducts()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT TOP 5 Producto.nombre, sum(Venta_Productos.cant_producto) as cant
                                            FROM Venta_Productos 
                                            INNER JOIN Producto ON Producto.id=Venta_Productos.id_producto
                                            group by Producto.nombre
                                            order by cant desc ";
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<string, int>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<string, int>((string)reader[0], (int)reader[1]));
                    }
                    return resultTable;
                }
            }
        }

        public Producto getProductById(string id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM PRODUCTO WHERE id=@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
                    var reader = command.ExecuteReader();
                    Producto p = new Producto();
                    while (reader.Read())
                    {
                        p =new Producto
                        {
                            Id = (string)reader[0],
                            Name = (string)reader[1],
                            Price = (decimal)reader[2],
                            Stock = (int)reader[3],
                        };
                    }
                    return p;
                }
            }
        }
    }
}
