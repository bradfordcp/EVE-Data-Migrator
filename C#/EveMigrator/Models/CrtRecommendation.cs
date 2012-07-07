using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrtRecommendation : Model
    {
        public CrtRecommendation(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crtRecommendations";

            this._fields.Add("recommendationID");
            this._fields.Add("shipTypeID");
            this._fields.Add("certificateID");
            this._fields.Add("recommendationLevel");
        }
    }
}
