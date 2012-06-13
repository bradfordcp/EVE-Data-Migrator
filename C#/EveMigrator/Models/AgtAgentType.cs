using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class AgtAgentType : Model
    {
        public AgtAgentType()
            : base()
        {
            this._tableName = "agtAgentTypes";
        }

        public override System.Data.SqlClient.SqlCommand SelectCommand()
        {
            StringBuilder selectStatementBuilder = new StringBuilder("SELECT agentTypeID, agentType FROM [dbo].[");
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
            insertCommandBuilder.Append("(agentTypeId, agentType)");
            insertCommandBuilder.Append(" VALUES ");
            insertCommandBuilder.Append("(?agentTypeId, ?agentType)");
            insertCommand.CommandText = insertCommandBuilder.ToString();

            insertCommand.Parameters.AddWithValue("?agentTypeId", sqlReader.GetValue(0));
            insertCommand.Parameters.AddWithValue("?agentType", sqlReader.GetValue(1));

            return insertCommand;
        } 
    }
}
