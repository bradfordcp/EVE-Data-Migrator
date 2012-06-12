class MapRegion < ActiveRecord::Base
  self.table_name = :mapRegions
  self.primary_key = :regionID

  attr_accessible :regionID, :regionName, :x, :y, :z, :xMin, :xMax, :yMin, :yMax, :zMin, :zMax, :factionID, :radius
end
