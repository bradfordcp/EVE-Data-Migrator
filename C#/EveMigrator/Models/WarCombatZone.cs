using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class WarCombatZone : Model
    {
        public WarCombatZone(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "warCombatZones";

            this._fields.Add("combatZoneID");
            this._fields.Add("combatZoneName");
            this._fields.Add("factionID");
            this._fields.Add("centerSystemID");
            this._fields.Add("description");
        }
    }
}
