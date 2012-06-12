class ChrAncestry < ActiveRecord::Base
  self.table_name = :chrAncestries
  self.primary_key = :ancestryID

  attr_accessible :ancestryID, :ancestryName, :bloodlineID, :description, :perception, :willpower, :charisma, :memory, :intelligence, :iconID, :shortDescription
end
