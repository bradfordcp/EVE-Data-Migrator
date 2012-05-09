class InvType < ActiveRecord::Base
  self.table_name = :invTypes
  self.primary_key = :typeID

  attr_accessible :typeID, :groupID, :typeName, :description, :graphicID, :radius, :mass, :volume, :capacity, :portionSize, :raceID, :basePrice, :published, :marketGroupID, :chanceOfDuplicating, :iconID
end
