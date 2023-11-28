using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOMarca
    {
        private int _Id_Marca;
        private string _Nombre;
        private string _Descripcion;
        private int _Estatus;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOMarca()
        {
            _Id_Marca = 0;
            _Nombre = "";
            _Descripcion = "";
            _Estatus = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BOMarca(int id, string nom, string desc, int status, int idcrear, int idmodificar)
        {
            _Id_Marca = id;
            _Nombre = nom;
            _Descripcion = desc;
            _Estatus = status;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }
        public BOMarca(DataRow row)
        {
            _Id_Marca = row.Field<int>("Id_Marca");
            _Nombre = row.Field<string>("Nombre");
            _Descripcion = row.Field<string>("Descripcion");
            _Estatus = row.Field<int>("Estatus");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
        }
        public int Id_Marca
        {
            get
            {
                return _Id_Marca;
            }
            set
            {
                _Id_Marca = value;
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
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
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
        public object RegistrarMarcas(int id, string nom, string desc, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroMarca", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Marca", id));
            cmd.Parameters.Add(new SqlParameter("Nombre", nom));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", desc));
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
                Id_Marca = id;
                Nombre = nom;
                Descripcion = desc;
                Estatus = status;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarMarcas(int id, string nom, string desc, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarMarca", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Marca", id));
            cmd.Parameters.Add(new SqlParameter("Nombre", nom));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", desc));
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
                Id_Marca = id;
                Nombre = nom;
                Descripcion = desc;
                Estatus = status;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarMarcas(int id)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarMarca", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Marca", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Marca = id;
            }
            conn.Close();
            return response;
        }
    }
}