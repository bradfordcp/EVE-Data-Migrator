class WarCombatZoneSystem < ActiveRecord::Base
  self.table_name = :warCombatZoneSystems
  self.primary_key = :solarSystemID

  attr_accessible :solarSystemID, :combatZoneID
end
