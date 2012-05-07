class DgmAttributeType < ActiveRecord::Base
  self.table_name = :dgmAttributeTypes
  self.primary_key = :attributeID

  attr_accessible :attributeID, :attributeName, :description, :iconID, :defaultValue, :published, :displayName, :unitID, :stackable, :highIsGood, :categoryID
end
