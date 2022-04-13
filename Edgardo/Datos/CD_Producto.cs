using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgardo.Datos
{
    public class CD_Producto : DB
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        //MUESTRA TODOS LOS PRODUCTOS
        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = "SELECT * FROM producto";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        //CREA UN PRODUCTO NUEVO
        public void Insertar(string id, string nombre, decimal precio)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //insert into productos values('coca','1 litro','Cocacola',100,10);
                    command.CommandText = @"INSERT INTO producto VALUES(@id,@nombre,@precio,@stock)";
                    command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
                    command.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = nombre;
                    command.Parameters.Add("@precio", System.Data.SqlDbType.Decimal).Value = precio;
                    command.Parameters.Add("@stock", System.Data.SqlDbType.Int).Value = 0;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        //EDITA UN PRODUCTO
        public void Editar(string id, string nombre, decimal precio, int stock)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = @"UPDATE producto SET nombre=@nombre, precio=@precio, stock=@stock WHERE id =@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
                    command.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = nombre;
                    command.Parameters.Add("@precio", System.Data.SqlDbType.Decimal).Value = precio;
                    command.Parameters.Add("@stock", System.Data.SqlDbType.Int).Value = stock;
                    command.ExecuteNonQuery();
                }
            }
        }

        //ELIMINA UN PRODUCTO
        public void Eliminar(string id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = @"DELETE FROM producto WHERE id=@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        //BUSCA UN PRODUCTO EN ESPECIFICO
        public DataTable Buscar(string id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = @"SELECT * FROM producto WHERE id=@id";
                    command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);                   
                    return tabla;
                }
            }
        }
    }
}
