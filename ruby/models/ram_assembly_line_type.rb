class RamAssemblyLineType < ActiveRecord::Base
  self.table_name = :ramAssemblyLineTypes
  self.primary_key = :assemblyLineTypeID

  attr_accessible :assemblyLineTypeID, :assemblyLineTypeName, :description, :baseTimeMultiplier, :baseMaterialMultiplier, :volume, :activityID, :minCostPerHour
end
