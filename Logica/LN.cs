using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class LN
    {
        #region Metodos Perfiles y Autenticacion
        #region metodo Autenticacion
        /// <summary>
        /// Metodo para verificar autenticacion de usuario en sistema
        /// </summary>
        /// <param name="P_Usuario">Entidad de tipo usuario</param>
        /// <returns>True = Correcto | False = Incorrecto</returns>
        public static bool ConsultarAutenticacion(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ConsultarAutenticacion @Usuario, @Clave";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombre;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramClave = new SqlParameter();
                paramClave.ParameterName = "@Clave";
                paramClave.Value = P_Usuario.clave;
                paramClave.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);
                sentencia.lstParametros.Add(paramClave);

                AD objacceso = new AD();
                Usuario usuario = objacceso.ConsultarAutenticacion(sentencia);

                if (usuario.nombre!= null)
                    if (usuario.nombre.Length > 0)
                        return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //verificar Intento de acceso
        public static int VerificarIntento(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC Pa_VerificarIntento @Usuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombre;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;


                sentencia.lstParametros.Add(paramUsuario);

                AD objacceso = new AD();
                Usuario usuario = objacceso.VerificarAcceso(sentencia);

                if (usuario.Intento == 2)
                {
                    return usuario.Intento;
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        //actulizar
        public static bool ActulizarUsuario(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ActIntento @Usuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombre;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);


                AD objacceso = new AD();

                return objacceso.ejecutarSentecia(sentencia); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //reset intento

        public static bool RestIntento(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC Pa_ResetIntento @Usuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombre;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);


                AD objacceso = new AD();

                return objacceso.ejecutarSentecia(sentencia); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool RestIntentoAll()
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ResetIntentoAll ";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                // sentencia.lstParametros.Add(paramUsuario);


                AD objacceso = new AD();

                return objacceso.ejecutarSentecia(sentencia); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Autenticacion de Perfiles
        /// <summary>
        /// Metodo para obtener perfiles del usuario recibido
        /// </summary>
        /// <param name="P_Usuarios">Entidad de tipo usuario</param>
        /// <returns>Lista de perfiles asociadas al usuario</returns>
        public static List<Perfil> ConsultarPerfilesUsuario(Usuario P_Usuarios)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ConsultarPerfilesUsuario @idusuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.Value = P_Usuarios.idUsuario;
                paramUsuario.ParameterName = "@idusuario";
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);

                AD objacceso = new AD();
                return objacceso.ConsultarPerfiles(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public static int VerificarAcceso(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ConsultarPerfilesUsuario @idusuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@idusuario";
                paramUsuario.Value = P_Usuario.nombre;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;


                sentencia.lstParametros.Add(paramUsuario);

                AD objacceso = new AD();
                Usuario usuario = objacceso.VerificarAcceso(sentencia);


                return usuario.Intento;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Perfiles

        //public static List<Perfil> ListarPerfiles()
        //{

        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.Peticion = @"SELECT idPerfil ,nombrePerfil FROM Perfil";

        //        AD objacceso = new AD();
        //        return objacceso.ConsultarPerfiles(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public static List<Perfil> ConsultaPerfil(Perfil p)
        //{

        //    try
        //    {
        //        SQLSentencia peticion = new SQLSentencia();
        //        peticion.Peticion = @"EXEC PA_Perfiles_Consultar '" + p.nombrePerfil + "'";

        //        AD objacceso = new AD();
        //        return objacceso.ConsultarPerfiles(peticion);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}



        //public static bool agregarPerfil(Perfil p)
        //{
        //    try
        //    {

        //        SQLSentencia peticion = new SQLSentencia();
        //        peticion.Peticion = @"EXEC PA_Perfiles_Insertar '" + p.nombrePerfil + "'";

        //        AD objacceso = new AD();
        //        return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD




                //SQLSentencia sentencia = new SQLSentencia();

                //sentencia.Peticion = @"EXEC PA_Usuarios_Insertar @nomUsuario,@pass,@estado";

                //SqlParameter paramUsuario = new SqlParameter();
                //paramUsuario.Value = usuario.nombreUsuario;
                //paramUsuario.ParameterName = "@nomUsuario";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value =usuario.pass;
                //paramUsuario.ParameterName = "@pass";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value = usuario.estadoUsuario;
                //paramUsuario.ParameterName = "@estado";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.Bit;



                ////sentencia.lstParametros.Add(paramUsuario);
                //AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(sentencia); //Ejecucion de metodo en AD


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}


        //public static bool EliminarPerfil(Perfil per)
        //{
        //    try
        //    {
        //        //Construccion de instruccion de peticion a ejecutar - ELIMINAR
        //        SQLSentencia peticion = new SQLSentencia();
        //        peticion.Peticion = @"EXEC PA_Perfiles_Eliminar '" + per.nombrePerfil + "'";

        //        AD objacceso = new AD();
        //        return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static bool modificarPerfil(string p, string np)
        //{
        //    try
        //    {
        //        SQLSentencia peticion = new SQLSentencia();
        //        peticion.Peticion = @"EXEC PA_Perfiles_Modificar '" + p + "','" + np + "'";
        //        AD acceso = new AD();
        //        return acceso.ejecutarSentecia(peticion);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}







        #endregion

        #region UsuariosPorPerfiles

        public static bool agregarUsuarioPorPerfiles(int idUsuario, int idPerfil)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_UsuariosPorPerfiles_Insertar '" + idUsuario + "','" + idPerfil + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void pas2()
        {

        }

        public static DataTable ConsultaUsuarioYPerfilPorEstado(int u)
        {

            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_ConsultarUsuarioporEstado '" + u + "'";

                AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
                return objacceso.consultarUsuariosYPerfilPorEstado(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // lista Condutor 
        public static DataTable ListaCondutor()
        {

            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_GruaxChofer ";

                AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
                return objacceso.consultarUsuariosYPerfilPorEstado(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public static DataTable ConsultaCasaos(string u)
        {

            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_ListaCasosEstado '" + u + "'";

                AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
                return objacceso.consultarUsuariosYPerfilPorEstado(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // Consulta Ingreso de casos
        public static DataTable ConsultaIngresiCasaos()
        {

            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_ListaIngresoCaso ";

                AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
                return objacceso.consultarUsuariosYPerfilPorEstado(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // Consulta Choferes
        public static DataTable ConsultaChoferes()
        {

            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC Pa_ListaIngresoChofer ";

                AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
                return objacceso.consultarUsuariosYPerfilPorEstado(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion
        #endregion
        #region Metodos usuario




        public static bool Eliminar_Usuario(Usuario usuarios)
        {
            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Eliminar '" + usuarios.nombre + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public static bool agregarUsuario(Usuario usuario)
        {
            try
            {

                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Insertar '" + usuario.nombre + "','" + usuario.clave+ "','" + usuario.estadoContraseña + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD




                //SQLSentencia sentencia = new SQLSentencia();

                //sentencia.Peticion = @"EXEC PA_Usuarios_Insertar @nomUsuario,@pass,@estado";

                //SqlParameter paramUsuario = new SqlParameter();
                //paramUsuario.Value = usuario.nombreUsuario;
                //paramUsuario.ParameterName = "@nomUsuario";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value =usuario.pass;
                //paramUsuario.ParameterName = "@pass";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value = usuario.estadoUsuario;
                //paramUsuario.ParameterName = "@estado";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.Bit;



                ////sentencia.lstParametros.Add(paramUsuario);
                //AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(sentencia); //Ejecucion de metodo en AD


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool modificarUsuario(Usuario u)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Modificar '" + u.nombre + "','" + u.clave+ "','" + u.estadoContraseña + "','" + u.idUsuario + "'";
                AD acceso = new AD();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static List<Usuario> ConsultaUsuarioId(string u)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_ConsultarId '" + u + "'";

                AD objacceso = new AD();
                return objacceso.consultarUsuarios(peticion);


            }

            catch (Exception e)
            {
                throw e;
            }


        }

        public static List<Usuario> ConsultaUsuario(Usuario usuario)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Consultar '" + usuario.nombre + "'";

                AD objacceso = new AD();
                return objacceso.consultarUsuarios(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        #endregion

        #region Camilla

        /// <summary>
        /// Metodo para agregar camillas
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>

        public static bool agregarCamilla(Camilla c) {

            try {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion= @"EXEC PA_AgregarCamilla @est";
                SqlParameter paramCamilla = new SqlParameter();
                paramCamilla.Value = c.estadoCamilla;
                paramCamilla.ParameterName = "@est";
                paramCamilla.SqlDbType = System.Data.SqlDbType.VarChar;
                 sentencia.lstParametros.Add(paramCamilla);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);


            }
            catch (Exception ex) {
                throw ex;
            }
        }


        /// <summary>
        /// Metodo para modificar las camillas
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool modificarCamillas(int id,string ne) {
            try {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_ModificarCamilla @Nc, @ne";

                SqlParameter paramNumCamilla = new SqlParameter();
                paramNumCamilla.Value = id;
                paramNumCamilla.ParameterName = "@Nc";
                paramNumCamilla.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter paramEstCamilla = new SqlParameter();
                paramEstCamilla.Value = ne;
                paramEstCamilla.ParameterName = "@ne";
                paramEstCamilla.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramNumCamilla);
                sentencia.lstParametros.Add(paramEstCamilla);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);
                
            }
            catch (Exception e) {
                throw e;
            }
        }


        /// <summary>
        /// Metodo para eliminar camillas por id
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool eliminarCamilla(Camilla c) {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_EliminarCamilla @i";
                SqlParameter paramCamilla = new SqlParameter();
                paramCamilla.Value = c.NumeroCamilla;
                paramCamilla.ParameterName = "@i";
                paramCamilla.SqlDbType = System.Data.SqlDbType.Int;
                sentencia.lstParametros.Add(paramCamilla);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public static List<Camilla> ConsultaCamilla(Camilla camilla)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_ConsultarCamilla @est";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = camilla.estadoCamilla;
                paramC.ParameterName = "@est";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                AD acceso = new AD();
                return acceso.consultarCamillas(sentencia);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Sala
       public static bool agregarSala(Sala s) {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = "@exect PA_AgregarSala @nom";
                SqlParameter paramSala = new SqlParameter();
                paramSala.Value = s.nombre;
                paramSala.ParameterName = "@nom";
                paramSala.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramSala);
                AD acceso = new AD();
                return acceso




            }
            catch (Exception e) {
                throw e;
            }

        }



        #endregion

    }
}
