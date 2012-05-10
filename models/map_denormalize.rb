class MapDenormalize < ActiveRecord::Base
  self.table_name = :mapDenormalize
  self.primary_key = :itemID

  attr_accessible :itemID, :typeID, :groupID, :solarSystemID, :constellationID, :regionID, :orbitID, :x, :y, :z, :radius, :itemName, :security, :celestialIndex, :orbitIndex
end
