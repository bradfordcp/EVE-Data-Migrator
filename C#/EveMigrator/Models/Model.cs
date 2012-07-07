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
        protected String _tableName;
        protected List<String> _fields;
        protected MySql.Data.MySqlClient.MySqlConnection mysql_connection;
        protected System.Data.SqlClient.SqlConnection sqlserver_connection;

        public Model(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
        {
            this._tableName = "";
            this._fields = new List<String>();

            this.mysql_connection = mysql_connection;
            this.sqlserver_connection = sqlserver_connection;
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
            StringBuilder selectStatementBuilder = new StringBuilder("SELECT ");

            List<String>.Enumerator iterator = this._fields.GetEnumerator();
            int idx = 0;
            while (iterator.MoveNext())
            {
                selectStatementBuilder.Append(iterator.Current);

                if (idx < this._fields.Count - 1)
                {
                    selectStatementBuilder.Append(", ");
                }

                idx++;
            }

            selectStatementBuilder.Append(" FROM [dbo].[");
            selectStatementBuilder.Append(this.TableName);
            selectStatementBuilder.Append("]");

            System.Data.SqlClient.SqlCommand selectCommand = this.sqlserver_connection.CreateCommand();
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
            insertCommandBuilder.Append(" (");

            List<String>.Enumerator iterator = this._fields.GetEnumerator();
            int idx = 0;
            while (iterator.MoveNext())
            {
                insertCommandBuilder.Append(iterator.Current);

                if (idx < this._fields.Count - 1)
                {
                    insertCommandBuilder.Append(", ");
                }

                idx++;
            }

            insertCommandBuilder.Append(") VALUES (");

            // TODO Iterate once building both the values and parameters section
            iterator = this._fields.GetEnumerator();
            idx = 0;
            while (iterator.MoveNext())
            {
                insertCommandBuilder.Append("?");
                insertCommandBuilder.Append(iterator.Current);

                if (idx < this._fields.Count - 1)
                {
                    insertCommandBuilder.Append(", ");
                }

                idx++;
            }

            insertCommandBuilder.Append(")");

            MySql.Data.MySqlClient.MySqlCommand insertCommand = this.mysql_connection.CreateCommand();
            insertCommand.CommandText = insertCommandBuilder.ToString();

            // TODO Iterate once building both the values and parameters section
            iterator = this._fields.GetEnumerator();
            idx = 0;
            StringBuilder paramBuilder = null;
            while (iterator.MoveNext())
            {
                paramBuilder = new StringBuilder("?");
                paramBuilder.Append(iterator.Current);
                insertCommand.Parameters.AddWithValue(paramBuilder.ToString(), sqlReader.GetValue(idx));

                idx++;
            }

            return insertCommand;
        }
    }
}
