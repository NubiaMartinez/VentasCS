using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOCompras
    {
        private int _Id_Compra;
        private DateTime _Fecha;
        private double _IVA;
        private double _Subtotal;
        private int _Estatus;
        private int _Id_Proveedor;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOCompras()
        {
            _Id_Compra = 0;
            _Fecha = DateAndTime.DateSerial(0, 0, 0);
            _IVA = 0d;
            _Subtotal = 0d;
            _Estatus = 0;
            _Id_Proveedor = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BOCompras(int id, DateTime fecha_, double iva_, double subtotal_, int status, int idproveedor, int idcrear, int idmodificar)
        {
            _Id_Compra = id;
            _Fecha = fecha_;
            _IVA = iva_;
            _Subtotal = subtotal_;
            _Estatus = status;
            _Id_Proveedor = idproveedor;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }
        public BOCompras(DataRow row)
        {
            _Id_Compra = row.Field<int>("Id_Compra");
            _Fecha = row.Field<DateTime>("Fecha");
            _IVA = row.Field<double>("IVA");
            _Subtotal = row.Field<double>("Subtotal");
            _Estatus = row.Field<int>("Estatus");
            _Id_Proveedor = row.Field<int>("Id_Proveedor");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
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
        public int Id_Proveedor
        {
            get
            {
                return _Id_Proveedor;
            }
            set
            {
                _Id_Proveedor = value;
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
        public object RegistrarCompra(int id, DateTime fecha_, double iva_, double subtotal_, int status, int idproveedor, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroCompras", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Compra", id));
            cmd.Parameters.Add(new SqlParameter("Fecha", fecha_));
            cmd.Parameters.Add(new SqlParameter("@IVA", iva_));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", subtotal_));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", idproveedor));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Compra = id;
                Fecha = fecha_;
                IVA = iva_;
                Subtotal = subtotal_;
                Estatus = status;
                Id_Proveedor = idproveedor;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarCompra(int id, DateTime fecha_, double iva_, double subtotal_, int status, int idproveedor, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarCompras", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Compra", id));
            cmd.Parameters.Add(new SqlParameter("Fecha", fecha_));
            cmd.Parameters.Add(new SqlParameter("@IVA", iva_));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", subtotal_));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", idproveedor));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Compra = id;
                Fecha = fecha_;
                IVA = iva_;
                Subtotal = subtotal_;
                Estatus = status;
                Id_Proveedor = idproveedor;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarCompra(int id)
        {
            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarCompras", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Compra", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Compra = id;
            }
            conn.Close();
            return response;
        }
    }
}