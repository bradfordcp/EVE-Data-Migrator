class MapSolarSystemJump < ActiveRecord::Base
  self.table_name = :mapSolarSystemJumps

  attr_accessible :fromRegionID, :fromConstellationID, :fromSolarSystemID, :toSolarSystemID, :toConstellationID, :toRegionID
end
