using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Processors
{
    class AgentProcessor : Processor
    {
        public AgentProcessor()
            : base()
        {
            this.models.Add(new Models.AgtAgent());
        }


    }
}
