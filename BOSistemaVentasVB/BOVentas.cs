using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOVentas
    {
        private int _Id_Venta;
        private DateTime _Fecha;
        private double _IVA;
        private double _Subtotal;
        private int _Estatus;
        private int _Id_Cliente;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOVentas()
        {
            _Id_Venta = 0;
            _Fecha = DateAndTime.DateSerial(0, 0, 0);
            _IVA = 0d;
            _Subtotal = 0d;
            _Estatus = 0;
            _Id_Cliente = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BOVentas(int id, DateTime fecha_, double iva_, double subtotal_, int status, int idcliente, int idcrear, int idmodificar)
        {
            _Id_Venta = id;
            _Fecha = fecha_;
            _IVA = iva_;
            _Subtotal = subtotal_;
            _Estatus = status;
            _Id_Cliente = idcliente;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }
        public BOVentas(DataRow row)
        {
            _Id_Venta = row.Field<int>("Id_Venta");
            _Fecha = row.Field<DateTime>("Fecha");
            _IVA = row.Field<double>("IVA");
            _Subtotal = row.Field<double>("Subtotal");
            _Estatus = row.Field<int>("Estatus");
            _Id_Cliente = row.Field<int>("Id_Proveedor");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
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
        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }
        public double IVA
        {
            get
            {
                return _IVA;
            }
            set
            {
                _IVA = value;
            }
        }
        public double Subtotal
        {
            get
            {
                return _Subtotal;
            }
            set
            {
                _Subtotal = value;
            }
        }
        public int Estatus
        {
            get
            {
                return _Estatus;
            }
            set
            {
                _Estatus = value;
            }
        }
        public int Id_Cliente
        {
            get
            {
                return _Id_Cliente;
            }
            set
            {
                _Id_Cliente = value;
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
        public object RegistrarVenta(int id, DateTime fecha_, double iva_, double subtotal_, int status, int idventa, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroVentas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Venta", id));
            cmd.Parameters.Add(new SqlParameter("Fecha", fecha_));
            cmd.Parameters.Add(new SqlParameter("@IVA", iva_));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", subtotal_));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", idventa));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Venta = id;
                Fecha = fecha_;
                IVA = iva_;
                Subtotal = subtotal_;
                Estatus = status;
                Id_Cliente = idventa;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarVenta(int id, DateTime fecha_, double iva_, double subtotal_, int status, int idcliente, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarVentas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Venta", id));
            cmd.Parameters.Add(new SqlParameter("Fecha", fecha_));
            cmd.Parameters.Add(new SqlParameter("@IVA", iva_));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", subtotal_));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", idcliente));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Venta = id;
                Fecha = fecha_;
                IVA = iva_;
                Subtotal = subtotal_;
                Estatus = status;
                Id_Cliente = idcliente;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarVenta(int id)
        {
            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarVentas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Venta", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Venta = id;
            }
            conn.Close();
            return response;
        }
    }
}