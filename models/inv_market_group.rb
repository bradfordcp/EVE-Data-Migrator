class InvMarketGroup < ActiveRecord::Base
  self.table_name = :invMarketGroups
  self.primary_key = :marketGroupID

  attr_accessible :marketGroupID, :parentGroupID, :marketGroupName, :description, :iconID, :hasTypes
end
