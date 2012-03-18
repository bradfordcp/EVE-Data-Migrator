class CCPBloodline < ActiveRecord::Base

  self.table_name = "dbo.chrBloodlines"

  def to_rails_model
    Bloodline.create(
      :id => self.bloodlineID,
      :name => self.bloodlineName,
      :race_id => self.raceID,
      :description => self.description,
      :short_description => self.shortDescription,
      :male_description => self.maleDescription,
      :short_male_description => self.shortMaleDescription,
      :female_description => self.femaleDescription,
      :short_female_description => self.shortFemaleDescription,
      :ship_type_id => self.shipTypeID,
      :corporation_id => self.corporationID,
      :perception => self.perception,
      :willpower => self.willpower,
      :charisma => self.charisma,
      :memory => self.memory,
      :intelligence => self.intelligence,
      :icon_id => self.iconID,
    )
  end

end
