class StaStation < ActiveRecord::Base
  self.table_name = :staStations
  self.primary_key = :stationID

  attr_accessible :stationID, :security, :dockingCostPerVolume, :maxShipVolumeDockable, :officeRentalCost, :operationID, :stationTypeID, :corporationID, :solarSystemID, :constellationID, :regionID, :stationName, :x, :y, :z, :reprocessingEfficiency, :reprocessingStationsTake, :reprocessingHangarFlag
end
