using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EveMigrator.Models;

namespace EveMigrator.Processors
{
    class CharacterProcessor : Processor
    {
        public CharacterProcessor()
            : base()
        {
            this.models.Add(new Models.ChrAncestry(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.ChrAttribute(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.ChrBloodline(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.ChrFaction(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.ChrRace(this.mysql_conn, this.sqlserver_conn));
        }
    }
}
