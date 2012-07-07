using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class EveUnit : Model
    {
        public EveUnit(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "eveUnits";

            this._fields.Add("unitID");
            this._fields.Add("unitName");
            this._fields.Add("displayName");
            this._fields.Add("description");
        }
    }
}
