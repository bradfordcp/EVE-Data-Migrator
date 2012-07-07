using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class ChrBloodline : Model
    {
        public ChrBloodline(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "chrBloodlines";

            this._fields.Add("bloodlineID");
            this._fields.Add("raceID");
            this._fields.Add("description");
            this._fields.Add("maleDescription");
            this._fields.Add("femaleDescription");
            this._fields.Add("shipTypeID");
            this._fields.Add("corporationID");
            this._fields.Add("perception");
            this._fields.Add("willpower");
            this._fields.Add("charisma");
            this._fields.Add("memory");
            this._fields.Add("intelligence");
            this._fields.Add("iconID");
            this._fields.Add("shortDescription");
            this._fields.Add("shortMaleDescription");
            this._fields.Add("shortFemaleDescription");
        }
    }
}
