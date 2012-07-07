using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class ChrAncestry : Model
    {
        public ChrAncestry(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "chrAncestries";

            this._fields.Add("ancestryID");
            this._fields.Add("ancestryName");
            this._fields.Add("bloodlineID");
            this._fields.Add("description");
            this._fields.Add("perception");
            this._fields.Add("willpower");
            this._fields.Add("charisma");
            this._fields.Add("memory");
            this._fields.Add("intelligence");
            this._fields.Add("iconID");
            this._fields.Add("shortDescription");
        }
    }
}
