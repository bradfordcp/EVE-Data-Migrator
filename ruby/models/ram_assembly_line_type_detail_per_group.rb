class RamAssemblyLineTypeDetailPerGroup < ActiveRecord::Base
  self.table_name = :ramAssemblyLineTypeDetailPerGroup

  attr_accessible :assemblyLineTypeID, :groupID, :timeMultiplier, :materialMultiplier
end
