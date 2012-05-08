class WarCombatZone < ActiveRecord::Base
  self.table_name = :warCombatZones
  self.primary_key = :combatZoneID

  attr_accessible :combatZoneID, :combatZoneName, :factionID, :centerSystemID, :description
end
