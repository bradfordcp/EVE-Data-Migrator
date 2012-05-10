class MapUniverse < ActiveRecord::Base
  self.table_name = :mapUniverse
  self.primary_key = :universeID

  attr_accessible :universeID, :universeName, :x, :y, :z, :xMin, :xMax, :yMin, :yMax, :zMin, :zMax, :radius
end
