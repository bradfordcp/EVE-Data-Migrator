using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrpActivity : Model
    {
        public CrpActivity(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crpActivities";

            this._fields.Add("activityID");
            this._fields.Add("activityName");
            this._fields.Add("description");
        }
    }
}
