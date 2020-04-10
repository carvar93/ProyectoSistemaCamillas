using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SQLSentencia
    {
        #region Propiedades
        public string Peticion { get; set; }
        public List<SqlParameter> lstParametros { get; set; }
        #endregion

        #region Constructor
        public SQLSentencia()
        {
            Peticion = string.Empty;
            lstParametros = new List<SqlParameter>();
        }

        #endregion
    }
}
