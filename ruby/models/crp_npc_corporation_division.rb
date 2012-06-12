class CrpNPCCorporationDivision < ActiveRecord::Base
  self.table_name = :crpNPCCorporationDivisions
  
  attr_accessible :corporationID, :divisionID, :size
end
