class MapJump < ActiveRecord::Base
  self.table_name = :mapJumps
  self.primary_key = :stargateID

  attr_accessible :stargateID, :celestialID
end
