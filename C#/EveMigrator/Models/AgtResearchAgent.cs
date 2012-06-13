using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class AgtResearchAgent : Model
    {
        public AgtResearchAgent()
            : base()
        {
            this._tableName = "agtResearchAgents";
        }

        public override System.Data.SqlClient.SqlCommand SelectCommand()
        {
            StringBuilder selectStatementBuilder = new StringBuilder("SELECT agentID, typeID FROM [dbo].[");
            selectStatementBuilder.Append(this.TableName);
            selectStatementBuilder.Append("]");

            System.Data.SqlClient.SqlCommand selectCommand = Model.sqlserver_conn.CreateCommand();
            selectCommand.CommandText = selectStatementBuilder.ToString();

            return selectCommand;
        }

        public override MySql.Data.MySqlClient.MySqlCommand convertToInsertCommand(System.Data.SqlClient.SqlDataReader sqlReader)
        {
            MySql.Data.MySqlClient.MySqlCommand insertCommand = base.convertToInsertCommand(sqlReader);
            StringBuilder insertCommandBuilder = new StringBuilder(insertCommand.CommandText);
            insertCommandBuilder.Append("(agentID, typeID)");
            insertCommandBuilder.Append(" VALUES ");
            insertCommandBuilder.Append("(?agentTypeId, ?typeID)");
            insertCommand.CommandText = insertCommandBuilder.ToString();

            insertCommand.Parameters.AddWithValue("?agentID", sqlReader.GetValue(0));
            insertCommand.Parameters.AddWithValue("?typeID", sqlReader.GetValue(1));

            return insertCommand;
        } 
    }
}
