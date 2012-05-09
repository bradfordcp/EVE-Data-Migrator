class InvMetaType < ActiveRecord::Base
  self.table_name = :invMetaTypes
  self.primary_key = :typeID

  attr_accessible :typeID, :parentTypeID, :metaGroupID
end
