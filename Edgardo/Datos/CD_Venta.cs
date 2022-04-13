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
        public void Insertar(DateTime fecha, decimal total)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //insert into ventas values('coca','1 litro','Cocacola',100,10);
                    command.CommandText = @"INSERT INTO ventas VALUES(@fecha,@total)";
                    command.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = fecha;
                    command.Parameters.Add("@total", System.Data.SqlDbType.Decimal).Value = total;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
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
                    command.CommandText = @"UPDATE ventas SET fecha=@fecha, total=@total, stock=@stock WHERE id =@id";
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
                    command.CommandText = @"DELETE FROM ventas WHERE id=@id";
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
                    command.CommandText = @"SELECT * FROM ventas WHERE id=@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }
    }
}
