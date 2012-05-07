class EveIcon < ActiveRecord::Base
  self.table_name = :eveIcons
  self.primary_key = :iconID

  attr_accessible :iconID, :iconFile, :description
end
