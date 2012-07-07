using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EveMigrator.Models;

namespace EveMigrator.Processors
{
    class EveProcessor : Processor
    {
        public EveProcessor()
            : base()
        {
            this.models.Add(new Models.EveGraphic(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.EveIcon(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.EveUnit(this.mysql_conn, this.sqlserver_conn));
        }
    }
}
