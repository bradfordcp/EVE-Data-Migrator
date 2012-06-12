class EveUnit < ActiveRecord::Base
  self.table_name = :eveUnits
  self.primary_key = :unitID

  attr_accessible :unitID, :unitName, :displayName, :description
end
