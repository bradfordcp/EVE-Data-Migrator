class DgmTypeAttribute < ActiveRecord::Base
  self.table_name = :dgmTypeAttributes

  attr_accessible :typeID, :attributeID, :valueInt, :valueFloat
end
