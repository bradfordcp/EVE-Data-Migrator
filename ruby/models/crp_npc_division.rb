class CrpNPCDivision < ActiveRecord::Base
  self.table_name = :crpNPCDivisions
  self.primary_key = :divisionID

  attr_accessible :divisionID, :divisionName, :description, :leaderType
end
