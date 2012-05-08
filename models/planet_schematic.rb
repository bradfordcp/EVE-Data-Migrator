class PlanetSchematic < ActiveRecord::Base
  self.table_name = :planetSchematics
  self.primary_key = :schematicID

  attr_accessible :schematicID, :schematicName, :cycleTime
end
