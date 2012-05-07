class ChrFaction < ActiveRecord::Base
  self.table_name = :chrFactions
  self.primary_key = :factionID
  
  attr_accessible :factionID, :factionName, :description, :raceIDs, :solarSystemID, :corporationID, :sizeFactor, :stationCount, :stationSystemCount, :militiaCorporationID, :iconID
end
