using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class EveGraphic : Model
    {
        public EveGraphic(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "eveGraphics";

            this._fields.Add("graphicID");
            this._fields.Add("graphicFile");
            this._fields.Add("description");
            this._fields.Add("obsolete");
            this._fields.Add("graphicType");
            this._fields.Add("collidable");
            this._fields.Add("explosionID");
            this._fields.Add("directoryID");
            this._fields.Add("graphicName");
        }
    }
}
