using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class ChrFaction : Model
    {
        public ChrFaction(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "chrFactions";

            this._fields.Add("factionID");
            this._fields.Add("factionName");
            this._fields.Add("description");
            this._fields.Add("raceIDs");
            this._fields.Add("solarSystemID");
            this._fields.Add("corporationID");
            this._fields.Add("sizeFactor");
            this._fields.Add("stationCount");
            this._fields.Add("stationSystemCount");
            this._fields.Add("militiaCorporationID");
            this._fields.Add("iconID");
        }
    }
}
