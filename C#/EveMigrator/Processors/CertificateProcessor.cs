using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Processors
{
    class CertificateProcessor : Processor
    {
        public CertificateProcessor()
            : base()
        {
            this.models.Add(new Models.CrtCategory(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.CrtCertificate(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.CrtClass(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.CrtRecommendation(this.mysql_conn, this.sqlserver_conn));
            this.models.Add(new Models.CrtRelationship(this.mysql_conn, this.sqlserver_conn));
        }
    }
}
