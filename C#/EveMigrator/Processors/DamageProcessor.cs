using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Processors
{
    class DamageProcessor : Processor
    {
        public DamageProcessor()
            : base()
        {
            this.models.Add(new Models.DgmTypeEffect(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.DgmTypeAttribute(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.DgmEffect(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.DgmAttributeType(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.DgmAttributeCategory(this.mysql_conn, this.sqlserver_conn));
        }
    }
}
