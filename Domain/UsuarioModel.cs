namespace Domain
{
    using DataAccess;
    using Common.Cache;

    public class UsuarioModel
    {
        UserDAO userDao = new UserDAO();
        Persistencia persistencia = new Persistencia();

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public void InsertarPersonal(string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, string puesto, int idRegistro)
        {
            int Id;
            Id = persistencia.SiguienteID("Personal", "idPersonal");
            userDao.InsertarPersonal(Id, Nombre, Apellido, Edad, Direccion, Telefono, correo, puesto, idRegistro);
        }
        
        public void EditarPersonal(int idPersonal, string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, string puesto, int idRegistro)
        {
            userDao.EditarPersonal(idPersonal, Nombre, Apellido, Edad, Direccion, Telefono, correo, puesto, idRegistro);
        }

        public void BorrarPersonal(int idPersonal)
        {
            userDao.BorrarPersonal(idPersonal);
        }

        //////////////////  MATERIAL   ///////////////////////

        public void InsertarMaterial(string Nombre, int Cantidad, int stock, int idRegistro)
        {
            int Id;
            Id = persistencia.SiguienteID("Material", "idMaterial");
            userDao.InsertarMaterial(Id, Nombre, Cantidad, stock, idRegistro);
        }

        public void EditarMaterial(int idMaterial, string Nombre, int Cantidad, int stock, int idRegistro)
        {
            userDao.EditarMaterial(idMaterial, Nombre, Cantidad, stock, idRegistro);
        }

        public void BorrarMaterial(int idMaterial)
        {
            userDao.BorrarMaterial(idMaterial);
        }

        ///////////////////    CLASES   //////////////////////

        public void InsertarClases(string Dia, string HoraInicio, string HoraFinaliza, int idRegistro)
        {
            int Id;
            Id = persistencia.SiguienteID("Clases", "idClases");
            userDao.InsertarClases(Id, Dia, HoraInicio, HoraFinaliza, idRegistro);
        }

        public void EditarClases(int idClases, string Dia, string HoraInicio, string HoraFinaliza, int idRegistro)
        {
            userDao.EditarClases(idClases, Dia, HoraInicio, HoraFinaliza, idRegistro);
        }

        public void BorrarClases(int idMaterial)
        {
            userDao.BorrarClases(idMaterial);
        }

        ///////////////////   CLIENTES    //////////////////////

        public void InsertarCliente(string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, int idDetalles)
        {
            int Id;
            Id = persistencia.SiguienteID("Cliente", "idCliente");
            userDao.InsertarCliente(Id, Nombre, Apellido, Edad, Direccion, Telefono, correo, idDetalles);
        }

        public void EditarCliente(int idCliente, string Nombre, string Apellido, int Edad, string Direccion, string Telefono, string correo, int idDetalles)
        {
            userDao.EditarCliente(idCliente, Nombre, Apellido, Edad, Direccion, Telefono, correo, idDetalles);
        }

        public void BorrarCliente(int idCliente)
        {
            userDao.BorrarCliente(idCliente);
        }
    }
}
