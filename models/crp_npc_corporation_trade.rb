class CrpNPCCorporationTrade < ActiveRecord::Base
  self.table_name = :crpNPCCorporationTrades
  
  attr_accessible :corporationID, :typeID
end
