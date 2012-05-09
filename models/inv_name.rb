class InvName < ActiveRecord::Base
  self.table_name = :invNames
  self.primary_key = :itemID

  attr_accessible :itemID, :itemName
end
