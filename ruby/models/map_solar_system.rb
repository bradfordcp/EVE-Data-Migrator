class MapSolarSystem < ActiveRecord::Base
  self.table_name = :mapSolarSystems
  self.primary_key = :solarSystemID

  attr_accessible :regionID, :constellationID, :solarSystemID, :solarSystemName, :x, :y, :z, :xMin, :xMax, :yMin, :yMax, :zMin, :zMax, :luminosity, :border, :fringe, :corridor, :hub, :international, :regional, :constellation, :security, :factionID, :radius, :sunTypeID, :securityClass
end
