class MapConstellationJump < ActiveRecord::Base
  self.table_name = :mapConstellationJumps

  attr_accessible :fromRegionID, :fromConstellationID, :toConstellationID, :toRegionID
end 
