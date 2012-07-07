using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class DgmTypeEffect : Model
    {
        public DgmTypeEffect(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "dgmTypeEffects";

            this._fields.Add("typeID");
            this._fields.Add("effectID");
            this._fields.Add("isDefault");
        }
    }
}
