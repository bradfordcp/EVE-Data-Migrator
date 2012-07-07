using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrpNPCCorporationTrade : Model
    {
        public CrpNPCCorporationTrade(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crpNPCCorporationTrades";

            this._fields.Add("corporationID");
            this._fields.Add("typeID");
        }
    }
}
