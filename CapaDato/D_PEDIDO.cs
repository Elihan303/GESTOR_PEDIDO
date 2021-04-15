using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class D_PEDIDO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public void InsertarPedida(E_PEDIDO PEDIDO)
        {
            SqlCommand comando = new SqlCommand("SP_INSERTAR_PEDIDO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDFACTURA", PEDIDO.IdFactura);
            comando.Parameters.AddWithValue("@IDPRODUCTO", PEDIDO.IdProducto);
            comando.Parameters.AddWithValue("@CANTIDAD", PEDIDO.Cantidad);
            comando.Parameters.AddWithValue("@PRECIO", PEDIDO.Precio);
            comando.Parameters.AddWithValue("@MONTO", PEDIDO.Monto);
            comando.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
