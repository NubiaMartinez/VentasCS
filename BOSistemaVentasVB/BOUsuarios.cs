using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOUsuarios
    {
        private int _Id_Usuario;
        private string _NombreUsuario;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private int _Estatus;
        private string _Contraseña;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOUsuarios()
        {
            _Id_Usuario = 0;
            _NombreUsuario = "";
            _Direccion = "";
            _Telefono = "";
            _Email = "";
            _Estatus = 0;
            _Contraseña = "";
        }
        public BOUsuarios(int id, string name, string address, string tel, string mail, int status, string password)
        {
            _Id_Usuario = id;
            _NombreUsuario = name;
            _Direccion = address;
            _Telefono = tel;
            _Email = mail;
            _Estatus = status;
            _Contraseña = password;
        }
        public BOUsuarios(DataRow row)
        {
            _Id_Usuario = row.Field<int>("Id_Usuario");
            _NombreUsuario = row.Field<string>("NombreUsuario");
            _Direccion = row.Field<string>("Direccion");
            _Telefono = row.Field<string>("Telefono");
            _Email = row.Field<string>("Email");
            _Estatus = row.Field<int>("Estatus");
            _Contraseña = row.Field<string>("Contraseña");
        }
        public int Id_Usuario
        {
            get
            {
                return _Id_Usuario;
            }
            set
            {
                _Id_Usuario = value;
            }
        }
        public string NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }
            set
            {
                _NombreUsuario = value;
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
        public string Contraseña
        {
            get
            {
                return _Contraseña;
            }
            set
            {
                _Contraseña = value;
            }
        }
        public object RegistrarUsuario(int id, string name, string address, string tel, string mail, int status, string password)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroUsuarios", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Usuario", id));
            cmd.Parameters.Add(new SqlParameter("NombreUsuario", name));
            cmd.Parameters.Add(new SqlParameter("@Direccion", address));
            cmd.Parameters.Add(new SqlParameter("@Telefono", tel));
            cmd.Parameters.Add(new SqlParameter("@Email", mail));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Contraseña", password));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Usuario = id;
                NombreUsuario = name;
                Direccion = address;
                Telefono = tel;
                Email = mail;
                Estatus = status;
                Contraseña = password;
            }
            conn.Close();
            return response;
        }
        public object ModificarUsuario(int id, string name, string address, string tel, string mail, int status, string password)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarUsuarios", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Usuario", id));
            cmd.Parameters.Add(new SqlParameter("NombreUsuario", name));
            cmd.Parameters.Add(new SqlParameter("@Direccion", address));
            cmd.Parameters.Add(new SqlParameter("@Telefono", tel));
            cmd.Parameters.Add(new SqlParameter("@Email", mail));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Contraseña", password));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Usuario = id;
                NombreUsuario = name;
                Direccion = address;
                Telefono = tel;
                Email = mail;
                Estatus = status;
                Contraseña = password;
            }
            conn.Close();
            return response;
        }
        public object EliminarUsuario(int id)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarUsuarios", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Usuario", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Usuario = id;
            }
            conn.Close();
            return response;
        }
    }
}