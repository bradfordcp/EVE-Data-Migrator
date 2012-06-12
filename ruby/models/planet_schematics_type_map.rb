class PlanetSchematicsTypeMap < ActiveRecord::Base
  self.table_name = :planetSchematicsTypeMap

  attr_accessible :schematicID, :typeID, :quantity, :isInput
end
