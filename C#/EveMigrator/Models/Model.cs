using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;

namespace EveMigrator.Models
{
    class Model
    {
        public static MySql.Data.MySqlClient.MySqlConnection mysql_conn;
        public static System.Data.SqlClient.SqlConnection sqlserver_conn;

        protected String _tableName;

        public Model() {
            this._tableName = "";
        }

        public String TableName
        {
            get { return this._tableName; }
        }
    }
}
