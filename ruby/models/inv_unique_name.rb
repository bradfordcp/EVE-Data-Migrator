class InvUniqueName < ActiveRecord::Base
  self.table_name = :invUniqueNames
  self.primary_key = :itemID

  attr_accessible :itemID, :itemName, :groupID
end
