using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class DgmAttributeType : Model
    {
        public DgmAttributeType(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "dgmAttributeTypes";

            this._fields.Add("attributeID");
            this._fields.Add("attributeName");
            this._fields.Add("description");
            this._fields.Add("iconID");
            this._fields.Add("defaultValue");
            this._fields.Add("published");
            this._fields.Add("displayName");
            this._fields.Add("unitID");
            this._fields.Add("stackable");
            this._fields.Add("highIsGood");
            this._fields.Add("categoryID");
        }
    }
}
