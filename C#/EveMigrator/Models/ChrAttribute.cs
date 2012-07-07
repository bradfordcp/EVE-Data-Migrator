using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class ChrAttribute : Model
    {
        public ChrAttribute(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "chrAttributes";

            this._fields.Add("attributeID");
            this._fields.Add("attributeName");
            this._fields.Add("description");
            this._fields.Add("iconID");
            this._fields.Add("shortDescription");
            this._fields.Add("notes");
        }
    }
}
