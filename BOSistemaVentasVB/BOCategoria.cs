using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOCategoria
    {
        private int _Id_Categoria;
        private string _Nombre;
        private string _Descripcion;
        private int _Estatus;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOCategoria()
        {
            _Id_Categoria = 0;
            _Nombre = "";
            _Descripcion = "";
            _Estatus = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BOCategoria(int id, string nom, string desc, int status, int idcrear, int idmodificar)
        {
            _Id_Categoria = id;
            _Nombre = nom;
            _Descripcion = desc;
            _Estatus = status;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }
        public BOCategoria(DataRow row)
        {
            _Id_Categoria = row.Field<int>("Id_Categoria");
            _Nombre = row.Field<string>("Nombre");
            _Descripcion = row.Field<string>("Descripcion");
            _Estatus = row.Field<int>("Estatus");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
        }
        public int Id_Categoria
        {
            get
            {
                return _Id_Categoria;
            }
            set
            {
                _Id_Categoria = value;
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
        public object RegistrarCategoria(int id, string nom, string desc, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroCategoria", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Categoria", id));
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
                Id_Categoria = id;
                Nombre = nom;
                Descripcion = desc;
                Estatus = status;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarCategoria(int id, string nom, string desc, int status, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarCategoria", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Categoria", id));
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
                Id_Categoria = id;
                Nombre = nom;
                Descripcion = desc;
                Estatus = status;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarCategoria(int id)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarCategoria", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Categoria", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Categoria = id;
            }
            conn.Close();
            return response;
        }
    }
}