using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace BOSistemaVentasVB
{

    public class BOProductos
    {
        private int _Id_Producto;
        private string _Nombre;
        private double _PrecioUnitario;
        private int _Stock;
        private string _Descripcion;
        private int _Estatus;
        private int _Id_Marca;
        private int _Id_Categoria;
        private int _Id_Ucrear;
        private int _Id_Umodificar;
        private object conexion = "Server=LAPTOP-I2RJCKLJ; Database=VENTAS; Integrated Security=true";
        public BOProductos()
        {
            _Id_Producto = 0;
            _Nombre = "";
            _PrecioUnitario = 0d;
            _Stock = 0;
            _Descripcion = "";
            _Estatus = 0;
            _Id_Marca = 0;
            _Id_Categoria = 0;
            _Id_Ucrear = 0;
            _Id_Umodificar = 0;
        }
        public BOProductos(int id, string nom, double precio, int stock_, string descrip, int status, int idmarca, int idcategoria, int idcrear, int idmodificar)
        {

            _Id_Producto = id;
            _Nombre = nom;
            _PrecioUnitario = precio;
            _Stock = stock_;
            _Descripcion = descrip;
            _Estatus = status;
            _Id_Marca = idmarca;
            _Id_Categoria = idcategoria;
            _Id_Ucrear = idcrear;
            _Id_Umodificar = idmodificar;
        }
        public BOProductos(DataRow row)
        {
            _Id_Producto = row.Field<int>("Id_Producto");
            _Nombre = row.Field<string>("Nombre");
            _PrecioUnitario = row.Field<double>("PrecioUnitario");
            _Stock = row.Field<int>("Stock");
            _Descripcion = row.Field<string>("Descripcion");
            _Estatus = row.Field<int>("Estatus");
            _Id_Marca = row.Field<int>("Id_Marca");
            _Id_Categoria = row.Field<int>("Id_Categoria");
            _Id_Ucrear = row.Field<int>("Id_Ucrear");
            _Id_Umodificar = row.Field<int>("Id_Umodificar");
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
        public double PrecioUnitario
        {
            get
            {
                return _PrecioUnitario;
            }
            set
            {
                _PrecioUnitario = value;
            }
        }
        public int Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                _Stock = value;
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
        public object RegistrarProducto(int id, string nom, double precio, int stock_, string descrip, int status, int idmarca, int idcategoria, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("RegistroProductos", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", id));
            cmd.Parameters.Add(new SqlParameter("Nombre", nom));
            cmd.Parameters.Add(new SqlParameter("@PrecioUnitario", precio));
            cmd.Parameters.Add(new SqlParameter("@Stock", stock_));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", descrip));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Marca", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Categoria", idmodificar));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Producto = id;
                Nombre = nom;
                PrecioUnitario = precio;
                Stock = stock_;
                Descripcion = descrip;
                Estatus = status;
                Id_Marca = idmarca;
                Id_Categoria = idcategoria;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object ModificarProducto(int id, string nom, double precio, int stock_, string descrip, int status, int idmarca, int idcategoria, int idcrear, int idmodificar)
        {

            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("ModificarProductos", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", id));
            cmd.Parameters.Add(new SqlParameter("Nombre", nom));
            cmd.Parameters.Add(new SqlParameter("@PrecioUnitario", precio));
            cmd.Parameters.Add(new SqlParameter("@Stock", stock_));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", descrip));
            cmd.Parameters.Add(new SqlParameter("@Estatus", status));
            cmd.Parameters.Add(new SqlParameter("@Id_Marca", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Categoria", idmodificar));
            cmd.Parameters.Add(new SqlParameter("@Id_Ucrear", idcrear));
            cmd.Parameters.Add(new SqlParameter("@Id_Umodificar", idmodificar));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Producto = id;
                Nombre = nom;
                PrecioUnitario = precio;
                Stock = stock_;
                Descripcion = descrip;
                Estatus = status;
                Id_Marca = idmarca;
                Id_Categoria = idcategoria;
                Id_Ucrear = idcrear;
                Id_Umodificar = idmodificar;
            }
            conn.Close();
            return response;
        }
        public object EliminarProducto(int id)
        {
            bool response = false;
            var conn = new SqlConnection(Conversions.ToString(conexion));
            conn.Open();
            var cmd = new SqlCommand("EliminarProductos", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id_Cliente", id));
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    response = Conversions.ToBoolean(rdr["response"]);
            }
            if (Conversions.ToInteger(response) == 1)
            {
                Id_Producto = id;
            }
            conn.Close();
            return response;
        }
    }
}