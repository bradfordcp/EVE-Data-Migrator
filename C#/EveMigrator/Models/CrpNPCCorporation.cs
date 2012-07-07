using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrpNPCCorporation : Model
    {
        public CrpNPCCorporation(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crpNPCCorporations";

            this._fields.Add("corporationID");
            this._fields.Add("size");
            this._fields.Add("extent");
            this._fields.Add("solarSystemID");
            this._fields.Add("investorID1");
            this._fields.Add("investorShares1");
            this._fields.Add("investorID2");
            this._fields.Add("investorShares2");
            this._fields.Add("investorID3");
            this._fields.Add("investorShares3");
            this._fields.Add("investorID4");
            this._fields.Add("investorShares4");
            this._fields.Add("friendID");
            this._fields.Add("enemyID");
            this._fields.Add("publicShares");
            this._fields.Add("initialPrice");
            this._fields.Add("minSecurity");
            this._fields.Add("scattered");
            this._fields.Add("fringe");
            this._fields.Add("corridor");
            this._fields.Add("hub");
            this._fields.Add("border");
            this._fields.Add("factionID");
            this._fields.Add("sizeFactor");
            this._fields.Add("stationCount");
            this._fields.Add("stationSystemCount");
            this._fields.Add("description");
            this._fields.Add("iconID");
        }
    }
}
