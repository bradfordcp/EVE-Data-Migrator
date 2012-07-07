using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class EveIcon : Model
    {
        public EveIcon(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "eveIcons";

            this._fields.Add("iconID");
            this._fields.Add("iconFile");
            this._fields.Add("description");
        }
    }
}
