class MapLandmark < ActiveRecord::Base
  self.table_name = :mapLandmarks
  self.primary_key = :landmarkID

  attr_accessible :landmarkID, :landmarkName, :description, :locationID, :x, :y, :z, :radius, :iconID, :importance
end
