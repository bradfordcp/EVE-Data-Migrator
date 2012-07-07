using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class AgtAgentType : Model
    {
        public AgtAgentType(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "agtAgentTypes";

            this._fields.Add("agentTypeID");
            this._fields.Add("agentType");
        }
    }
}
