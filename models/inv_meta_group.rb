class InvMetaGroup < ActiveRecord::Base
  self.table_name = :invMetaGroups
  self.primary_key = :metaGroupID

  attr_accessible :metaGroupID, :metaGroupName, :description, :iconID
end
