using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class ChrRace : Model
    {
        public ChrRace(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "chrRaces";

            this._fields.Add("raceID");
            this._fields.Add("raceName");
            this._fields.Add("description");
            this._fields.Add("iconID");
            this._fields.Add("shortDescription");
        }
    }
}
