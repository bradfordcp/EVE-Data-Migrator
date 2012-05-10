class StaStationType < ActiveRecord::Base
  self.table_name = :staStationTypes
  self.primary_key = :stationTypeID

  attr_accessible :stationTypeID, :dockEntryX, :dockEntryY, :dockEntryZ, :dockOrientationX, :dockOrientationY, :dockOrientationZ, :operationID, :officeSlots, :reprocessingEfficiency, :conquerable
end
