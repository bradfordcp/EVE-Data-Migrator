using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrpNPCDivision : Model
    {
        public CrpNPCDivision(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crpNPCDivisions";

            this._fields.Add("divisionID");
            this._fields.Add("divisionName");
            this._fields.Add("description");
            this._fields.Add("leaderType");
        }
    }
}
