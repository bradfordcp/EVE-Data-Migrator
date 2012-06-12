class MapRegionJump < ActiveRecord::Base
  self.table_name = :mapRegionJumps

  attr_accessible :fromRegionID, :toRegionID
end
