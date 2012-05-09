class InvFlag < ActiveRecord::Base
  self.table_name = :invFlags
  self.primary_key = :flagID

  attr_accessible :flagID, :flagName, :flagText, :orderID
end
