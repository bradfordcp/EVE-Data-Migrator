class MapConstellation < ActiveRecord::Base
  self.table_name = :mapConstellations
  self.primary_key = :constellationID

  attr_accessible :regionID, :constellationID, :constellationName, :x, :y, :z, :xMin, :xMax, :yMin, :yMax, :zMin, :zMax, :factionID, :radius
end
