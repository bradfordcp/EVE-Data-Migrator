class EveGraphic < ActiveRecord::Base
  self.table_name = :eveGraphics
  self.primary_key = :graphicID

  attr_accessible :graphicID, :graphicFile, :description, :obsolete, :graphicType, :collidable, :explosionID, :directoryID, :graphicName
end
