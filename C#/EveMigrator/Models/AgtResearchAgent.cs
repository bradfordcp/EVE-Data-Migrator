using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class AgtResearchAgent : Model
    {
        public AgtResearchAgent(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "agtResearchAgents";

            this._fields.Add("agentID");
            this._fields.Add("typeID");
        }
    }
}
