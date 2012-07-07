using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class CrtCertificate : Model
    {
        public CrtCertificate(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "crtCertificates";

            this._fields.Add("certificateID");
            this._fields.Add("categoryID");
            this._fields.Add("classID");
            this._fields.Add("grade");
            this._fields.Add("corpID");
            this._fields.Add("iconID");
            this._fields.Add("description");
        }
    }
}
