using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class AgtAgent : Model
    {
        public AgtAgent(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "agtAgents";

            this._fields.Add("agentID");
            this._fields.Add("divisionID");
            this._fields.Add("corporationID");
            this._fields.Add("locationID");
            this._fields.Add("level");
            this._fields.Add("quality");
            this._fields.Add("agentTypeID");
            this._fields.Add("isLocator");
        }
    }
}
