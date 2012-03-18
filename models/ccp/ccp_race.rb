class CCPRace < ActiveRecord::Base

  self.table_name = "dbo.chrRaces"

  def to_rails_model
    Race.create(
      :id => self.raceID,
      :name => self.raceName,
      :description => self.description,
      :icon_id => self.iconID,
      :short_description => self.shortDescription
    )
  end

end