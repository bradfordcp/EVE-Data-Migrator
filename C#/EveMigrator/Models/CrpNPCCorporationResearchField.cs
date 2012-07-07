using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrpNPCCorporationResearchField : Model
    {
        public CrpNPCCorporationResearchField(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crpNPCCorporationResearchFields";

            this._fields.Add("skillID");
            this._fields.Add("corporationID");
        }
    }
}
