using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveMigrator.Models
{
    class DgmEffect : Model
    {
        public DgmEffect(MySql.Data.MySqlClient.MySqlConnection mysql_connection, System.Data.SqlClient.SqlConnection sqlserver_connection)
            : base(mysql_connection, sqlserver_connection)
        {
            this._tableName = "dgmEffects";

            this._fields.Add("effectID");
            this._fields.Add("effectName");
            this._fields.Add("effectCategory");
            this._fields.Add("preExpression");
            this._fields.Add("postExpression");
            this._fields.Add("description");
            this._fields.Add("guid");
            this._fields.Add("iconID");
            this._fields.Add("isOffensive");
            this._fields.Add("isAssistance");
            this._fields.Add("durationAttributeID");
            this._fields.Add("trackingSpeedAttributeID");
            this._fields.Add("dischargeAttributeID");
            this._fields.Add("rangeAttributeID");
            this._fields.Add("falloffAttributeID");
            this._fields.Add("disallowAutoRepeat");
            this._fields.Add("published");
            this._fields.Add("displayName");
            this._fields.Add("isWarpSafe");
            this._fields.Add("rangeChance");
            this._fields.Add("electronicChance");
            this._fields.Add("propulsionChance");
            this._fields.Add("distribution");
            this._fields.Add("sfxName");
            this._fields.Add("npcUsageChanceAttributeID");
            this._fields.Add("npcActivationChanceAttributeID");
            this._fields.Add("fittingUsageChanceAttributeID");
        }
    }
}
