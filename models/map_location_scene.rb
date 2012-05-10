class MapLocationScene < ActiveRecord::Base
  self.table_name = :mapLocationScenes
  self.primary_key = :locationID

  attr_accessible :locationID, :graphicID
end
