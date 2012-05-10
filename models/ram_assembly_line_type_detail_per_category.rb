class RamAssemblyLineTypeDetailPerCategory < ActiveRecord::Base
  self.table_name = :ramAssemblyLineTypeDetailPerCategory

  attr_accessible :assemblyLineTypeID, :categoryID, :timeMultiplier, :materialMultiplier
end
