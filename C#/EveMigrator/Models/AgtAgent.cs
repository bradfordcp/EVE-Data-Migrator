using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class AgtAgent : Model
    {
        public AgtAgent() : base()
        {
            this._tableName = "agtAgents";
        }

        public override System.Data.SqlClient.SqlCommand SelectCommand()
        {
            StringBuilder selectStatementBuilder = new StringBuilder("SELECT agentID, divisionID, corporationID, locationID, level, quality, agentTypeID, isLocator FROM [dbo].[");
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
            insertCommandBuilder.Append("(agentID, divisionID, corporationID, locationID, level, quality, agentTypeId, isLocator)");
            insertCommandBuilder.Append(" VALUES ");
            insertCommandBuilder.Append("(?agentID, ?divisionID, ?corporationID, ?locationID, ?level, ?quality, ?agentTypeId, ?isLocator)");
            insertCommand.CommandText = insertCommandBuilder.ToString();

            insertCommand.Parameters.AddWithValue("?agentID", sqlReader.GetValue(0));
            insertCommand.Parameters.AddWithValue("?divisionID", sqlReader.GetValue(1));
            insertCommand.Parameters.AddWithValue("?corporationID", sqlReader.GetValue(2));
            insertCommand.Parameters.AddWithValue("?locationID", sqlReader.GetValue(3));
            insertCommand.Parameters.AddWithValue("?level", sqlReader.GetValue(4));
            insertCommand.Parameters.AddWithValue("?quality", sqlReader.GetValue(5));
            insertCommand.Parameters.AddWithValue("?agentTypeId", sqlReader.GetValue(6));
            insertCommand.Parameters.AddWithValue("?isLocator", sqlReader.GetValue(7));

            return insertCommand;
        } 
    }
}
