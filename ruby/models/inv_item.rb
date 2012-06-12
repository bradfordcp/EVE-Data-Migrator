class InvItem < ActiveRecord::Base
  self.table_name = :invItems
  self.primary_key = :itemID

  attr_accessible :itemID, :typeID, :ownerID, :locationID, :flagID, :quantity
end
