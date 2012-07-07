using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class WarCombatZoneSystem : Model
    {
        public WarCombatZoneSystem(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "warCombatZoneSystems";

            this._fields.Add("solarSystemID");
            this._fields.Add("combatZoneID");
        }
    }
}
