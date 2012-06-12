using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;

using EveMigrator.Models;
using EveMigrator.Processors;

namespace EveMigrator
{
    class Program
    {
        const String mysql_conn_string = "Server=127.0.0.1;Uid=eve;pwd=foobarbaz;Database=killboard_development";
        const String sqlserver_conn_string = "Server=127.0.0.1;User id=eve;pwd=foobarbaz;database=Inferno17";

        static void Main(string[] args)
        {
            // Connect to our SQL Server Instance Running Locally
            Model.sqlserver_conn = new System.Data.SqlClient.SqlConnection();
            Model.sqlserver_conn.ConnectionString = sqlserver_conn_string;
            Model.sqlserver_conn.Open();

            // Connect to our MySQL Server Instance Running Locally
            Model.mysql_conn = new MySql.Data.MySqlClient.MySqlConnection();
            Model.mysql_conn.ConnectionString = mysql_conn_string;
            Model.mysql_conn.Open();

            // Process the Agent Tables
            AgentProcessor agentProcessor = new AgentProcessor();
            agentProcessor.process();

            Console.ReadLine();

            // Close out our connections
            Model.sqlserver_conn.Close();
            Model.mysql_conn.Close();
        }
    }
}
