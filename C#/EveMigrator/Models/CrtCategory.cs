using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrtCategory : Model
    {
        public CrtCategory(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crtCategories";

            this._fields.Add("categoryID");
            this._fields.Add("description");
            this._fields.Add("categoryName");
        }
    }
}
