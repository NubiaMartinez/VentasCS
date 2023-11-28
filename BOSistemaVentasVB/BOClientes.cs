using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOClientes
    {
        private int _Id_Cliente;
        private string _Nombre;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private int _Estatus;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOClientes()
        {
            _Id_Cliente = 0;
            _Nombre = "";
            _Direccion = "";
            _Telefono = "";
            _Email = "";
            _Estatus = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BOClientes(int id, string nom, string address, string tel, string mail, int status, int idcrear, int idmodificar)
        {
            _Id_Cliente = id;
            _Nombre = nom;
            _Direccion = address;
            _Telefono = tel;
            _Email = mail;
            _Estatus = status;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }

        public BOClientes(DataRow row)
        {
            _Id_Cliente = row.Field<int>("Id_Cliente");
            _Nombre = row.Field<string>("Nombre");
            _Direccion = row.Field<string>("Direccion");
            _Telefono = row.Field<string>("Telefono");
            _Email = row.Field<string>("Email");
            _Estatus = row.Field<int>("Estatus");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
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
        public object RegistrarCliente(int id, string nom, string address, string tel, string mail, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroClientes", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", id));
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
                Id_Cliente = id;
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
        public object ModificarCliente(int id, string nom, string address, string tel, string mail, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarClientes", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", id));
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
                Id_Cliente = id;
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
        public object EliminarCliente(int id)
        {
            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarClientes", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Cliente = id;
            }
            conn.Close();
            return response;
        }
    }
}