using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Processors
{
    class WarProcessor : Processor
    {
        public WarProcessor()
            : base()
        {
            this.models.Add(new Models.WarCombatZoneSystem(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.WarCombatZone(this.mysql_conn, this.sqlserver_conn));
        }
    }
}
