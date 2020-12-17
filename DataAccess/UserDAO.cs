namespace DataAccess
{
    using Common.Cache;
    using System.Data;
    using System.Data.SqlClient;


    public class UserDAO : ConnectionToSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * From Usuario Where loginName = @user and PassW= @pass";

                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userCache.WOD = reader.GetInt32(0);
                            userCache.userID = reader.GetString(1);
                            userCache.loginName = reader.GetString(2);
                            userCache.PassW = reader.GetString(3);
                        
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool clases(string idclases)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * From Clases Where idClases = @idclases";

                    if(idclases != null)
                    {
                        command.Parameters.AddWithValue("@idclases", idclases);
                    }
                  

                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            clasesCache.idClases = reader.GetInt32(0);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        public void InsertarPersonal(int idPersonal, string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, string puesto, int idRegistro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert Into Personal VALUES ("+idPersonal+",'"+Nombre+ "','"+Apellido+ "',"+Edad+ ",'"+Direccion+ "','"+Telefono+ "','"+correo+ "','"+puesto+ "', " + idRegistro + ")";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarPersonal(int idPersonal, string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, string puesto, int idRegistro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Update Personal set idPersonal=" + idPersonal + ", Nombre='" + Nombre + "', Apellido='" + Apellido + "', Edad='" + Edad + "', Direccion='" + Direccion + "', Telefono='" + Telefono + "', correo='" + correo + "', puesto='" + puesto + "', idRegistro=" + idRegistro + " WHERE idPersonal = " + idPersonal;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void BorrarPersonal(int idPersonal)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Delete FROM Personal WHERE idPersonal='" +idPersonal+"'";
                    command.ExecuteNonQuery();
                }
            }
        }

        ////////////////////////////   CLASES   /////////////////////////////////////

        public void InsertarClases(int idClases, string Dia, string HoraInicio, string HoraFinaliza, int idRegistro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert Into Clases VALUES (" + idClases + ",'" + Dia + "','" + HoraInicio + "','" + HoraFinaliza + "', " + idRegistro + ")";
                    command.ExecuteNonQuery();
                }
            }
        }

 



        public void EditarClases(int idClases, string Dia, string HoraInicio, string HoraFinaliza, int idRegistro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Update Clases set idClases=" + idClases + ", Dia='" + Dia + "',HorarioInicio='" + HoraInicio + "', horarioFinaliza='" + HoraFinaliza + "', idRegistro=" + idRegistro + " WHERE idClases = " + idClases;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void BorrarClases(int idClases)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "UPDATE Cliente SET idClases = " + 0 + " WHERE idClases=" + idClases;
                    command.ExecuteNonQuery();

                    command.CommandText = "Delete FROM Clases WHERE idClases=" + idClases + "";
                    command.ExecuteNonQuery();
                }
            }
        }

        ////////////////////////////   MATERIAL   /////////////////////////////////////

        public void InsertarMaterial(int idMaterial, string Nombre, int Cantidad, int Stock, int idRegistro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert Into Material VALUES (" + idMaterial + ",'" + Nombre + "','" + Cantidad + "'," + Stock + ", " + idRegistro + ")";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarMaterial(int idMaterial, string Nombre, int Cantidad, int Stock, int idRegistro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Update Material set idMaterial=" + idMaterial + ", Nombre='" + Nombre + "', Cantidad='" + Cantidad + "', Stock=" + Stock + ", idRegistro=" + idRegistro + " WHERE idMaterial = " + idMaterial;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void BorrarMaterial(int idMaterial)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Material WHERE idMaterial="+ idMaterial +"";
                    command.ExecuteNonQuery();
                }
            }
        }

        ////////////////////////////   CLIENTE   /////////////////////////////////////

        public void InsertarCliente(int idCliente, string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, int idClases)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert Into Cliente VALUES (" + idCliente + ",'" + Nombre + "','" + Apellido + "'," + Edad + ",'" + Direccion + "','" + Telefono + "','" + correo + "', " + idClases + ")";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarCliente(int idCliente, string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, int idClases)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Update Cliente set idCliente= " + idCliente + ", Nombre='" + Nombre + "', Apellido='" + Apellido + "', Edad=" + Edad + ", Direccion='" + Direccion + "', Telefono='" + Telefono + "', correo='" + correo + "', idClases=" + idClases + " WHERE idCliente = " + idCliente ;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void BorrarCliente(int idCliente)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Delete FROM Cliente WHERE idCliente='" + idCliente + "'";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
