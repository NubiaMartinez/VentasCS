using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BODetalleCompra
    {
        private int _Id_DetalleCompra;
        private int _Cantidad;
        private double _Total;
        private int _Id_Producto;
        private int _Id_Compra;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BODetalleCompra()
        {
            _Id_DetalleCompra = 0;
            _Cantidad = 0;
            _Total = 0d;
            _Id_Producto = 0;
            _Id_Compra = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BODetalleCompra(int id, int cant, double tot, int idproducto, int idcompra, int idcrear, int idmodificar)
        {
            _Id_DetalleCompra = id;
            _Cantidad = cant;
            _Total = tot;
            _Id_Producto = idproducto;
            _Id_Compra = idcompra;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }
        public BODetalleCompra(DataRow row)
        {
            _Id_DetalleCompra = row.Field<int>("Id_DetalleCompra");
            _Cantidad = row.Field<int>("Cantidad");
            _Total = row.Field<double>("Total");
            _Id_Producto = row.Field<int>("Id_Producto");
            _Id_Compra = row.Field<int>("Id_Compra");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
        }
        public int Id_DetalleCompra
        {
            get
            {
                return _Id_DetalleCompra;
            }
            set
            {
                _Id_DetalleCompra = value;
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
        public int Id_Compra
        {
            get
            {
                return _Id_Compra;
            }
            set
            {
                _Id_Compra = value;
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
        public object RegistrarDCompra(int id, int cant, double tot, int idproducto, int idcompra, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroDetalleCompra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleCompra", id));
            cmd.Parameters.Add(new SqlParameter("Cantidad", cant));
            cmd.Parameters.Add(new SqlParameter("@Total", tot));
            cmd.Parameters.Add(new SqlParameter("@Id_Producto", idproducto));
            cmd.Parameters.Add(new SqlParameter("@Id_Compra", idcompra));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_DetalleCompra = id;
                Cantidad = cant;
                Total = tot;
                Id_Producto = idproducto;
                Id_Compra = idcompra;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarDCompra(int id, int cant, double tot, int idproducto, int idcompra, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarDetalleCompra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleCompra", id));
            cmd.Parameters.Add(new SqlParameter("Cantidad", cant));
            cmd.Parameters.Add(new SqlParameter("@Total", tot));
            cmd.Parameters.Add(new SqlParameter("@Id_Producto", idproducto));
            cmd.Parameters.Add(new SqlParameter("@Id_Compra", idcompra));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_DetalleCompra = id;
                Cantidad = cant;
                Total = tot;
                Id_Producto = idproducto;
                Id_Compra = idcompra;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarDCompra(int id)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarDetalleCompra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_DetalleCompra", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_DetalleCompra = id;
            }
            conn.Close();
            return response;
        }
    }
}