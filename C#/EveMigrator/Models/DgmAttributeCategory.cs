using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class DgmAttributeCategory : Model
    {
        public DgmAttributeCategory(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "dgmAttributeCategories";

            this._fields.Add("categoryID");
            this._fields.Add("categoryName");
            this._fields.Add("categoryDescription");
        }
    }
}
