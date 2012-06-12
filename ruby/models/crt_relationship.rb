class CrtRelationship < ActiveRecord::Base
  self.table_name = :crtRelationships
  self.primary_key = :relationshipID

  attr_accessible :relationshipID, :parentID, :parentTypeID, :parentLevel, :childID
end
