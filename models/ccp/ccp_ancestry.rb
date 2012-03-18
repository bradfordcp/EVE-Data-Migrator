class CCPAncestry < ActiveRecord::Base

  self.table_name = "dbo.chrAncestries"

  def to_rails_model
    Ancestry.create(
      :id => self.ancestryID,
      :name => self.ancestryName,
      :bloodline_id => self.bloodlineID,
      :description => self.description,
      :short_description => self.shortDescription,
      :perception => self.perception,
      :willpower => self.willpower,
      :charisma => self.charisma,
      :memory => self.memory,
      :intelligence => self.intelligence,
      :icon_id => self.iconID
    )
  end

end