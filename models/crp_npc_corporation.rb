class CrpNPCCorporation < ActiveRecord::Base
  self.table_name = :crpNPCCorporations
  self.primary_key = :corporationID
  
  attr_accessible :corporationID, :size, :extent, :solarSystemID, :investorID1, :investorShares1, :investorID2, :investorShares2, :investorID3, :investorShares3, :investorID4, :investorShares4, :friendID, :enemyID, :publicShares, :initialPrice, :minSecurity, :scattered, :fringe, :corridor, :hub, :border, :factionID, :sizeFactor, :stationCount, :stationSystemCount, :description, :iconID
end
