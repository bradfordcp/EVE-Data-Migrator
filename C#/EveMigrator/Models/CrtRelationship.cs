using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrtRelationship : Model
    {
        public CrtRelationship(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crtRelationships";

            this._fields.Add("relationshipID");
            this._fields.Add("parentID");
            this._fields.Add("parentTypeID");
            this._fields.Add("parentLevel");
            this._fields.Add("childID");
        }
    }
}
