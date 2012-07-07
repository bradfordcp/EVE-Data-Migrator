using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class DgmTypeAttribute : Model
    {
        public DgmTypeAttribute(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "dgmTypeAttributes";

            this._fields.Add("typeID");
            this._fields.Add("attributeID");
            this._fields.Add("valueInt");
            this._fields.Add("valueFloat");
        }
    }
}
