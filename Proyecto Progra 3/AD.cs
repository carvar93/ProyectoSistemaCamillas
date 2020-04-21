using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AccesoDatos
{
    public class AD
    {
        #region Atributos 

        private string cadenaconexion = Proyecto_Progra_3.Properties.Settings.Default.Conexion;
        private SqlConnection objconexion;

        #endregion

        #region Constructor

        public AD()
        {
            try
            {
                objconexion = new SqlConnection(cadenaconexion);
                this.ABRIR();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }

        #endregion

        #region Metodos

        #region PRIVADOS

        private void ABRIR()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }

        private void CERRAR()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }
        #endregion

        #region PUBLICOS
        #region ejecutarSentecia



        //nuevo

        public bool AgregarSentenciaEnTransaccion(SQLSentencia P_Peticion,
                                                 ref List<SqlCommand> P_Lista)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                //Ejecutar la sentencia
                P_Lista.Add(cmd);
                EjecutarTransaccion(P_Lista);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void r()
        {

            SqlTransaction objtran;
            ABRIR();
            objtran = objconexion.BeginTransaction();
            objtran.Rollback();

        }

        public bool EjecutarTransaccion(List<SqlCommand> P_Lista)
        {
            SqlTransaction objtran;
            ABRIR();
            objtran = objconexion.BeginTransaction();
            objtran.Save("s1");
           
                //Ejecucion en BD
                objtran.Commit();
            
            
            
                CERRAR();
            

            return true;

        }

        //nuevo








        //Metodo que ejecuta la sentencia para eliminar, modificar, agregar
        public bool ejecutarSentecia(SQLSentencia peticion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                this.ABRIR();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }
        #endregion




        #region Camilla

        public List<Camilla> consultarCamillas(SQLSentencia peticion)
        {
            List<Camilla> listaResultado = new List<Camilla>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        Camilla camilla = new Camilla();
                        camilla.NumeroCamilla = (int)item.ItemArray[0];
                        camilla.estadoCamilla = item.ItemArray[1].ToString();
                        listaResultado.Add(camilla);

                    }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return listaResultado;
        }


        #endregion


        public Usuario ConsultarAutenticacion(SQLSentencia P_Peticion)
        {
            Usuario resultado = new Usuario();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    resultado.nombre = dt.Rows[0].ItemArray[0].ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return resultado;
        }

        //verificar el los intentos de acceso
        public Usuario VerificarAcceso(SQLSentencia P_Peticion)
        {
            Usuario resultado = new Usuario();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    resultado.Intento =Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return resultado;
        }

        // actulizar el intento
        public bool ActulizarIntento(SQLSentencia peticion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                this.ABRIR();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }


        #region Sala


        public List<Sala> consultarSala(SQLSentencia peticion) {
            List<Sala> listaResultado = new List<Sala>();
            DataTable dt = new DataTable();

            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0) 
                    foreach (DataRow item in dt.Rows) {
                        Sala sala = new Sala();
                        sala.idSala = (int)item.ItemArray[0];
                        sala.nombre = item.ItemArray[1].ToString();
                        sala.cantidadCamillas = (int)item.ItemArray[2];
                        listaResultado.Add(sala);

                    }
                
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                this.CERRAR();
            }

            return listaResultado;
        }








        #endregion



        /// <summary>
        /// Metodo para consultar los perfiles del usuario autenticado
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
        public List<Perfil> ConsultarPerfiles(SQLSentencia P_Peticion)
        {
            List<Perfil> lstresultados = new List<Perfil>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Perfil p = new Perfil();

                        p.idPerfil = Convert.ToInt32(item.ItemArray[0].ToString());
                        p.nombre = item.ItemArray[1].ToString();

                        lstresultados.Add(p);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }



       

        #region consultarUsuarios
        //Metodo para cosultar lista de usuarios en la base de datos
        public List<Usuario> consultarUsuarios(SQLSentencia peticion)
        {
            List<Usuario> listaResultado = new List<Usuario>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());


                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        Usuario usuario = new Usuario();
                        usuario.idUsuario = (int)item.ItemArray[0];
                        usuario.nombre= item.ItemArray[1].ToString();
                        usuario.clave = item.ItemArray[2].ToString();
                        usuario.estadoContraseña = (bool)item.ItemArray[3];
                        usuario.correo= item.ItemArray[4].ToString();
                        listaResultado.Add(usuario);
                    }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return listaResultado;
        }
        #endregion



        public DataTable consultarUsuariosYPerfilPorEstado(SQLSentencia  peticion)
        {
          //  List<Caso> listaResultado = new List<Caso>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(peticion.Peticion, objconexion);

                da.Fill(dt);

             

             
               
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return dt;

        }


        #endregion
        #region S_METODOS
        #region Especialidad
        /// <summary>
        /// Metodo hace la consulta de la lista de las empecialidades 
        /// </summary>
        /// <param name="sentencia">SQLSentencia</param>
        /// <returns>Lista Especilaidad</returns>
        public List<Especialidad> consultarEspecialidades(SQLSentencia sentencia)
        {
            List<Especialidad> listaResultado = new List<Especialidad>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sentencia.Peticion;
                if (sentencia.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(sentencia.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Especialidad especialidad = new Especialidad();
                        especialidad.idEspecialidad = Convert.ToInt32(item.ItemArray[0]);
                        especialidad.nombre = item.ItemArray[1].ToString();
                        listaResultado.Add(especialidad);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaResultado;
        }

        #endregion
        #region Trabador
        /// <summary>
        /// Metodo hace la consulta de la lista de las Trabajadores 
        /// </summary>
        /// <param name="sentencia">SQLSentencia</param>
        /// <returns>Lista Trabajadores</returns>
        public List<Trabajador> consultarTrabajadores(SQLSentencia sentencia)
        {
            List<Trabajador> listaResultado = new List<Trabajador>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sentencia.Peticion;
                if (sentencia.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(sentencia.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Trabajador trabajador = new Trabajador();
                        trabajador.idTrabajador = Convert.ToInt32(item.ItemArray[0]);
                        trabajador.idEspecialidad = Convert.ToInt32(item.ItemArray[1]);
                        trabajador.nombre = item.ItemArray[2].ToString();
                        trabajador.nombre = item.ItemArray[3].ToString();
                        trabajador.cantidadPacientes = Convert.ToInt32(item.ItemArray[4]);
                        trabajador.añosExperiencia = Convert.ToInt32(item.ItemArray[5]);
                        listaResultado.Add(trabajador);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaResultado;
        }
        #endregion
        #region Paciente
        /// <summary>
        /// Metodo hace la consulta de la lista de las Trabajadores 
        /// </summary>
        /// <param name="sentencia">SQLSentencia</param>
        /// <returns>Lista Trabajadores</returns>
        public List<Paciente> consultarPacientes(SQLSentencia sentencia)
        {
            List<Paciente> listaResultado = new List<Paciente>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sentencia.Peticion;
                if (sentencia.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(sentencia.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Paciente paciente = new Paciente();
                        paciente.idPaciente = Convert.ToInt32(item.ItemArray[0]);
                        paciente.idTrabajador = Convert.ToInt32(item.ItemArray[1]);
                        paciente.nombre = item.ItemArray[2].ToString();
                        paciente.padecimiente = item.ItemArray[3].ToString();
                        paciente.motivoEmergencia = item.ItemArray[4].ToString();
                        paciente.Estado = item.ItemArray[5].ToString();
                        listaResultado.Add(paciente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaResultado;
        }
        #endregion
        #endregion
    }
    #endregion
}
