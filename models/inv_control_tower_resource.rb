class InvControlTowerResource < ActiveRecord::Base
  self.table_name = :invControlTowerResources

  attr_accessible :controlTowerTypeID, :resourceTypeID, :purpose, :quantity, :minSecurityLevel, :factionID
end
