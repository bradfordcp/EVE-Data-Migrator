using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EveMigrator.Models;

namespace EveMigrator.Processors
{
    class Processor
    {
        const String mysql_conn_string = "Server=127.0.0.1;Uid=eve;pwd=foobarbaz;Database=killboard_development";
        const String sqlserver_conn_string = "Server=127.0.0.1;User id=eve;pwd=foobarbaz;database=Inferno17";

        protected List<Model> models;
        protected MySql.Data.MySqlClient.MySqlConnection mysql_conn;
        protected System.Data.SqlClient.SqlConnection sqlserver_conn;

        /// <summary>
        /// Add all associated models to the models data structure prior to calling process
        /// </summary>
        public Processor()
        {
            models = new List<Model>();

            // Connect to our SQL Server Instance Running Locally
            this.sqlserver_conn = new System.Data.SqlClient.SqlConnection();
            this.sqlserver_conn.ConnectionString = sqlserver_conn_string;

            // Connect to our MySQL Server Instance Running Locally
            this.mysql_conn = new MySql.Data.MySqlClient.MySqlConnection();
            this.mysql_conn.ConnectionString = mysql_conn_string;
        }

        /// <summary>
        /// Processes the models this processor is in charge of. This includes:
        /// 1. Truncating existing target data
        /// 2. Loading current data
        /// 3. Writing current data to target store
        /// </summary>
        public void process()
        {
            this.mysql_conn.Open();
            this.sqlserver_conn.Open();

            this.truncateMySqlTables();
            this.processModels();

            this.mysql_conn.Close();
            this.sqlserver_conn.Close();
        }

        /// <summary>
        /// Iterates over all tables used and truncates them
        /// </summary>
        protected void truncateMySqlTables()
        {
            List<Model>.Enumerator enumerator = models.GetEnumerator();

            while (enumerator.MoveNext())
            {
                this.truncateMySqlTable(enumerator.Current);
            }
        }

        /// <summary>
        /// Truncates the MySql table linked to the model
        /// </summary>
        /// <param name="model">Model to be truncated</param>
        protected void truncateMySqlTable(Model model)
        {
            StringBuilder truncateStatementBuilder = new StringBuilder("TRUNCATE ");
            truncateStatementBuilder.Append(model.TableName);
            Console.Out.WriteLine(truncateStatementBuilder.ToString());

            MySql.Data.MySqlClient.MySqlCommand truncateCommand = this.mysql_conn.CreateCommand();
            truncateCommand.CommandText = truncateStatementBuilder.ToString();
            truncateCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Iterates over every added model and calls process
        /// </summary>
        protected void processModels()
        {
            List<Model>.Enumerator enumerator = models.GetEnumerator();

            while (enumerator.MoveNext())
            {
                this.processModel(enumerator.Current);
            }
        }

        /// <summary>
        /// Pulls the records out of the SQL Server database and pushes into MySQL
        /// </summary>
        /// <param name="model"></param>
        protected void processModel(Model model) {
            StringBuilder startingLine = new StringBuilder("Starting ");
            startingLine.Append(model.TableName);
            Console.WriteLine(startingLine.ToString());

            System.Data.SqlClient.SqlCommand selectCommand = model.SelectCommand();
            System.Data.SqlClient.SqlDataReader selectReader = selectCommand.ExecuteReader();
            try
            {
                int i = 0;
                StringBuilder lineBuilder;
                while (selectReader.Read())
                {
                    // Convert the record into an insert command
                    MySql.Data.MySqlClient.MySqlCommand insertCommand = model.convertToInsertCommand(selectReader);
                    insertCommand.ExecuteNonQuery();

                    if (i % 1000 == 0)
                    {
                        lineBuilder = new StringBuilder("Wrote ");
                        lineBuilder.Append(i);
                        lineBuilder.Append(" Rows");
                        Console.WriteLine(lineBuilder.ToString());
                    }
                    i++;
                }

                lineBuilder = new StringBuilder("Finished ");
                lineBuilder.Append(i);
                lineBuilder.Append(" Rows");
                Console.WriteLine(lineBuilder.ToString());
            }
            finally
            {
                selectReader.Close();
            }
        }
    }
}
