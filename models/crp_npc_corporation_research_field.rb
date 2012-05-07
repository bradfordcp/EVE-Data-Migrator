class CrpNPCCorporationResearchField < ActiveRecord::Base
  self.table_name = :crpNPCCorporationResearchFields
  
  attr_accessible :skillID, :corporationID
end
