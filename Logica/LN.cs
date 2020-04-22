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



        public static List<Camilla> ConsultaCamillaPorEstado(string camilla)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_ConsultarCamilla @est";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = camilla;
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

        #region AgregarSala
        public static bool agregarSala(Sala s) {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @" EXEC PA_AgregarSala @nom ,@c";

                SqlParameter paramn = new SqlParameter();
                paramn.Value = s.nombre;
                paramn.ParameterName = "@nom";
                paramn.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramc = new SqlParameter();
                paramc.Value = s.cantidadCamillas;
                paramc.ParameterName = "@c";
                paramc.SqlDbType = System.Data.SqlDbType.Int;


                sentencia.lstParametros.Add(paramn);
                sentencia.lstParametros.Add(paramc);

                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);
                
            }
            catch (Exception e) {
                throw e;
            }

        }
        #endregion

        #region modificar Cantidad de Camillas
        public static bool modificarCantidadCamillas(Sala s)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_ModificarCamilla @ne, @nom";

                SqlParameter paramidsala = new SqlParameter();
                paramidsala.Value = s.idSala;
                paramidsala.ParameterName = "@ne";
                paramidsala.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter paramnomSala = new SqlParameter();
                paramnomSala.Value = s.nombre;
                paramnomSala.ParameterName = "@nom";
                paramnomSala.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramidsala);
                sentencia.lstParametros.Add(paramnomSala);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }


        }
        #endregion

        #region modificar Sala
        public static bool modificarSala(Sala s) {
            try
            {
                SQLSentencia se = new SQLSentencia();
                se.Peticion= @"EXEC PA_ModificarSala @nom,@i";

                SqlParameter paramnom = new SqlParameter();
                paramnom.Value = s.nombre;
                paramnom.ParameterName="nom";
                paramnom.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramid = new SqlParameter();
                paramid.Value = s.idSala;
                paramid.ParameterName = "@i";
                paramid.SqlDbType = System.Data.SqlDbType.Int;

                se.lstParametros.Add(paramnom);
               se.lstParametros.Add(paramid);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(se);


            }
            catch(Exception e) {
                throw e;
            }


        }
        #endregion

        #region eliminar Sala
        public static bool eliminarSala(Sala s) {
            try {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion= @"EXEC PA_EliminarSala @nom";
                SqlParameter ids = new SqlParameter();
                ids.Value = s.nombre;
                ids.ParameterName = "@nom";
                ids.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(ids);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);

            }
            catch (Exception e) {
                throw e;
            }
           
        }
        #endregion

        #region consultar Sala
        public static List<Sala>consultarSala(Sala s) {
            try {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion= @"EXEC PA_ConsultarSala @nomb";

                SqlParameter nom = new SqlParameter();
                nom.Value = s.nombre;
                nom.ParameterName = "@nomb";
                nom.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(nom);
                AD ac = new AD();
                 return ac.consultarSala(sentencia);

            }
            catch (Exception e) {
                throw e;
            }

        }

        #endregion

        #region Agregar Camillas a la Sala
        
        public static bool agregaCamillaSala(int idS,int idC) {
            try {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion= @"EXEC PA_CamillaPorSala_Insertar @iS,@iC";

                SqlParameter paramiS = new SqlParameter();
                paramiS.Value = idS;
                paramiS.ParameterName = "@iS";
                paramiS.SqlDbType = System.Data.SqlDbType.Int;
               
                SqlParameter paramiC = new SqlParameter();
                paramiC.Value = idC;
                paramiC.ParameterName = "@iC";
                paramiC.SqlDbType = System.Data.SqlDbType.Int;

                sentencia.lstParametros.Add(paramiS);
                sentencia.lstParametros.Add(paramiC);

                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);



            }
            catch (Exception es) {
                throw es;

            }

        }
        #endregion

        #endregion

        #region Especialidad
        /// <summary>
        /// Se crea la peticion para ser consultada, la cual trae lista de especialidades
        /// </summary>
        /// <param name="especialidad"> Especialidad</param>
        /// <returns>Lista tipo Especialdad</returns>
        public static List<Especialidad> consultaEspecialidad()
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_S_EspecilidadCosulta";
                AD acceso = new AD();
                return acceso.consultarEspecialidades(peticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Se crea la peticion para ser consultada, la cual trae lista de especialidades
        /// </summary>
        /// <param name="especialidad"> Especialidad</param>
        /// <returns>Lista tipo Especialdad</returns>
        public static string consultaEspecialidad2(string t)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_S_EspecialidadConuslta2 @id";
                SqlParameter paramEspecialidad = new SqlParameter
                {
                    Value = Convert.ToInt32(t),
                    ParameterName = "@id",
                    SqlDbType = System.Data.SqlDbType.Int
                };
                peticion.lstParametros.Add(paramEspecialidad);
                AD acceso = new AD();
                return acceso.consultarEspecialidades2(peticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Se agreagar la perticion y se parametrizan los datos para agregar datos a Especialidad
        /// </summary>
        /// <param name="especialidad"> Especialdiad </param>
        public static void agregarEspecialidad(Especialidad especialidad)
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"EXEC PA_S_EspecilidadAgregar @nombre";
            SqlParameter paramEspecialidad = new SqlParameter();
            paramEspecialidad.Value = especialidad.nombre;
            paramEspecialidad.ParameterName = "@nombre";
            paramEspecialidad.SqlDbType = System.Data.SqlDbType.VarChar;
            sentencia.lstParametros.Add(paramEspecialidad);
            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
        }
        /// <summary>
        /// Parametriza los datos para modificar la especilaidad
        /// </summary>
        /// <param name="especialidad"></param>
        public static void modificarEspecialidad(Especialidad especialidad)
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"EXEC PA_S_EspecilidadModificar @id, @nombre";
            SqlParameter paramEspecialidad = new SqlParameter
            {
                Value = especialidad.idEspecialidad,
                ParameterName = "@id",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramEspecialidad);
            SqlParameter paramNombre = new SqlParameter
            {
                Value = especialidad.nombre,
                ParameterName = "@nombre",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramNombre);
            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
        }
        /// <summary>
        ///  Parametriza los datos para Eliminar la especilaidad
        /// </summary>
        /// <param name="especialidad"><Especialidad>
        public static void eliminarEspecialidad(Especialidad especialidad)
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"PA_S_EspecilidadEliminar @id";
            SqlParameter paramEspecialidad = new SqlParameter();
            paramEspecialidad.Value = especialidad.idEspecialidad;
            paramEspecialidad.ParameterName = "@id";
            paramEspecialidad.SqlDbType = System.Data.SqlDbType.Int;
            sentencia.lstParametros.Add(paramEspecialidad);
            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);

        }
        #endregion
        #region  Trabajador
        /// <summary>
        /// Se crea la peticion para ser consultada, la cual trae lista de Trabajadores
        /// </summary>
        /// <param name="trabajador"> Trabajador</param>
        /// <returns>Lista tipo Trabajador</returns>
        public static List<Trabajador> consultaTrabajador()
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_S_TrabajadorConsulta";
                AD acceso = new AD();
                return acceso.consultarTrabajadores(peticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Parametriza los datos para agreagar un trabajador
        /// </summary>
        /// <param name="trabajador"></Trabajador>
        public static void agregarTrabajador(Trabajador trabajador)
        {
            try
            {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"EXEC PA_S_TrabajadorAgregar @especialidad, @nombre, @puesto, @cantidadP, @añosE";
            SqlParameter paramEspecialidad = new SqlParameter
            {
                Value = trabajador.idEspecialidad,
                ParameterName = "@especialidad",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramEspecialidad);
            SqlParameter paramNombre = new SqlParameter
            {
                Value = trabajador.nombre,
                ParameterName = "@nombre",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramNombre);
            SqlParameter paramPuesto = new SqlParameter
            {
                Value = trabajador.puesto,
                ParameterName = "@puesto",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
                sentencia.lstParametros.Add(paramPuesto);
                SqlParameter paramCantidadP = new SqlParameter
            {
                Value = trabajador.cantidadPacientes,
                ParameterName = "@cantidadP",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramCantidadP);
            SqlParameter paramAñosE = new SqlParameter
            {
                Value = trabajador.añosExperiencia,
                ParameterName = "@añosE",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramAñosE);

            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Parametriza los datos para Modificar un trabajador
        /// </summary>
        /// <param name="trabajador"></Trabajador>
        public static void ModificarTrabajador(Trabajador trabajador)
        {
            try
            {
              SQLSentencia sentencia = new SQLSentencia(); 
            sentencia.Peticion = @"EXEC PA_S_TrabajadorModificar @idTrabajador, @idEspecialidad, @nombre, @puesto, @cantidadPacientes, @añosExperiencia";
            SqlParameter paramTrabajador = new SqlParameter
            {
                Value = trabajador.idTrabajador,
                ParameterName = "@idTrabajador",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramTrabajador);
            SqlParameter paramEspecialidad = new SqlParameter
            {
                Value = trabajador.idEspecialidad,
                ParameterName = "@idEspecialidad",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramEspecialidad);
            SqlParameter paramNombre = new SqlParameter
            {
                Value = trabajador.nombre,
                ParameterName = "@nombre",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramNombre);
            SqlParameter paramPuesto = new SqlParameter
            {
                Value = trabajador.puesto,
                ParameterName = "@puesto",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramPuesto);
            SqlParameter paramCantidadP = new SqlParameter
            {
                Value = trabajador.cantidadPacientes,
                ParameterName = "@cantidadPacientes",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramCantidadP);
            SqlParameter paramAñosE = new SqlParameter
            {
                Value = trabajador.añosExperiencia,
                ParameterName = "@añosExperiencia",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramAñosE);

            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Parametriza los datos para Eliminar un trabajador
        /// </summary>
        /// <param name="trabajador"></Trabajador>
        public static void eliminarTrabajador(Trabajador trabajador)
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"EXEC PA_S_TrabajadorEliminar @idTrabajador";
            SqlParameter paramTrabajador = new SqlParameter();
            paramTrabajador.Value = trabajador.idTrabajador;
            paramTrabajador.ParameterName = "@idTrabajador";
            paramTrabajador.SqlDbType = System.Data.SqlDbType.Int;
            sentencia.lstParametros.Add(paramTrabajador);
            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
        }
        #endregion
        #region Paciente
        /// <summary>
        /// Se crea la peticion para ser consultada, la cual trae lista de Pacientes
        /// </summary>
        /// <param name="especialidad"> Paciente</param>
        /// <returns>Lista tipo Paciente</returns>
        public static List<Paciente> consultaPaciente()
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_S_PacienteConsutar";
                AD acceso = new AD();
                return acceso.consultarPacientes(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Parametrisa los datos  para agreagar en paciente
        /// </summary>
        /// <param name="paciente"> Paciente</param>
        public static void agregarPaciente(Paciente paciente)
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"PA_S_PacienteaAgregar @idTrabajador, @nombre, @padecimiente, @motivoEmergencia, @Estado";
            SqlParameter paramTrabajador = new SqlParameter
            {
                Value = paciente.idTrabajador,
                ParameterName = "@idTrabajador",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramTrabajador);
            SqlParameter paramNombre = new SqlParameter
            {
                Value = paciente.nombre,
                ParameterName = "@nombre",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramNombre);
            SqlParameter paramPadecimiente = new SqlParameter
            {
                Value = paciente.padecimiente,
                ParameterName = "@padecimiente",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramPadecimiente);
            SqlParameter paramMotivoEmergencia = new SqlParameter
            {
                Value = paciente.motivoEmergencia,
                ParameterName = "@motivoEmergencia",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramMotivoEmergencia);
            SqlParameter paramEstado = new SqlParameter
            {
                Value = paciente.Estado,
                ParameterName = "@Estado",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramEstado);

            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
        }
        /// <summary>
        /// Parametrisa los datos  para Modificar en paciente
        /// </summary>
        /// <param name="paciente"> Paciente</param>
        public static void ModificarPaciente(Paciente paciente)
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"PA_S_PacienteaModificar @idPaciente, @idTrabajador, @nombre, @padecimiente, @motivoEmergencia, @Estado";
            SqlParameter paramPaciente = new SqlParameter
            {
                Value = paciente.idPaciente,
                ParameterName = "@idPaciente",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramPaciente);
            SqlParameter paramTrabajador = new SqlParameter
            {
                Value = paciente.idTrabajador,
                ParameterName = "@idTrabajador",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramTrabajador);
            SqlParameter paramNombre = new SqlParameter
            {
                Value = paciente.nombre,
                ParameterName = "@nombre",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramNombre);
            SqlParameter paramPadecimiente = new SqlParameter
            {
                Value = paciente.padecimiente,
                ParameterName = "@padecimiente",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramPadecimiente);
            SqlParameter paramMotivoEmergencia = new SqlParameter
            {
                Value = paciente.motivoEmergencia,
                ParameterName = "@motivoEmergencia",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramMotivoEmergencia);
            SqlParameter paramEstado = new SqlParameter
            {
                Value = paciente.Estado,
                ParameterName = "@Estado",
                SqlDbType = System.Data.SqlDbType.VarChar
            };
            sentencia.lstParametros.Add(paramEstado);

            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
        }
        /// <summary>
        /// Parametrisa los datos  para eliminar en paciente
        /// </summary>
        /// <param name="paciente"> Paciente</param>
        public static void eliminarTrabajador(Paciente paciente)
        {
            SQLSentencia sentencia = new SQLSentencia
            {
                Peticion = @"PA_S_PacienteaEliminar @idPaciente"
            };
            SqlParameter paramPaciente = new SqlParameter
            {
                Value = paciente.idPaciente,
                ParameterName = "@idPaciente",
                SqlDbType = System.Data.SqlDbType.Int
            };
            sentencia.lstParametros.Add(paramPaciente);
            AD acceso = new AD();
            acceso.ejecutarSentecia(sentencia);
        }
        #endregion
    }
}
