class ChrRace < ActiveRecord::Base
  self.table_name = :chrRaces
  self.primary_key = :raceID
  
  attr_accessible :raceID, :raceName, :description, :iconID, :shortDescription
end
