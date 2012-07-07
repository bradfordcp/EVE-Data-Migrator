using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Processors
{
    class CorporationProcessor : Processor
    {
        public CorporationProcessor()
            : base()
        {
            this.models.Add(new Models.CrpActivity(this.mysql_conn, this.sqlserver_conn));
            //this.models.Add(new Models.CrpNPCCorporation(this.mysql_conn, this.sqlserver_conn)); // Fix SIZE field
            this.models.Add(new Models.CrpNPCCorporationResearchField(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.CrpNPCCorporationTrade(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.CrpNPCDivision(this.mysql_conn, this.sqlserver_conn));
        }
    }
}
