class MapCelestialStatistic < ActiveRecord::Base
  self.table_name = :mapCelestialStatistics
  self.primary_key = :celestialID

  attr_accessible :celestialID, :temperature, :spectralClass, :luminosity, :age, :life, :orbitRadius, :eccentricity, :massDust, :massGas, :fragmented, :density, :surfaceGravity, :escapeVelocity, :orbitPeriod, :rotationRate, :locked, :pressure, :radius, :mass
end
