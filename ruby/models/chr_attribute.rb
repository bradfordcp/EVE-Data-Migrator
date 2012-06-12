class ChrAttribute < ActiveRecord::Base
  self.table_name = :chrAttributes
  self.primary_key = :attributeID
  
  attr_accessible :attributeID, :attributeName, :description, :iconID, :shortDescription, :notes
end
