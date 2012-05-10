class RamAssemblyLineStation < ActiveRecord::Base
  self.table_name = :ramAssemblyLineStations

  attr_accessible :stationID, :assemblyLineTypeID, :quantity, :stationTypeID, :ownerID, :solarSystemID, :regionID
end
