using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;

namespace EveMigrator.Models
{
    class Model
    {
        public static MySql.Data.MySqlClient.MySqlConnection mysql_conn;
        public static System.Data.SqlClient.SqlConnection sqlserver_conn;

        protected String _tableName;

        public Model() {
            this._tableName = "";
        }

        public String TableName
        {
            get { return this._tableName; }
        }

        /// <summary>
        /// Command to select all rows in the table
        /// </summary>
        /// <returns></returns>
        public virtual System.Data.SqlClient.SqlCommand SelectCommand()
        {
            StringBuilder selectStatementBuilder = new StringBuilder("SELECT * FROM [dbo].[");
            selectStatementBuilder.Append(this.TableName);
            selectStatementBuilder.Append("]");

            System.Data.SqlClient.SqlCommand selectCommand = Model.sqlserver_conn.CreateCommand();
            selectCommand.CommandText = selectStatementBuilder.ToString();

            return selectCommand;
        }

        /// <summary>
        /// Command to insert the provided SQLServer record into the new schema
        /// </summary>
        /// <param name="sqlReader">sqlReader instance with the source information requiring transformation.</param>
        /// <returns></returns>
        public virtual MySql.Data.MySqlClient.MySqlCommand convertToInsertCommand(System.Data.SqlClient.SqlDataReader sqlReader)
        {
            StringBuilder insertCommandBuilder = new StringBuilder("INSERT INTO ");
            insertCommandBuilder.Append(this.TableName);

            MySql.Data.MySqlClient.MySqlCommand insertCommand = Model.mysql_conn.CreateCommand();
            insertCommand.CommandText = insertCommandBuilder.ToString();

            return insertCommand;
        }
    }
}
