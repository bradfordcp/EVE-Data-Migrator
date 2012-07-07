using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrpNPCCorporationDivision : Model
    {
        public CrpNPCCorporationDivision(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crpNPCCorporationDivisions";

            this._fields.Add("corporationID");
            this._fields.Add("divisionID");
            this._fields.Add("size");
        }
    }
}
