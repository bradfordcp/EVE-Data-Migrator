class PlanetSchematicsPinMap < ActiveRecord::Base
  self.table_name = :planetSchematicsPinMap

  attr_accessible :schematicID, :pinTypeID
end
