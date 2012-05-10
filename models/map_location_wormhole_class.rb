class MapLocationWormholeClass < ActiveRecord::Base
  self.table_name = :mapLocationWormholeClasses
  self.primary_key = :locationID

  attr_accessible :locationID, :wormholeClassID
end
