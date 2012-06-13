using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EveMigrator.Models;

namespace EveMigrator.Processors
{
    class Processor
    {
        protected List<Model> models;

        /// <summary>
        /// Add all associated models to the models data structure prior to calling process
        /// </summary>
        public Processor()
        {
            models = new List<Model>();
        }

        /// <summary>
        /// Processes the models this processor is in charge of. This includes:
        /// 1. Truncating existing target data
        /// 2. Loading current data
        /// 3. Writing current data to target store
        /// </summary>
        public void process()
        {
            this.truncateMySqlTables();
            this.processModels();
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

            MySql.Data.MySqlClient.MySqlCommand truncateCommand = Model.mysql_conn.CreateCommand();
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
                while (selectReader.Read())
                {
                    // Convert the record into an insert command
                    MySql.Data.MySqlClient.MySqlCommand insertCommand = model.convertToInsertCommand(selectReader);
                    insertCommand.ExecuteNonQuery();
                }
            }
            finally
            {
                selectReader.Close();
            }
        }
    }
}
