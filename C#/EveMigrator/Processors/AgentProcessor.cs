using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EveMigrator.Models;

namespace EveMigrator.Processors
{
    class AgentProcessor : Processor
    {
        public AgentProcessor()
            : base()
        {
            this.models.Add(new Models.AgtAgent(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.AgtAgentType(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.AgtResearchAgent(this.mysql_conn, this.sqlserver_conn));
        }
    }
}
