using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOProveedores
    {
        private int _Id_Proveedor;
        private string _Nombre;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private int _Estatus;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOProveedores()
        {
            _Id_Proveedor = 0;
            _Nombre = "";
            _Direccion = "";
            _Telefono = "";
            _Email = "";
            _Estatus = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BOProveedores(int id, string nom, string address, string tel, string mail, int status, int idcrear, int idmodificar)
        {
            _Id_Proveedor = id;
            _Nombre = nom;
            _Direccion = address;
            _Telefono = tel;
            _Email = mail;
            _Estatus = status;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }

        public BOProveedores(DataRow row)
        {
            _Id_Proveedor = row.Field<int>("Id_Proveedor");
            _Nombre = row.Field<string>("Nombre");
            _Direccion = row.Field<string>("Direccion");
            _Telefono = row.Field<string>("Telefono");
            _Email = row.Field<string>("Email");
            _Estatus = row.Field<int>("Estatus");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
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
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }
        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion = value;
            }
        }
        public string Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                _Telefono = value;
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
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
        public object RegistrarProveedor(int id, string nom, string address, string tel, string mail, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroProveedores", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", id));
            cmd.Parameters.Add(new SqlParameter("Nombre", nom));
            cmd.Parameters.Add(new SqlParameter("@Direccion", address));
            cmd.Parameters.Add(new SqlParameter("@Telefono", tel));
            cmd.Parameters.Add(new SqlParameter("@Email", mail));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Proveedor = id;
                Nombre = nom;
                Direccion = address;
                Telefono = tel;
                Email = mail;
                Estatus = status;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarProveedor(int id, string nom, string address, string tel, string mail, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarProveedores", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", id));
            cmd.Parameters.Add(new SqlParameter("Nombre", nom));
            cmd.Parameters.Add(new SqlParameter("@Direccion", address));
            cmd.Parameters.Add(new SqlParameter("@Telefono", tel));
            cmd.Parameters.Add(new SqlParameter("@Email", mail));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Proveedor = id;
                Nombre = nom;
                Direccion = address;
                Telefono = tel;
                Email = mail;
                Estatus = status;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarProveedor(int id)
        {
            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarProveedores", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Proveedor = id;
            }
            conn.Close();
            return response;
        }
    }
}