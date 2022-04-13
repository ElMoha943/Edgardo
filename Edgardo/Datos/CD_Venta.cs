using Edgardo.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgardo.Datos
{
    public class CD_Venta : DB
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        //MUESTRA TODOS LOS VENTAS
        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = "SELECT * FROM venta";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        //CREA UN VENTA NUEVO
        public void Insertar(DateTime fecha, decimal total, List<product> products)
        {
            int id_venta;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //INSERTAMOS LA VENTA
                    command.CommandText = @"INSERT INTO venta VALUES(@fecha,@total)";
                    command.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = fecha;
                    command.Parameters.Add("@total", System.Data.SqlDbType.Decimal).Value = total;
                    id_venta = command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    //INSERTAMOS LOS PRODUCTOS VENDIDOS
                    command.CommandText = @"INSERT INTO venta_producto VALUES(@id_venta,id_producto,@cant_producto)";
                    command.Parameters.Add("@id_venta", System.Data.SqlDbType.Int).Value = id_venta;
                    foreach (product p in products)
                    {
                        command.Parameters.Add("@id_producto", System.Data.SqlDbType.VarChar).Value = p.Name;
                        command.Parameters.Add("@cant_producto", System.Data.SqlDbType.Int).Value = p.Quantity;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        //EDITA UN VENTA
        public void Editar(int id, DateTime fecha, decimal total)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = @"UPDATE venta SET fecha=@fecha, total=@total, stock=@stock WHERE id =@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    command.Parameters.Add("@nombre", System.Data.SqlDbType.DateTime).Value = fecha;
                    command.Parameters.Add("@precio", System.Data.SqlDbType.Decimal).Value = total;
                    command.ExecuteNonQuery();
                }
            }
        }

        //ELIMINA UN VENTA
        public void Eliminar(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = @"DELETE FROM venta WHERE id=@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        //BUSCA UN VENTA EN ESPECIFICO
        public DataTable Buscar(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = @"SELECT * FROM venta WHERE id=@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }
    }
}
