class InvPosition < ActiveRecord::Base
  self.table_name = :invPositions
  self.primary_key = :itemID

  attr_accessible :itemID, :x, :y, :z, :yaw, :pitch, :roll
end
