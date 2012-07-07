using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrtClass : Model
    {
        public CrtClass(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crtClasses";

            this._fields.Add("classID");
            this._fields.Add("description");
            this._fields.Add("className");
        }
    }
}
