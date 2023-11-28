using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BODetalleVenta
    {
        private int _Id_DetalleVenta;
        private int _Cantidad;
        private double _Total;
        private int _Id_Producto;
        private int _Id_Venta;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BODetalleVenta()
        {
            _Id_DetalleVenta = 0;
            _Cantidad = 0;
            _Total = 0d;
            _Id_Producto = 0;
            _Id_Venta = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BODetalleVenta(int id, int cant, double tot, int idproducto, int idventa, int idcrear, int idmodificar)
        {
            _Id_DetalleVenta = id;
            _Cantidad = cant;
            _Total = tot;
            _Id_Producto = idproducto;
            _Id_Venta = idventa;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }
        public BODetalleVenta(DataRow row)
        {
            _Id_DetalleVenta = row.Field<int>("Id_DetalleVenta");
            _Cantidad = row.Field<int>("Cantidad");
            _Total = row.Field<double>("Total");
            _Id_Producto = row.Field<int>("Id_Producto");
            _Id_Venta = row.Field<int>("Id_Venta");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
        }
        public int Id_DetalleVenta
        {
            get
            {
                return _Id_DetalleVenta;
            }
            set
            {
                _Id_DetalleVenta = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return _Cantidad;
            }
            set
            {
                _Cantidad = value;
            }
        }
        public double Total
        {
            get
            {
                return _Total;
            }
            set
            {
                _Total = value;
            }
        }
        public int Id_Producto
        {
            get
            {
                return _Id_Producto;
            }
            set
            {
                _Id_Producto = value;
            }
        }
        public int Id_Venta
        {
            get
            {
                return _Id_Venta;
            }
            set
            {
                _Id_Venta = value;
            }
        }
        public int Id_Ucrear
        {
            get
            {
                return _Id_Ucrear;
            }
            set
            {
                _Id_Ucrear = value;
            }
        }
        public int Id_Umodificar
        {
            get
            {
                return _Id_Umodificar;
            }
            set
            {
                _Id_Umodificar = value;
            }
        }
        public object RegistrarDVenta(int id, int cant, double tot, int idproducto, int idventa, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroDetalleVenta", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleVenta", id));
            cmd.Parameters.Add(new SqlParameter("Cantidad", cant));
            cmd.Parameters.Add(new SqlParameter("@Total", tot));
            cmd.Parameters.Add(new SqlParameter("@Id_Producto", idproducto));
            cmd.Parameters.Add(new SqlParameter("@Id_Venta", idventa));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_DetalleVenta = id;
                Cantidad = cant;
                Total = tot;
                Id_Producto = idproducto;
                Id_Venta = idventa;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarDVenta(int id, int cant, double tot, int idproducto, int idventa, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarDetalleVenta", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleVenta", id));
            cmd.Parameters.Add(new SqlParameter("Cantidad", cant));
            cmd.Parameters.Add(new SqlParameter("@Total", tot));
            cmd.Parameters.Add(new SqlParameter("@Id_Producto", idproducto));
            cmd.Parameters.Add(new SqlParameter("@Id_Venta", idventa));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_DetalleVenta = id;
                Cantidad = cant;
                Total = tot;
                Id_Producto = idproducto;
                Id_Venta = idventa;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarDVenta(int id)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarDetalleVenta", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleVenta", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_DetalleVenta = id;
            }
            conn.Close();
            return response;
        }
    }
}