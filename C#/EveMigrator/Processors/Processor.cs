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

        protected void processModels()
        {
            List<Model>.Enumerator enumerator = models.GetEnumerator();

            while (enumerator.MoveNext())
            {
                this.processModel(enumerator.Current);
            }
        }

        protected void processModel(Model model) {
            StringBuilder selectStatementBuilder = new StringBuilder("SELECT * FROM [dbo].[");
            selectStatementBuilder.Append(model.TableName);
            selectStatementBuilder.Append("]");
            Console.Out.WriteLine(selectStatementBuilder.ToString());

            System.Data.SqlClient.SqlCommand selectCommand = Model.sqlserver_conn.CreateCommand();
            selectCommand.CommandText = selectStatementBuilder.ToString();
            System.Data.SqlClient.SqlDataReader selectReader = selectCommand.ExecuteReader();
            try
            {
                System.Data.DataTable schema = selectReader.GetSchemaTable();
                while (selectReader.Read())
                {
                    for (int x = 0; x < schema.Rows.Count; x++)
                    {
                        Console.WriteLine(selectReader.GetValue(x).ToString());
                    }
                    Console.WriteLine();
                }
            }
            finally
            {
                selectReader.Close();
            }
        }
    }
}
