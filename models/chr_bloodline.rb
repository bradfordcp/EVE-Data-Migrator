class ChrBloodline < ActiveRecord::Base
  self.table_name = :chrBloodlines
  self.primary_key = :bloodlineID
  
  attr_accessible :bloodlineID, :raceID, :description, :maleDescription, :femaleDescription, :shipTypeID, :corporationID, :perception, :willpower, :charisma, :memory, :intelligence, :iconID, :shortDescription, :shortMaleDescription, :shortFemaleDescription
end
